using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ExamenAnalisis2PrimerParcial
{
    public class JsonSerializer
    {
        private readonly List<Type> _acceptedDataTypes = new List<Type>
        {
            typeof(int),
            typeof(float),
            typeof(String),
            typeof(DateTime)
        };

        public string Serialize(Object classObject)
        {
            var serializedObject = SerializeObject(classObject, true);
            return serializedObject;
        }

        private string SerializeObject(object classObject, bool enableBrackets)
        {
            var serializedObject = "{";
            var classType = classObject.GetType();
            if (_acceptedDataTypes.Contains(classType))
            {
                serializedObject = "'" + (String.IsNullOrEmpty("" + classObject) ? "null" : classObject) + "'";
                return serializedObject;
            }
            else if (!classType.IsPrimitive && !(classType == typeof(IEnumerable<>)))
            {
                MemberInfo[] objectElements =
                    classType.GetFields(BindingFlags.Public | BindingFlags.Instance).Cast<MemberInfo>()
                        .Concat(classType.GetProperties(BindingFlags.Public | BindingFlags.Instance)).ToArray();
                serializedObject = objectElements.Aggregate(serializedObject,
                    (current, elementInfo) => SerializeMember(classObject, elementInfo, current));
            }
            else if (classType == typeof (IEnumerable<>))
            {
                serializedObject = ((IEnumerable) classObject).Cast<object>()
                    .Aggregate(serializedObject, (current, element) => current + Serialize(element));
            }
            if (serializedObject.EndsWith(", "))
                serializedObject = serializedObject.Remove(serializedObject.LastIndexOf(", ", StringComparison.Ordinal), 2);
            serializedObject += "}";
            return serializedObject;
        }

        private string SerializeMember(Object classobject, MemberInfo memberInfo, string json)
        {
            var type = GetMemberType(memberInfo);
            string memberName = GetMemberName(memberInfo);
            if (_acceptedDataTypes.Contains(type))
            {
                json += "'" + memberName + "' : '";
                if (memberInfo is FieldInfo)
                    json += (String.IsNullOrEmpty("" + ((FieldInfo)memberInfo).GetValue(classobject)) ? "null" : ((FieldInfo)memberInfo).GetValue(classobject)) + "', ";
                else
                    json += (String.IsNullOrEmpty("" + ((PropertyInfo)memberInfo).GetValue(classobject)) ? "null" : ((PropertyInfo)memberInfo).GetValue(classobject)) + "', ";
            }
            else if (type.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
            {
                json += "'" + memberName + "' : [";
                if (memberInfo is FieldInfo)
                    json = ((IEnumerable)((FieldInfo)memberInfo).GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element) + ", ");
                else
                    json = ((IEnumerable)((PropertyInfo)memberInfo).GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element) + ", ");
                if (json.EndsWith(", "))
                    json = json.Remove(json.LastIndexOf(", ", StringComparison.Ordinal), 2);
                json += "]";
            }
            else if (!type.IsPrimitive)
            {
                if (memberInfo is FieldInfo)
                    json += Serialize(((FieldInfo) memberInfo).GetValue(classobject)) + ", ";
                else
                    if(((PropertyInfo)memberInfo).GetIndexParameters().Length == 0)
                        json += Serialize(((PropertyInfo)memberInfo).GetValue(classobject)) + ", ";
            }
            return json;
        }

        private string GetMemberName(MemberInfo memberInfo)
        {
            string memberName = memberInfo.Name;
            var memberAttributes = memberInfo.GetCustomAttributes(true);
            foreach (var memberAttribute in memberAttributes)
            {
                var jsonname = memberAttribute as JSONName;
                if (jsonname != null)
                    memberName = jsonname.Name;
            }
            return memberName;
        }

        private Type GetMemberType(MemberInfo memberInfo)
        {
            return memberInfo.MemberType == MemberTypes.Field
                ? ((FieldInfo)memberInfo).FieldType
                : ((PropertyInfo)memberInfo).PropertyType;
        }
    }
}
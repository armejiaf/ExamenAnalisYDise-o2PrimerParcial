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

        private readonly List<Type>  _dataTypesWithQuotes = new List<Type>
        {
            typeof(String),
            typeof(DateTime)
        };
        public string Serialize(Object classObject)
        {
            if (classObject == null)
                return "null";
            var serializedObject = "{";
            var classType = classObject.GetType();
            if (_acceptedDataTypes.Contains(classType))
            {
                if (_dataTypesWithQuotes.Contains(classType))
                    serializedObject = "'" + classObject + "'";
                else
                    serializedObject = classObject + "";
                return serializedObject;
            }
            if (!classType.IsPrimitive && !(classType == typeof(IEnumerable<>)))
            {
                var objectElements =
                    classType.GetFields(BindingFlags.Public | BindingFlags.Instance).Cast<MemberInfo>()
                        .Concat(classType.GetProperties(BindingFlags.Public | BindingFlags.Instance)).ToArray();
                serializedObject = objectElements.Aggregate(serializedObject,
                    (current, elementInfo) => SerializeMember(classObject, elementInfo, current));
            }
            else if (classType == typeof(IEnumerable<>))
            {
                serializedObject = ((IEnumerable)classObject).Cast<object>()
                    .Aggregate(serializedObject, (current, element) => current + Serialize(element));
            }
            serializedObject = TrimCommas(serializedObject);
            serializedObject += "}";
            return serializedObject;
        }

        private string SerializeMember(Object classobject, MemberInfo memberInfo, string json)
        {
            var type = GetMemberType(memberInfo);
            var memberName = GetMemberName(memberInfo);
            if (_acceptedDataTypes.Contains(type))
            {
                if (_dataTypesWithQuotes.Contains(type))
                    json += "'" + memberName + "' : '";
                else
                    json += "'" + memberName + "' : ";
                if (memberInfo is FieldInfo)
                    json += (String.IsNullOrEmpty("" + ((FieldInfo)memberInfo).GetValue(classobject)) ? "null" : ((FieldInfo)memberInfo).GetValue(classobject)) + "";
                else
                    json += (String.IsNullOrEmpty("" + ((PropertyInfo)memberInfo).GetValue(classobject)) ? "null" : ((PropertyInfo)memberInfo).GetValue(classobject)) + "";
                if (_dataTypesWithQuotes.Contains(type))
                    json += "', ";
                else
                    json += ", ";
            }
            else if (type.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
            {
                json += "'" + memberName + "' : [";
                if (memberInfo is FieldInfo)
                    json = ((IEnumerable)((FieldInfo)memberInfo).GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element) + ", ");
                else
                    json = ((IEnumerable)((PropertyInfo)memberInfo).GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element) + ", ");
                json = TrimCommas(json);
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

        private static string TrimCommas(string serializedObject)
        {
            if (serializedObject.EndsWith(", "))
                serializedObject = serializedObject.Remove(serializedObject.LastIndexOf(", ", StringComparison.Ordinal), 2);
            return serializedObject;
        }

        private string GetMemberName(MemberInfo memberInfo)
        {
            var memberName = memberInfo.Name;
            var memberAttributes = memberInfo.GetCustomAttributes(true);
            foreach (var memberAttribute in memberAttributes)
            {
                var jsonname = memberAttribute as JsonName;
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
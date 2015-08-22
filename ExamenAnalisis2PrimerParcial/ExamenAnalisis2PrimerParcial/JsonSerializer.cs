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
            var serializedObject = SerializeObject(classObject);
            return serializedObject;
        }

        private string SerializeObject(object classObject)
        {
            var serializedObject = "{";
            var classType = classObject.GetType();

            if (_acceptedDataTypes.Contains(classType))
            {
                serializedObject += "'" + (String.IsNullOrEmpty("" + classObject) ? "null" : classObject) + "', ";
            }
            else if (!classType.IsPrimitive && !(classType == typeof(IEnumerable<>)))
            {
                var objectProperties = classType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                var objectFields = classType.GetFields(BindingFlags.Public | BindingFlags.Instance);
                serializedObject = objectProperties.Aggregate(serializedObject,
                    (current, propertyInfo) => SerializeMember(classObject, propertyInfo, current));
                serializedObject = objectFields.Aggregate(serializedObject,
                    (current, fieldInfo) => SerializeMember(classObject, fieldInfo, current));
            }
            else if (classType == typeof (IEnumerable<>))
            {
                serializedObject = ((IEnumerable) classObject).Cast<object>()
                    .Aggregate(serializedObject, (current, element) => current + Serialize(element));
            }

            if (serializedObject.Contains(","))
                serializedObject = serializedObject.Remove(serializedObject.LastIndexOf(", ", StringComparison.Ordinal), 2);
            
            serializedObject += "}";

            return serializedObject;
        }

        private string SerializeMember(Object classobject, MemberInfo memberInfo, string json)
        {
            var type = memberInfo.MemberType == MemberTypes.Field 
                ? ((FieldInfo) memberInfo).FieldType
                : ((PropertyInfo)memberInfo).PropertyType;
            if (_acceptedDataTypes.Contains(type))
            {
                if (memberInfo is FieldInfo)
                    json += "'" + memberInfo.Name + "' : '" +
                    (String.IsNullOrEmpty("" + ((FieldInfo)memberInfo).GetValue(classobject)) ? "null" : ((FieldInfo)memberInfo).GetValue(classobject)) + "', ";
                else
                    json += "'" + memberInfo.Name + "' : '" +
                    (String.IsNullOrEmpty("" + ((PropertyInfo)memberInfo).GetValue(classobject)) ? "null" : ((PropertyInfo)memberInfo).GetValue(classobject)) + "', ";
            }
            else if (type.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
            {
                json += "'" + memberInfo.Name + "' : [";
                if (memberInfo is FieldInfo)
                    json = ((IEnumerable)((FieldInfo)memberInfo).GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element) + ", ");
                else
                    json = ((IEnumerable)((PropertyInfo)memberInfo).GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element) + ", ");
                json += "]";
            }
            else if (!type.IsPrimitive)
            {
                if (memberInfo is FieldInfo)
                    json += Serialize(((FieldInfo) memberInfo).GetValue(classobject)) + ", ";
                else
                {
                    var n = ((PropertyInfo) memberInfo).GetIndexParameters().Length;
                    if(((PropertyInfo)memberInfo).GetIndexParameters().Length == 0)
                        json += Serialize(((PropertyInfo)memberInfo).GetValue(classobject)) + ", ";
                }
            }
            return json;
        }
    }
}
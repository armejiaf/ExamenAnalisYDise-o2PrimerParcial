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

        /*public string Serialize(Object classobject)
        {
            string serializedObject = "{";
            if (_acceptedDataTypes.Contains(classobject.GetType()))
            {
                serializedObject += "\n\t'" + classobject + "'";
            }
            else if(!classobject.GetType().IsPrimitive && !(classobject is IEnumerable))
            {
                var objectProperties = classobject.GetType().GetProperties(BindingFlags.Public);
                var objectFields = classobject.GetType().GetFields(BindingFlags.Public);
                serializedObject = objectProperties.Aggregate(serializedObject, (current, propertyInfo) => SerializeProperty(classobject, propertyInfo, current));
                serializedObject = objectFields.Aggregate(serializedObject, (current, fieldInfo) => SerializeField(classobject, fieldInfo, current));
            }
            else if (classobject is IEnumerable)
            {
                serializedObject = ((IEnumerable) classobject).Cast<object>().Aggregate(serializedObject, (current, element) => current + Serialize(element));
            }
            serializedObject += "\n}";
            return serializedObject;
        }

        private string SerializeField(Object classobject, FieldInfo fieldInfo, string json)
        {
            if (_acceptedDataTypes.Contains(fieldInfo.FieldType))
                json += "\n\t'" + fieldInfo.Name + "' : '" + fieldInfo.GetValue(classobject) + "',";
            else if (fieldInfo.GetValue(classobject) is IEnumerable)
            {
                json = ((IEnumerable) fieldInfo.GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element));
            }
            else if (!fieldInfo.GetType().IsPrimitive)
            {
                json += Serialize(fieldInfo.GetValue(classobject));
            }
            return json;
        }

        private string SerializeProperty(Object classobject, PropertyInfo propertyInfo, string json)
        {
            if (_acceptedDataTypes.Contains(propertyInfo.PropertyType))
                json += "\n\t'" + propertyInfo.Name + "' : '" + propertyInfo.GetValue(classobject) + "',";
            else if (propertyInfo.GetValue(classobject) is IEnumerable)
            {
                json = ((IEnumerable) propertyInfo.GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element));
            }
            else if (!propertyInfo.GetType().IsPrimitive)
            {
                json += Serialize(propertyInfo.GetValue(classobject));
            }
            return json;
        }*/
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
                    (current, propertyInfo) => SerializeProperty(classObject, propertyInfo, current));
                serializedObject = objectFields.Aggregate(serializedObject,
                    (current, fieldInfo) => SerializeField(classObject, fieldInfo, current));
            }
            else if (classType == typeof (IEnumerable<>))
            {
                serializedObject = ((IEnumerable) classObject).Cast<object>()
                    .Aggregate(serializedObject, (current, element) => current + Serialize(element));
            }

            if (serializedObject.Contains(","))
                serializedObject = serializedObject.Remove(serializedObject.LastIndexOf(", "), 2);
            
            serializedObject += "}";

            return serializedObject;
        }

        private string SerializeField(Object classobject, FieldInfo fieldInfo, string json)
        {
            if (_acceptedDataTypes.Contains(fieldInfo.FieldType))
                json += "'" + fieldInfo.Name + "' : '" +
                    (String.IsNullOrEmpty("" + fieldInfo.GetValue(classobject)) ? "null" : fieldInfo.GetValue(classobject)) + "', ";
            else if (fieldInfo.GetType().GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
            {
                json = ((IEnumerable)fieldInfo.GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element));
            }
            else if (!fieldInfo.GetType().IsPrimitive)
            {
                json += Serialize(fieldInfo.GetValue(classobject))+", ";
            }
            return json;
        }

        private string SerializeProperty(Object classobject, PropertyInfo propertyInfo, string json)
        {
            if (_acceptedDataTypes.Contains(propertyInfo.PropertyType))
                json += "'" + propertyInfo.Name + "' : '" +
                    (String.IsNullOrEmpty(""+propertyInfo.GetValue(classobject)) ? "null" : propertyInfo.GetValue(classobject)) + "', ";
            else if (propertyInfo.GetType().GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
            {
                json = ((IEnumerable)propertyInfo.GetValue(classobject)).Cast<object>().Aggregate(json, (current, element) => current + Serialize(element));
            }
            else if (!propertyInfo.GetType().IsPrimitive)
            {
                json += Serialize(propertyInfo.GetValue(classobject))+", ";
            }
            return json;
        }
    }
}
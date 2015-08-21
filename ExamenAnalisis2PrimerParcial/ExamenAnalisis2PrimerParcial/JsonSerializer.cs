using System;
using System.Collections;
using System.Collections.Generic;
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

        public string Serialize(Object classobject)
        {
            string serializedObject = "{\n";
            var objectProperties = classobject.GetType().GetProperties(BindingFlags.Public);
            var objectFields = classobject.GetType().GetFields(BindingFlags.Public);
            foreach (var propertyInfo in objectProperties)
            {
                serializedObject = SerializeElement(classobject, propertyInfo, serializedObject);
            }
            serializedObject += "}";
            return serializedObject;
        }

        private string SerializeElement(Object classobject, PropertyInfo propertyInfo, string json)
        {
            if (propertyInfo == null)
            {
                json += "\"" + classobject + "\",\n";
                return json;
            }
            if (_acceptedDataTypes.Contains(propertyInfo.PropertyType))
                json += "\"" + propertyInfo.Name + "\" : \"" + propertyInfo.GetValue(classobject) + "\",\n";
            else if (propertyInfo.GetValue(classobject) is IEnumerable)
            {
                foreach (var element in (IEnumerable)propertyInfo.GetValue(classobject))
                {
                    SerializeElement(element, null, json);
                }
            }
            return json;
        }
    }
}
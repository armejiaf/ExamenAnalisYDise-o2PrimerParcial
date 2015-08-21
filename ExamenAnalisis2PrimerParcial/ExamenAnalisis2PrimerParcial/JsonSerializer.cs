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

        public string Serialize(Object classobject)
        {
            string serializedObject = "{\n";
            if (_acceptedDataTypes.Contains(classobject.GetType()))
            {
                serializedObject += "\t\"" + classobject + "\",\n}";
                return serializedObject;
            }
            
            if(!classobject.GetType().IsPrimitive)
            {
                var objectProperties = classobject.GetType().GetProperties(BindingFlags.Public);
                var objectFields = classobject.GetType().GetFields(BindingFlags.Public);
                serializedObject = objectProperties.Aggregate(serializedObject, (current, propertyInfo) => SerializeProperty(classobject, propertyInfo, current));
                serializedObject = objectFields.Aggregate(serializedObject, (current, fieldInfo) => SerializeField(classobject, fieldInfo, current));
                serializedObject += "}";
            }
            return serializedObject;
        }

        private string SerializeField(Object classobject, FieldInfo propertyInfo, string json)
        {
            throw new NotImplementedException();
        }

        private string SerializeProperty(Object classobject, PropertyInfo propertyInfo, string json)
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
                    SerializeProperty(element, null, json);
                }
            }
            return json;
        }
    }
}
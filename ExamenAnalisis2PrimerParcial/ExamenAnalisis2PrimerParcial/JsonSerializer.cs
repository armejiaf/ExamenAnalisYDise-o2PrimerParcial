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
            foreach (var propertyInfo in objectProperties)
            {
                //need to tell classes and IEnumerables apart from the rest of the accepted data types.
                if (_acceptedDataTypes.Contains(propertyInfo.PropertyType))
                    serializedObject += "\"" + propertyInfo.Name + "\" : \"" + propertyInfo.GetValue(classobject) + "\",\n";
                else if (propertyInfo is IEnumerable)
                    ;
            }
            serializedObject += "}";
            return serializedObject;
        }
    }
}
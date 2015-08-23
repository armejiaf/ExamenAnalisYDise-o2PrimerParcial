namespace ExamenAnalisis2PrimerParcial
{
    [System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Property)]
    public class JsonName : System.Attribute
    {
        public string Name;

        public JsonName(string name)
        {
            Name = name;
        }
    }
}

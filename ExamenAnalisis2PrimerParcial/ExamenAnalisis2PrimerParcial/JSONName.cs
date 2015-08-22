namespace ExamenAnalisis2PrimerParcial
{
    [System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Property)]
    public class JSONName : System.Attribute
    {
        public string Name;

        public JSONName(string name)
        {
            Name = name;
        }
    }
}

using ExamenAnalisis2PrimerParcial;

namespace Examen1.specs.TestClasses
{
    public class ClassWithNamedProperties : IClass
    {
        [JsonName("Nombre")]
        public string Name { get; set; }

        [JsonName("Identificacion")]
        public int ID { get; set; }
    }
}

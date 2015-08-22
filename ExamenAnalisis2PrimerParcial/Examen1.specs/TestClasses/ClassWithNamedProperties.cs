using ExamenAnalisis2PrimerParcial;

namespace Examen1.specs.TestClasses
{
    public class ClassWithNamedProperties : IClass
    {
        [JSONName("Nombre")]
        public string Name { get; set; }

        [JSONName("Identificacion")]
        public int ID { get; set; }
    }
}

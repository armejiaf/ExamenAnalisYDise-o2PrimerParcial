﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.specs.TestClasses
{
    class ClassWithBasicTypesAndClassArray
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public float Salary { get; set; }
        public DateTime Birthday { get; set; }
        public List<IClass> MyClassArray { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace poo.concepts.Inheritance
{
    public sealed class Departament
    {
        //this class can not be used for inheritance
        public decimal AreaOfBuilding { get; set; }
    }

    // this for example is invalid
    //public sealed class SuiteDepartament : Departament { }
}

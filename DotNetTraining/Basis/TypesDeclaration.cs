using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetTraining.Basis
{
    class TypesDeclaration
    {
        //Explore multiple ways to declare data types and print on console

        public void displayStrings() 
        {
            string emptyValue = null;
            string nonEmptyValue = "my favorite movie";

            Console.WriteLine("Length:" + emptyValue.Length);
            Console.WriteLine("Length:" + nonEmptyValue!.Length) ;
        }
        


    }
}

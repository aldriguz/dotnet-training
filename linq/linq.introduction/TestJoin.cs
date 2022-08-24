using System;
using System.Linq;
using System.Collections.Generic;

namespace linq.introduction
{
    public class TestJoin
    {
        public class OfferValue
        {
            public string ClientFullName { get; set; }
            public string ProductName { get; set; }
            public string Process { get; set; }
            public int ProcessId { get; set; }
            public string Benefict { get; set; }
        }
        
        public class Branch
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public string Abr { get; set; }
        }
        
        public static void JoinAndPrintLinq()
        {
            List<OfferValue> listOfferValues = new List<OfferValue>();
            List<Branch> listBranch = new List<Branch>();
            
            //
            listBranch.Add(new Branch {
                Code = 10,
                Name = "ACCIDENTES INDIVIDUALES",
                Abr = "A. IND"
            });
            
            listBranch.Add(new Branch {
                Code = 6,
                Name = "ACCIDENTES COLECTIVOS",
                    Abr = "A.P.C"
            });
            
            listBranch.Add(new Branch {
                Code = 5,
                Name = "CENTRO MEDICO",
                Abr = "C:. MED"
            });
            
            //
            listOfferValues.Add(new OfferValue {
                ClientFullName = "Kevin Alama Rodriguez",
                ProductName = "Autos",
                Process = "",
                ProcessId = 10,
                Benefict = "En tu próximo SOAT tendrás el % de dscto"
            });
            
            listOfferValues.Add(new OfferValue {
                ClientFullName = "María Claudia Del Castillo",
                ProductName = "Vehículos",
                Process = "",
                ProcessId = 10,
                Benefict = "Te descontamos S/.100 en el valor de la prima"
            });
            
            listOfferValues.Add(new OfferValue {
                ClientFullName = "Ivanna Cabrera",
                ProductName = "Camión",
                Process = "",
                ProcessId = 5,
                Benefict = "En tu próximo SATT tendrás el % de dscto"
            });
            
            listOfferValues.Add(new OfferValue {
                ClientFullName = "Armando Alama",
                ProductName = "Inmueble",
                Process = "",
                ProcessId = 6,
                Benefict = "En tu AAAAA de dscto"
            });
            
            //	
            var query = from offerValue in listOfferValues
                    join branch in listBranch on offerValue.ProcessId equals branch.Code
                    select new OfferValue { 
                            ClientFullName = offerValue.ClientFullName, 
                            ProductName = offerValue.ProductName, 
                            Process = branch.Name,
                            Benefict = offerValue.Benefict
                    };
            
            foreach (OfferValue item in query)  
                    Console.WriteLine(item.Process + ": " + item.ClientFullName);
            
            //Console.WriteLine(listOfferValues[0].ProductName);
            
        }
    }

}
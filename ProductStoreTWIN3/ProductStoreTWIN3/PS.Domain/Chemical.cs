using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
   public class Chemical : Product
    {
        public String City { get; set; }
        public String LabName { get; set; }
        public String StreetAddress { get; set; }
        public override void GetMyType()
        {
            //Console.WriteLine("Je suis un produit");
            base.GetMyType();
            Console.WriteLine(" Chemical");
        }
        public override string ToString()
        {
            return base.ToString()+"City :"+City;
        }
    }
    
   

}

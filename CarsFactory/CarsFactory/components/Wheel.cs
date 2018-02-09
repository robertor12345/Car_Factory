using System;
using System.Collections.Generic;
using System.Text;

namespace CarsFactory
{
   public class Wheel : ICarComponent
   {
       private string CarType;
        public Wheel(string carType)
        {
            this.CarType = carType;
            SetAttributes();
            GetAttributes();
        }

        public Wheel()
       {
           this.CarType = "default";
           SetAttributes();
           GetAttributes();
       }

       public string tyreType { get; private set; }
        public string rimsType { get; private set; }

        public void SetAttributes()
        {
            switch (CarType)
            {
                case "default":
                    tyreType = "standard on-road";
                    rimsType = "steel rims";
                    break;

                case "off road":
                    tyreType = "off road";
                    rimsType = "steel rims";
                    break;

                case "sports car":
                    tyreType = "high traction";
                    rimsType = "steel rims";
                    break;
            }
        }

       public List<string> GetAttributes()
       {

           var attributes= new List<string>();

           attributes.Add(tyreType);
           attributes.Add(rimsType);

            return attributes;
       }
   }
}


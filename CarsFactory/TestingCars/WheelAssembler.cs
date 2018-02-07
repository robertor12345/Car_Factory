using CarsFactory;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestingCars
{
    public class WheelAssembler: IAssemblyFactory
    {
        public string CarType { get; set; }

        public WheelAssembler(string carType)
        {
            this.CarType = carType;
        }

        public WheelAssembler()
        { 
        }

        public List<string> Create()
        {
            List<string> wheelList = new List<string>();
            Wheel wheel = new Wheel();

            if (CarType== "off road")
            {
                wheelList.Add("steel rims");
                wheelList.Add("offroad tyres");
                
            }
            else
            {

                wheelList.Add("rims");
                wheelList.Add( "high traction");
            }
          

            return wheelList;
        }
    }
}
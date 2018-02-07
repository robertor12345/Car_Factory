using CarsFactory;
using System;
using System.Collections.Generic;


namespace TestingCars
{
    public class WheelAssembler: IAssemblyFactory
    {
        public string CarType { get; set; }

        public WheelAssembler(string carType)
        {
            this.CarType = carType;
        }

        public WheelAssembler(){ }

        public List<string> Create()
        {
          List<string>  wheel = new List<string>();

            if (CarType== "off road")
            {
                wheel.Add("steel rims");
                wheel.Add("offroad tyres");
            }
            else
            {
                wheel.Add("rims");
                wheel.Add("high traction");
            }

            return wheel;
        }
    }
}
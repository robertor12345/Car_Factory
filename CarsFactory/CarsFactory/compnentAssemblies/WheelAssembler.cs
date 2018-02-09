using CarsFactory;
using System;
using System.Collections.Generic;


namespace TestingCars
{
    public class WheelAssembler: IComponentAssembly
    {
        public string CarType { get; set; }

        public WheelAssembler(string carType)
        {
            this.CarType = carType;
        }

        public WheelAssembler(){ }

        public ICarComponent CreateComponent()
        {
            return new Wheel(CarType);
        }
    }
}
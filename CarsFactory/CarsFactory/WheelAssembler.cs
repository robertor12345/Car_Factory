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

        public ICarComponent Create()
        {
            return new Wheel(CarType);
        }
    }
}
using System;
using System.Collections.Generic;


namespace CarsFactory
{
    public interface IComponentAssembly
    {
         ICarComponent CreateComponent();
    }
}

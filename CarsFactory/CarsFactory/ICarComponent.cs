using System;
using System.Collections.Generic;
using System.Text;

namespace CarsFactory
{
    public interface ICarComponent
    {
        void SetAttributes();
        List<string> GetAttributes();

    }
}

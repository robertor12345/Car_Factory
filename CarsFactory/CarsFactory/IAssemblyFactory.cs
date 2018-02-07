using System;
using System.Collections.Generic;


namespace CarsFactory
{
    public interface IAssemblyFactory
    {
        List<string> Create();
    }
}

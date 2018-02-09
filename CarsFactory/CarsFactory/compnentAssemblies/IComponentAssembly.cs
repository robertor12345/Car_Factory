
using System.Collections.Generic;
using VehichleFactory.compnentAssemblies;
using VehichleFactory.components;

namespace VehichleFactory.compnentAssemblies
{
    public interface IComponentAssembly
    {
         List<IComponent> CreateComponents();
    }
}

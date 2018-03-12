using System.Collections.Generic;
using VehichleFactory.Components;

namespace VehichleFactory.CompnentAssemblies
{
    public interface IComponentAssembly
    {
        List<IComponent> CreateComponents();
    }
}
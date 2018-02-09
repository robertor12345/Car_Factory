using System.Collections.Generic;

namespace VehichleFactory.components
{
    public interface IComponent
    {

        string ComponentName { get; set;}
        void SetAttributes();
        List<string> GetCompoent();

    }
}

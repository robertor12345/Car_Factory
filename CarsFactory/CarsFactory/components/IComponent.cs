using System.Collections.Generic;

namespace VehichleFactory.Components
{
    public interface IComponent
    {
        string ComponentName { get; set; }
        void SetAttributes();
        List<string> GetCompoent();
    }
}
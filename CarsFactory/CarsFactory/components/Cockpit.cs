using System.Collections.Generic;

namespace VehichleFactory.Components
{
    internal class Cockpit : IComponent
    {
        public string ComponentName { get; set; }

        public List<string> GetCompoent()
        {
            throw new System.NotImplementedException();
        }

        public void SetAttributes()
        {
            throw new System.NotImplementedException();
        }
    }
}
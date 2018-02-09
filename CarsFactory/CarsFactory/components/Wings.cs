using System.Collections.Generic;

namespace VehichleFactory.components
{
    internal class Wings : IComponent
    {
        private string planeType;

        public Wings(string planeType)
        {
            this.planeType = planeType;
            SetAttributes();
            GetCompoent();
        }

        public Wings()
        {
            planeType = "default";
            SetAttributes();
            GetCompoent();
        }

        public string ComponentName { get; set; }

        public void SetAttributes()
        {
            switch (planeType)
            {
                case "default":
                    ComponentName = "wings crafted with lightweight allloy";
                    break;
            }
        }

        public List<string> GetCompoent()
        {
            var attributes = new List<string>();

            attributes.Add(ComponentName);


            return attributes;
        }
    }
}
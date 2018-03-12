using System.Collections.Generic;

namespace VehichleFactory.Components
{
    public class Wheel : IComponent
    {
        private readonly string CarType;

        public string TyreType { get; set; }
        public string RimsType { get; set; }
        public string ComponentName { get; set; }

        public Wheel(string carType)
        {
            CarType = carType;
            SetAttributes();
            GetCompoent();
        }

        public Wheel()
        {
            CarType = "default";
            SetAttributes();
            GetCompoent();
        }

        public void SetAttributes()
        {
            switch (CarType)
            {
                case "default":
                    ComponentName = "standard on-road";
                    ComponentName = ComponentName + " with " + "steel wheel rims";
                    break;

                case "off road":
                    ComponentName = "off road";
                    ComponentName = ComponentName + " with " + "steel wheel rims";
                    break;

                case "sports car":
                    ComponentName = "high traction wheel";
                    ComponentName = ComponentName + " with " + "steel wheel rims";
                    break;
            }
        }

        public List<string> GetCompoent()
        {
            var attributes = new List<string>();

            attributes.Add(ComponentName);
            attributes.Add(TyreType);
            attributes.Add(RimsType);

            return attributes;
        }
    }
}
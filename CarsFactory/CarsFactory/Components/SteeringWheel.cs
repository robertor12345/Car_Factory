using System.Collections.Generic;
using VehichleFactory.components;

namespace VehichleFactory.compnentAssemblies
{
    public class SteeringWheel : IComponent
    {
        private readonly string CarType;

        public string ComponentName { get; set; }

        public SteeringWheel(string carType)
        {
            CarType = carType;
            SetAttributes();
            GetCompoent();
        }

        public SteeringWheel()
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
                    ComponentName = "leather steeringwheel";

                    break;

                case "off road":
                    ComponentName = "classic steel steeringwheel";

                    break;

                case "sports car":
                    ComponentName = "wood steeringwheel";

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
using System.Collections.Generic;

namespace VehichleFactory.Components
{
    public class SteeringWheel : IComponent
    {
        private readonly string carType;

        public string ComponentName { get; set; }

        public SteeringWheel(string carType)
        {
            this.carType = carType;
            SetAttributes();
            GetCompoent();
        }

        public SteeringWheel()
        {
            carType = "default";
            SetAttributes();
            GetCompoent();
        }

        public void SetAttributes()
        {
            switch (carType)
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
using System.Collections.Generic;
using VehichleFactory.components;

namespace VehichleFactory.compnentAssemblies
{
    public class SteeringWheel : IComponent
    {

        private string CarType;
        public SteeringWheel(string carType)
        {
            this.CarType = carType;
            SetAttributes();
            GetCompoent();
        }

        public SteeringWheel()
        {
            this.CarType = "default";
            SetAttributes();
            GetCompoent();
        }

        public string ComponentName { get;set; }

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
using System.Collections.Generic;
using VehichleFactory.Components;

namespace VehichleFactory.CompnentAssemblies
{
    public class ComponentFactory : IComponentAssembly
    {
        public string VehicleType { get; set; }

        public ComponentFactory(string vehicleType)
        {
            VehicleType = vehicleType;
        }

        public ComponentFactory()
        {
            VehicleType = "default";
        }

        public List<IComponent> CreateComponents()
        {
            List<IComponent> vehicleParts = new List<IComponent>();
            switch (VehicleType)
            {
                case "car":
                    vehicleParts.Add(new Wheel());
                    vehicleParts.Add(new SteeringWheel());
                    break;

                case "plane":
                    vehicleParts.Add(new Wings());
                    vehicleParts.Add(new Cockpit());
                    break;

                case "default":
                    vehicleParts.Add(new Wings());
                    vehicleParts.Add(new Cockpit());
                    break;
            }

            return vehicleParts;
        }
    }
}
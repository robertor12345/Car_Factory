using System.Collections.Generic;
using VehichleFactory;
using VehichleFactory.compnentAssemblies;
using VehichleFactory.components;

namespace VehichleFactory.compnentAssemblies
{
    class ComponentFactory : IComponentAssembly
    {
        public string VehicleType { get; set; }

        public ComponentFactory(string vehicleType)
        {
            this.VehicleType = vehicleType;
        }

        public ComponentFactory() { }

        public List<IComponent> CreateComponents()
        {
            List <IComponent> vehicleParts = new List<IComponent>();
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
            }

            return vehicleParts;
        }
    }
}

using System;

namespace Transport
{
    internal class OrderTransport
    {
        private static void Main(string[] args)
        {
            Customer firstCustomer = new Customer(new CarStrategy());

            Console.WriteLine("Time taken by car: "+ firstCustomer.CalculateTime(180));

            firstCustomer.Strategy = new PlaneStrategy();

            Console.WriteLine("Time taken by plane: " + firstCustomer.CalculateTime(180));

            firstCustomer.Strategy = new TrainStrategy();

            Console.WriteLine("Time taken by train: " + firstCustomer.CalculateTime(180));

            Console.ReadLine();
        }
    }
}
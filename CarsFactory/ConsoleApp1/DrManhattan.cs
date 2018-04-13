using System;
using System.Security.Cryptography.X509Certificates;

namespace SuperHeroBuilderProj
{
    class DrManhattan
    {
        static void Main(string[] args)
        {


            SuperHeroBuilder superHeroBuilder = new SuperHeroBuilder();
            ;
            var Batman = superHeroBuilder.CreateSuperHero("Batman")
                                         .WithSecretIdentity("Bruce Wayne")
                                         .WithPowers(new string[]
                                                     {
                                                         "Tactical Genius",
                                                         "Mixed Martial Artist",
                                                         "Peak Human Conditioning"
                                                     })
                                         .Build();
                                         Print(Batman);

            var Superman = superHeroBuilder.CreateSuperHero("Superman")
                                           .WithSecretIdentity("Clark Kent")
                                           .WithPowers(new string[]
                                                       {
                                                           "Flight",
                                                           "X-Ray Vision",
                                                           "Heat-vision",
                                                           "Super-human Strength",
                                                           "Super-human Speed",
                                                           "Healing Factor",
                                                           "Speed-thinker"
                                                       })
                                           .Build();
                                           Print(Superman);

            var Flash = superHeroBuilder.CreateSuperHero("Flash")
                                        .WithSecretIdentity("Barry Allen")
                                        .WithPowers(new string[]
                                                    {
                                                        "Super-human Speed",
                                                        "Healing Factor",
                                                        "Time-travel",
                                                        "Speed-thinker"
                                                    })
                                        .Build();
                                         Print(Flash);

            Console.ReadLine();
        }


        public static void Print(SuperHero superHero)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Superhero Name: " + superHero.Name);
            Console.WriteLine("Secret Identity: " + superHero.SecretIdentity);
            Console.WriteLine("Powers:");

            foreach (string power in superHero.Powers)
            {
                Console.WriteLine(power);
            }
        }
    }
}

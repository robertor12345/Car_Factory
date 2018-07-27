using FluentAssertions;
using NUnit.Framework;
using SuperHeroBuilderProj;

namespace TestingPatterns
{
    [TestFixture]
    public class SuperHeroBuilderShould
    {
        [TestCase("Batman", "Bruce Wayne", new[] {"Tactical Genius", "Mixed Martial Artist", "Peak Human Conditioning"})]
        [TestCase("Superman", "Clark Kent", new[]
                                            {
                                                "Flight",
                                                "X-Ray Vision",
                                                "Heat-vision",
                                                "Super-human Strength",
                                                "Super-human Speed",
                                                "Healing Factor",
                                                "Speed-thinker"
                                            })]
        [TestCase("Flash", "Barry Allen", new[] {"Super-human Speed", "Healing Factor", "Time-travel", "Speed-thinker"})]
        [TestCase("Nightwing", "Richard Grayson",
            new[] {"Unmatched Acrobat", "Tactical Genius", "Mixed Martial Artist", "Peak Human Conditioning"})]
        [TestCase("Green Lantern", "Hal Jordan", new[]
                                                 {
                                                     "Unmatched Will",
                                                     "Green Lantern Ring",
                                                     "Unlimited Constructs",
                                                     "Super-human Speed",
                                                     "Healing Factor",
                                                     "Speed-thinker"
                                                 })]
        public void ReturnCorrectNewCorrectSuperHero_WhenCalledWithAttributes(string name, string secretIdentity, string[] powers)
        {
            var expectedSuperHero = new SuperHero(name, secretIdentity, powers);

            SuperHeroBuilder superHeroBuilder = new SuperHeroBuilder();
            ;
            var resultingSuperHero = superHeroBuilder.CreateSuperHero(name)
                                                     .WithSecretIdentity(secretIdentity)
                                                     .WithPowers(powers)
                                                     .Build();
            resultingSuperHero.ShouldBeEquivalentTo(expectedSuperHero);
        }
    }
}
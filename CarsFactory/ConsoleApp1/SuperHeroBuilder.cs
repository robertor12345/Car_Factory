namespace SuperHeroBuilderProj
{
    public class SuperHeroBuilder
    {
        private string name;
        private string secretIdentity;
        private string[] powers;

        public SuperHeroBuilder CreateSuperHero(string name)
        {
            this.name = name;
            return this;
        }
        public SuperHeroBuilder WithSecretIdentity(string secretIdentity)
        {
            this.secretIdentity = secretIdentity;
            return this;
        }
        public SuperHeroBuilder WithPowers(string[] powers)
        {
            this.powers = powers;
            return this;
        }

        public SuperHero Build()
        {
            return new SuperHero(name, secretIdentity, powers);
        }
    }
}
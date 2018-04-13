namespace SuperHeroBuilderProj
{
    public class SuperHero
    {
        public SuperHero(string name, string secretIdentity, string[] powers)
        {
            Name = name;
            SecretIdentity = secretIdentity;
            Powers = powers;
        }

        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public string[] Powers { get; set; }
    }
}
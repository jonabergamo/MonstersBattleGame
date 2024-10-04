namespace CoreLibrary.Entities
{
    public abstract class Monster
    {

        public required string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }

        public abstract void Atack();

        public abstract void Defend();

        public abstract void UseSpecialAbility();

    }
}

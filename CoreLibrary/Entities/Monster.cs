namespace CoreLibrary.Entities
{
    public abstract class Monster
    {
        private int attack;

        public string Name { get; set; }
        public int AttackDamage { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public bool IsDefending { get; set; }

        protected Monster(string name, int attack, int defense, int health)
        {
            Name = name;
            AttackDamage = attack;
            Defense = defense;
            Health = health;
            IsDefending = false;
        }

        public void Atack(Monster target)
        {
            int damage = this.AttackDamage - target.Defense;
            damage = damage > 0 ? damage : 0;
            target.Health -= damage;
            Console.WriteLine($"{this.Name} atacou {target.Name} e causou {damage} pontos de dano!");
        }

        public void Defend()
        {
            this.IsDefending = true;
        }

        public abstract void UseSpecialAbility();

    }
}

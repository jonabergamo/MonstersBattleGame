namespace CoreLibrary.Entities
{
    public abstract class Monster
    {
        private int attack;

        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public bool IsDefending { get; set; }
        public string AbilityName { get; set; }

        protected Monster(string name, int attack, int defense, int health)
        {
            Name = name;
            AttackPower = attack;
            Defense = defense;
            Health = health;
            IsDefending = false;
        }



        public void Atack(Monster target)
        {
            int damage = this.AttackPower - target.Defense;
            damage = damage > 0 ? damage : 0;
            target.Health -= damage;
            Console.WriteLine($"{this.Name} atacou {target.Name} e causou {damage} pontos de dano!");
        }

        public void Defend()
        {
            this.IsDefending = true;
        }

        public virtual int TakeDamage(int damage)
        {
            int finalDamage = Math.Max(0, damage - Defense);
            Health -= finalDamage;

            return finalDamage;
        }

        public abstract void SpecialAbility();

    }
}

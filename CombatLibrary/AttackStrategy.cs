using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    public class AttackStrategy : IStrategy
    {
        public void Execute(Monster attacker, Monster defender)
        {
            int damage = attacker.AttackDamage - defender.Defense;
            damage = damage > 0 ? damage : 0;
            defender.Health -= damage;

            Console.WriteLine($"{attacker.Name} atacou {defender.Name} e causou {damage} pontos de dano.");
        }
    }
}

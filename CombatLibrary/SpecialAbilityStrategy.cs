using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    public class SpecialAbilityStrategy : IStrategy
    {
        public void Execute(Monster attacker, Monster defender)
        {
            // Habilidade especial de um Dragão que lança fogo e causa dano adicional
            int specialDamage = attacker.Attack + 2; // Dano aumentado como exemplo
            defender.Health -= specialDamage;
            attacker.UseSpecialAbility(Monster defender);

            Console.WriteLine($"{attacker.Name} usa sua habilidade especial e lança fogo, causando {specialDamage} de dano em {defender.Name}!");
        }
    }
}

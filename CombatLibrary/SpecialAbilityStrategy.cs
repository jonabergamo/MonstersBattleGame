using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    public class SpecialAbilityStrategy : IStrategy
    {
        public void Execute(Monster attacker, Monster defender)
        {
            // Habilidade especial de um Dragão que lança fogo e causa dano adicional
            int specialDamage = attacker.AttackPower + 2; // Dano aumentado como exemplo
            defender.Health -= specialDamage;
            attacker.SpecialAbility();
        }
    }
}

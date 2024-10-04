using CoreLibrary.Entities;

namespace CoreLibrary.Interfaces
{
    public interface IStrategy
    {
        void Execute(Monster attacker, Monster defender);
        
        //void AttackStrategy(Monster attackingMonster, Monster defendingMonster);

        //void DefendStrategy(Monster defendingMonster, Monster attackingMonster);

        //void SpecialAbilityStrategy(Monster attackingMonster, Monster defendingMonster);
    }
}

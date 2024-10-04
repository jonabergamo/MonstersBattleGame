using CoreLibrary.Entities;
using CoreLibrary.Interfaces;

namespace CombatLibrary
{
    public class CombatManager 
    {
        private IStrategy strategy;  // A estratégia atual de combate

        // Método para definir qual estratégia será usada (ataque, defesa, habilidade)
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        // Executa a ação de combate com a estratégia definida
        public void ExecuteAction(Monster attacker, Monster defender)
        {
            strategy.Execute(attacker, defender);
        }
    }
}

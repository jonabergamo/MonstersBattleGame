
using CoreLibrary.Entities;

class Program
{
    static void Main(string[] args)
    {
        // Criando dois monstros
        Monster goblin = new Monster("Goblin", 100, 15, 5);
        Monster orc = new Monster("Orc", 150, 20, 10);

        // Criando o gerenciador de combate
        CombatManager combatManager = new CombatManager();

        // Usando a estratégia de ataque
        combatManager.SetStrategy(new AttackStrategy());
        combatManager.ExecuteAction(goblin, orc);  // Goblin ataca o Orc

        // Usando a estratégia de defesa
        combatManager.SetStrategy(new DefenseStrategy());
        combatManager.ExecuteAction(goblin, orc);  // Orc se defende

        // Usando a estratégia de habilidade especial
        combatManager.SetStrategy(new SpecialAbilityStrategy());
        combatManager.ExecuteAction(goblin, orc);  // Goblin usa habilidade especial contra o Orc
    }
}

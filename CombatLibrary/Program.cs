
using CombatLibrary;
using CoreLibrary.Entities;

class Program
{
    static void Main(string[] args)
    {
        // Criando dois monstros
        Monster robot = new Robot("Robo", 40, 25, 200);
        Monster zombie = new Zombie("zombie", 30, 15, 250);

        // Criando o gerenciador de combate
        CombatManager combatManager = new CombatManager();

        // Usando a estratégia de ataque
        combatManager.SetStrategy(new AttackStrategy());
        combatManager.ExecuteAction(robot, zombie);  // Goblin ataca o Orc

        // Usando a estratégia de defesa
        combatManager.SetStrategy(new DefendStrategy());
        combatManager.ExecuteAction(zombie, robot);  // Orc se defende

        // Usando a estratégia de habilidade especial
        combatManager.SetStrategy(new SpecialAbilityStrategy());
        combatManager.ExecuteAction(robot, zombie);  // Goblin usa habilidade especial contra o Orc
    }
}

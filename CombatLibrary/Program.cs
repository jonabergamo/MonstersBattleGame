
using CombatLibrary;
using CoreLibrary.Entities;

// Criando dois monstros
Robot robot = new Robot()
{
    Name = "Cid",
    Health = 200,
    Attack = 25,
    Defense = 15
};
Dragon dragon = new Dragon()
{
    Name = "dragonauta",
    Health = 300,
    Attack = 40,
    Defense = 20
};

// Criando o gerenciador de combate
CombatManager combatManager = new CombatManager();

// Realizando um ataque
combatManager.AttackAction(robot, dragon);  // Cid ataca Dragonauta

// Realizando uma defesa
combatManager.DefendAction(dragon);  // Dragonauta se defende

// Usando uma habilidade especial
combatManager.SpecialAbilityAction(dragon, robot);

//Mostra os pontos de vida atual de cada monstro
combatManager.ShowMonstersHealth(dragon, robot);


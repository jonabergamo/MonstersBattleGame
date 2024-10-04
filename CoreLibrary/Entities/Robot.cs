namespace CoreLibrary.Entities
{
    public class Robot : Monster
    {
        public Robot(string name, int attack, int defense, int health) : base(name, attack, defense, health)
        {
        }


        public override void UseSpecialAbility()
        {
            Console.WriteLine("testando habilidade special do robo");
        }
    }
}

namespace CoreLibrary.Entities
{
    public class Player
    {
        public IList<Monster> monsters { get; set; }
        public int score { get; set; }
        string name { get; set; }

        public Player(string name)
        {
            this.name = name;
            score = 0;
            monsters = new List<Monster>();
        }


        public void TakeTurn()
        {

        }

        public void SelectAction()
        {

        }

        public void AddMonster(Monster monster)
        {
            monsters.Add(monster);
        }

    }
}

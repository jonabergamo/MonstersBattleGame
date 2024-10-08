using CoreLibrary.Entities;

namespace CoreLibrary
{
    public class Game
    {
        // A instância privada e estática da classe
        private static Game? instance;

        // Um objeto para sincronização
        private static readonly object lockObject = new object();

        // Construtor privado para evitar instanciamento externo
        private Game()
        {
            // Inicialização da instância
        }

        // Propriedade pública para obter a instância
        public static Game getInstance
        {
            get
            {
                // Usa bloqueio para garantir que apenas uma instância seja criada em ambientes multithread
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Game();
                    }
                    return instance;
                }
            }
        }

        // Um exemplo de método da classe
        // Método para iniciar o jogo com turnos
        // Método para iniciar o jogo com turnos
        public void StartGame()
        {
            // Criação dos jogadores
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            // Adiciona monstros aos jogadores
            player1.AddMonster(new Robot("Robo", 40, 25, 200));
            player1.AddMonster(new Dragon("Dragão", 50, 35, 180));
            player2.AddMonster(new Zombie("Zumbi", 30, 15, 250));
            player2.AddMonster(new Goblin("Goblin", 25, 20, 220));

            Console.WriteLine("Batalha de Monstros começou!");

            // Jogadores escolhem seus monstros
            Monster player1Monster = player1.SelectMonster();
            Monster player2Monster = player2.SelectMonster();

            Console.WriteLine($"Player 1 escolheu {player1Monster.Name}");
            Console.WriteLine($"Player 2 escolheu {player2Monster.Name}");

            // Gerenciador de turnos
            TurnManager turnManager = new TurnManager();

            bool gameOver = false;
            int round = 1;

            // Loop principal do jogo por turnos
            while (!gameOver)
            {
                Console.WriteLine($"\n--- Turno {round} ---");

                // Turno do jogador 1
                Console.WriteLine("\nPlayer 1:");
                turnManager.StartTurn(player1Monster, player2Monster);

                // Verifica se o jogador 2 foi derrotado
                if (player2Monster.Health <= 0)
                {
                    Console.WriteLine("Player 1 venceu!");
                    gameOver = true;
                    break;
                }

                // Turno do jogador 2
                Console.WriteLine("\nPlayer 2:");
                turnManager.StartTurn(player2Monster, player1Monster);

                // Verifica se o jogador 1 foi derrotado
                if (player1Monster.Health <= 0)
                {
                    Console.WriteLine("Player 2 venceu!");
                    gameOver = true;
                    break;
                }

                round++;
            }
        }

        public void saveGame()
        {
            Console.WriteLine("Hello from Singleton!");
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton!");
        }
    }

}


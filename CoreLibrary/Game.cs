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
        public void startGame()
        {
            Console.WriteLine("Hello from Singleton!");
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


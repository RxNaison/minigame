using System;

namespace minigame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int sizeMap = 30;

            Map map = new Map(sizeMap);
            Player player = new Player(map);
            Scene scene = new Scene(map, player);

            scene.Start();

            while (true)
            {          
                Console.WriteLine("Начать сначала?\ny - да\nn - нет");

                char key = Console.ReadKey().KeyChar;
                if (char.ToLower(key) == 'y')
                {
                    Console.Clear();
                    map = new Map(sizeMap);
                    player = new Player(map);
                    scene = new Scene(map, player);
                    scene.Start();
                }
                else if (char.ToLower(key) == 'n')
                {
                    return;
                }
                else
                {
                    Console.Clear();
                }
            }
        }

    }
}

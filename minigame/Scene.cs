using System;

namespace minigame
{
    internal class Scene
    {
        private Map _map;
        private Player _player;

        public Scene(Map map, Player player)
        {
            _map = map;
            _player = player;
        }

        public void Start()
        {
            _map.ShowMap();
            Console.SetCursorPosition(_player.positionY, _player.positionX);
            Console.Write("@");

            while (true)
            {
                _player.ShowScore();
                _player.Controller();

                if (_player.CheckColision())
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ты проиграл");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if (_player.CheckScore())
                {
                    Console.Clear();
                    Console.WriteLine("Ты выиграл!!!!");
                    break;
                }
            }
            
        }

    }
}

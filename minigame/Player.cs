using System;

namespace minigame
{
    class Player
    {
        public int positionX { get; private set; }
        public int positionY { get; private set; }

        private Map _map;

        private int _score = 0;

        public Player(Map map)
        {
            _map = map;
            positionX = map.Size / 2;
            positionY = map.Size;
        }

        public void Controller()
        {
            char key = Console.ReadKey(true).KeyChar;
            Console.SetCursorPosition(0, 0);

            switch (char.ToUpper(key))
            {
                case 'W':
                    _map.ShiftUp();
                    _map.ShowMap();
                    Console.SetCursorPosition(positionY, positionX);
                    Console.Write("@");
                    break;

                case 'A':
                    _map.ShiftLeft();
                    _map.ShowMap();
                    Console.SetCursorPosition(positionY, positionX);
                    Console.Write("@");
                    break;

                case 'S':
                    _map.ShiftDown();
                    _map.ShowMap();
                    Console.SetCursorPosition(positionY, positionX);
                    Console.Write("@");
                    break;

                case 'D':
                    _map.ShiftRight();
                    _map.ShowMap();
                    Console.SetCursorPosition(positionY, positionX);
                    Console.Write("@");
                    break;

            }

        }

        public void ShowScore()
        {
            Console.SetCursorPosition(_map.Size * 2, 0);
            Console.Write("счет: " + _score);
        }

        public bool CheckScore()
        {
            if (_score >= 50)
            {
                return true;
            }
            return false;
        }

        public bool CheckColision()
        {
            if (_map.GetSumbol(positionY / 2, positionX) == '#')
            {
                return true;
            }
            if (_map.GetSumbol(positionY / 2, positionX) == '0')
            {
                _score++;
                _map.SetSumbol(positionY / 2, positionX, '.');
            }
            return false;
        }

    }
}

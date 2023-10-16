using System;

namespace minigame
{
    class Map
    {
        private char[,] _map;

        public int Size { get; private set; }

        public Map(int size)
        {
            Size = size;
            _map = new char[Size, Size];

            Random random = new Random();
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    int rand = random.Next(10);
                    
                    if (rand < 1)
                    {
                        _map[i, j] = '#';
                    }
                    else if (rand < 2)
                    {
                        _map[i, j] = '0';
                    }
                    else
                    {
                        _map[i, j] = '.';
                    }
                }
            }
        }

        public char GetSumbol(int x, int y)
        {
            return _map[x, y];
        }

        public void SetSumbol(int x, int y, char sumbol)
        {
            _map[x, y] = sumbol;
        }

        public void ShowMap()
        {
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    Console.Write(_map[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ShiftUp()
        {
            char[] temp = new char[_map.GetLength(1)];

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                temp[j] = _map[_map.GetLength(0) - 1, j];
            }

            for (int i = _map.GetLength(0) - 1; i > 0; i--)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    _map[i, j] = _map[i - 1, j];
                }
            }

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                _map[0, j] = temp[j];
            }
        }

        public void ShiftDown()
        {
            char[] temp = new char[_map.GetLength(1)];

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                temp[j] = _map[0, j];
            }

            for (int i = 0; i < _map.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    _map[i, j] = _map[i + 1, j];
                }
            }

            for (int j = 0; j < _map.GetLength(1); j++)
            {
                _map[_map.GetLength(0) - 1, j] = temp[j];
            }
        }

        public void ShiftLeft()
        {
            char[] temp = new char[_map.GetLength(0)];

            for (int i = 0; i < _map.GetLength(0); i++)
            {
                temp[i] = _map[i, _map.GetLength(1) - 1];

            }

            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = _map.GetLength(1) - 1; j > 0; j--)
                {
                    _map[i, j] = _map[i, j - 1];
                }
            }

            for (int i = 0; i < _map.GetLength(0); i++)
            {
                _map[i, 0] = temp[i];
            }
        }

        public void ShiftRight()
        {
            char[] temp = new char[_map.GetLength(0)];

            for (int i = 0; i < _map.GetLength(0); i++)
            {
                temp[i] = _map[i, 0];
            }

            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1) - 1; j++)
                {
                    _map[i, j] = _map[i, j + 1];
                }
            }

            for (int i = 0; i < _map.GetLength(1); i++)
            {
                _map[i, _map.GetLength(1) - 1] = temp[i];
            }
        }
    }
}



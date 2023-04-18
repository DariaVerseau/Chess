using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Chess
    {
        // проверка хода для Короля
        public bool King(int x1, int y1, int x2, int y2)
        {
            if (x1 > 0 && x1 < 9 && x2 > 0 && x2 < 9 && y1 > 0 && y1 < 9 && y2 > 0 && y2 < 9)
            {
                if (x1 == x2 && (y1 == y2 + 1 || y1 == y2 - 1))
                {
                    return true;
                }
                else if (x1 == x2 + 1 && (y1 == y2 + 1 || y1 == y2 - 1 || y1 == y2))
                {
                    return true;
                }
                else if (x1 == x2 - 1 && (y1 == y2 + 1 || y1 == y2 - 1 || y1 == y2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // проверка хода для Королевы
        public bool Queen(int x1, int y1, int x2, int y2)
        {
            if (x1 > 0 && x1 < 9 && x2 > 0 && x2 < 9 && y1 > 0 && y1 < 9 && y2 > 0 && y2 < 9)
            {
                if (x1 == x2 && y1 == y2)
                {
                    return false;
                }
                else if ((x1 - x2 == y1 - y2) || (x2 - x1 == y2 - y1) || (x2 - x1 == y1 - y1) || (x1 - x2 == y2 - y1))
                {
                    return true;
                }
                else if ((x1 == x2 && y1 > y2) || (x1 == x2 && y1 < y2))
                {
                    return true;
                }
                else if ((y1 == y2 && x1 > x2) || (y1 == y2 && x1 < x2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        // проверка хода для Ладьи
        public bool Rook(int x1, int y1, int x2, int y2)
        {
            if (x1 > 0 && x1 < 9 && x2 > 0 && x2 < 9 && y1 > 0 && y1 < 9 && y2 > 0 && y2 < 9)
            {
                if ((x1 == x2 && y1 > y2) || (x1 == x2 && y1 < y2))
                {
                    return true;
                }
                else if ((y1 == y2 && x1 > x2) || (y1 == y2 && x1 < x2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // проверка хода для Слона
        public bool Bishop(int x1, int y1, int x2, int y2)
        {
            if (x1 > 0 && x1 < 9 && x2 > 0 && x2 < 9 && y1 > 0 && y1 < 9 && y2 > 0 && y2 < 9)
            {
                if (x1 == x2 && y1 == y2)
                {
                    return false;
                }
                else if ((x1 - x2 == y1 - y2) || (x2 - x1 == y2 - y1) || (x2 - x1 == y1 - y1) || (x1 - x2 == y2 - y1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // проверка хода для Коня
        public bool Knight(int x1, int y1, int x2, int y2)
        {
            if (x1 > 0 && x1 < 9 && x2 > 0 && x2 < 9 && y1 > 0 && y1 < 9 && y2 > 0 && y2 < 9)
            {
                if ((x1 == x2 - 1 || x1 == x2 + 1) && (y1 == y2 - 2 || y1 == y2 + 2))
                {
                    return true;
                }
                else if ((y1 == y2 - 1 || y1 == y2 + 1) && (x1 == x2 - 2 || x1 == x2 + 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // проверка хода для Пешки
        public bool Pawn(int x1, int y1, int x2, int y2)
        {
            if (x1 > 0 && x1 < 9 && x2 > 0 && x2 < 9 && y1 > 0 && y1 < 9 && y2 > 0 && y2 < 9)
            {
                if (x1 == x2 && y1 == y2 - 1)
                {
                    return true;
                }
                else if (y1 == 2 && y1 == y2 - 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Проверка на доступность хода для шахматных фигур" + "\n");
            Console.WriteLine("Вводите только те значения, которые могут охватить координаты, пример: 0<x1<9" + "\n");
            Console.WriteLine("Какую шахматную фигуру вы бы хотели проверить на доступность хода? Введите цифру, соответствующую фигуре:" + "\n");
            Console.WriteLine("Король - 1, Королева - 2, Ладья - 3, Слон - 4, Конь - 5, Пешка - 6" + "\n");
            int pieceNumber;
            while (!(int.TryParse(Console.ReadLine(), out pieceNumber) && pieceNumber > 0 && pieceNumber < 7))
            {
                Console.WriteLine("\n" + "Напишите номер, соответствующий фигуре:" + "\n");
            }
            while (true)
            {
                switch (pieceNumber)
                {
                    case 1:
                        King();
                        return true;
                    case 2:
                        Queen();
                        return true;
                    case 3:
                        Rook();
                        return true;
                    case 4:
                        Bishop();
                        return true;
                    case 5:
                        Knight();
                        return true;
                    case 6:
                        Pawn();
                        return true;
                }
            }
        }

        static void Return()
        {
            Console.WriteLine("\n" + "Нажмите enter, чтобы вернуться к выбору" + "\n");
            Console.ReadLine();
        }

        static void King()
        {
            Chess chess = new Chess();
            Console.WriteLine("\n" + "Проверка хода для Короля:" + "\n");
            int x1;
            while (!(int.TryParse(Console.ReadLine(), out x1) && x1 > 0 && x1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y1;
            while (!(int.TryParse(Console.ReadLine(), out y1) && y1 > 0 && y1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int x2;
            while (!(int.TryParse(Console.ReadLine(), out x2) && x2 > 0 && x2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y2;
            while (!(int.TryParse(Console.ReadLine(), out y2) && y2 > 0 && y2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            Console.WriteLine(chess.King(x1, y1, x2, y2));
            Return();
        }

        static void Queen()
        {
            Chess chess = new Chess();
            Console.WriteLine("\n" + "Проверка хода для Королевы:" + "\n");
            int x1;
            while (!(int.TryParse(Console.ReadLine(), out x1) && x1 > 0 && x1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y1;
            while (!(int.TryParse(Console.ReadLine(), out y1) && y1 > 0 && y1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int x2;
            while (!(int.TryParse(Console.ReadLine(), out x2) && x2 > 0 && x2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y2;
            while (!(int.TryParse(Console.ReadLine(), out y2) && y2 > 0 && y2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            Console.WriteLine(chess.Queen(x1, y1, x2, y2));
            Return();
        }

        static void Rook()
        {
            Chess chess = new Chess();
            Console.WriteLine("\n" + "Проверка хода для Ладьи:" + "\n");
            int x1;
            while (!(int.TryParse(Console.ReadLine(), out x1) && x1 > 0 && x1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y1;
            while (!(int.TryParse(Console.ReadLine(), out y1) && y1 > 0 && y1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int x2;
            while (!(int.TryParse(Console.ReadLine(), out x2) && x2 > 0 && x2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y2;
            while (!(int.TryParse(Console.ReadLine(), out y2) && y2 > 0 && y2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            Console.WriteLine(chess.Rook(x1, y1, x2, y2));
            Return();
        }

        static void Bishop()
        {
            Chess chess = new Chess();
            Console.WriteLine("\n" + "Проверка хода для Слона:" + "\n");
            int x1;
            while (!(int.TryParse(Console.ReadLine(), out x1) && x1 > 0 && x1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y1;
            while (!(int.TryParse(Console.ReadLine(), out y1) && y1 > 0 && y1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int x2;
            while (!(int.TryParse(Console.ReadLine(), out x2) && x2 > 0 && x2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y2;
            while (!(int.TryParse(Console.ReadLine(), out y2) && y2 > 0 && y2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            Console.WriteLine(chess.Bishop(x1, y1, x2, y2));
            Return();
        }

        static void Knight()
        {
            Chess chess = new Chess();
            Console.WriteLine("\n" + "Проверка хода для Коня:" + "\n");
            int x1;
            while (!(int.TryParse(Console.ReadLine(), out x1) && x1 > 0 && x1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y1;
            while (!(int.TryParse(Console.ReadLine(), out y1) && y1 > 0 && y1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int x2;
            while (!(int.TryParse(Console.ReadLine(), out x2) && x2 > 0 && x2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y2;
            while (!(int.TryParse(Console.ReadLine(), out y2) && y2 > 0 && y2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            Console.WriteLine(chess.Knight(x1, y1, x2, y2));
            Return();
        }

        static void Pawn()
        {
            Chess chess = new Chess();
            Console.WriteLine("\n" + "Проверка хода для Пешки:" + "\n");
            int x1;
            while (!(int.TryParse(Console.ReadLine(), out x1) && x1 > 0 && x1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y1;
            while (!(int.TryParse(Console.ReadLine(), out y1) && y1 > 0 && y1 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int x2;
            while (!(int.TryParse(Console.ReadLine(), out x2) && x2 > 0 && x2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            int y2;
            while (!(int.TryParse(Console.ReadLine(), out y2) && y2 > 0 && y2 < 9))
            {
                Console.WriteLine("\n" + "Вы ввели некорректные данные, повторите ввод:" + "\n");
            }
            Console.WriteLine(chess.Pawn(x1, y1, x2, y2));
            Return();
        }
    }
}








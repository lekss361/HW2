using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp1,tmp2;
            int _taskSelection;
            int _userInput1, _userInput2, _userInput3, _userInput4;
            double _result1, _result2;

            string[] _numbers = new string[10] { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

            Console.WriteLine("1. Пользователь вводит 2 числа(A и B).Если A > B, подсчитать A+B, если A = B, подсчитать A* B, если A < B, подсчитать A-B." +
                "\n2. Пользователь вводит 2 числа(X и Y).Определить какой четверти принадлежит точка с координатами(X, Y)." +
                "\n3. Пользователь вводит 3 числа(A, B и С).Выведите их в консоль в порядке возрастания." +
                "\n4. Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2 + BX + C = 0." +
                "\n5. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.Например при вводе “25” в консоль будет выведено “двадцать пять”. " +
                "\n Введите номер задачи:");

            _taskSelection = Convert.ToInt32(Console.ReadLine());

            switch (_taskSelection)
            {
                case (1):
                    Console.Write("Введите число А\nА=");
                    _userInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите B\nB=");
                    _userInput2 = Convert.ToInt32(Console.ReadLine());
                    if (_userInput1>_userInput2)
                    {
                        _result1 = _userInput1 + _userInput2;
                    }
                    else if(_userInput1==_userInput2)      
                    {
                        _result1 = _userInput1 * _userInput2;
                    }
                    else
                    {
                        _result1 = _userInput1 - _userInput2;
                    }
                    Console.WriteLine($"Ответ : {_result1}");
                    break;
                case (2):
                    Console.Write("Введите число координату X\nХ=");
                    _userInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите координату Y\nY=");
                    _userInput2 = Convert.ToInt32(Console.ReadLine());
                    if (_userInput1 > 0 && _userInput2 > 0)
                    {
                        Console.WriteLine("Точка находиться в 1 четверти");
                    }
                    else if(_userInput1 > 0 && _userInput2 < 0)
                    {
                        Console.WriteLine("Точка находиться в 2 четверти");
                    }
                    else if(_userInput1 < 0 && _userInput2 < 0)
                    {
                        Console.WriteLine("Точка находиться в 3 четверти");
                    }
                    else
                    {
                        Console.WriteLine("Точка находиться в 4 четверти");
                    }
                    break;
                case (3):
                    Console.Write("Введите число A\nA=");
                    _userInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите B\nB=");
                    _userInput2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите C\nC=");
                    _userInput3 = Convert.ToInt32(Console.ReadLine());

                    while (_userInput1 > _userInput2|| _userInput2 > _userInput3|| _userInput3 > _userInput1)
                    {
                        if (_userInput1 > _userInput2)
                        {
                            tmp1 = _userInput1;
                            _userInput1 = _userInput2;
                            _userInput2 = tmp1;
                        }
                        else if (_userInput2 > _userInput3)
                        {
                            tmp1 = _userInput2;
                            _userInput2 = _userInput3;
                            _userInput3 = tmp1;
                        }
                        else if (_userInput3 > _userInput1)
                        {
                            tmp1 = _userInput3;
                            _userInput3 = _userInput1;
                            _userInput3 = tmp1;
                        }
                    }
                    break;
                case (4):
                    Console.Write("Введите число A\nA=");
                    _userInput1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите B\nB=");
                    _userInput2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите C\nC=");
                    _userInput3 = Convert.ToInt32(Console.ReadLine());

                    tmp1 = _userInput2 * _userInput2 - 4 * _userInput1 * _userInput3;
                    _result1 = (-_userInput2 + MathF.Sqrt(tmp1)) / 2 * _userInput1;
                    _result1 = (-_userInput2 - MathF.Sqrt(tmp1)) / 2 * _userInput1;
                    break;
                case (5):
                    Console.Write("Введите двухзначное число :");
                    _userInput1 = Convert.ToInt32(Console.ReadLine());
                    tmp1 = _userInput1 % 10;
                    tmp2 = _userInput1 / 10;
                    if (tmp2==0&&tmp1==0)
                    {
                        Console.WriteLine($"{_numbers[tmp2]} десятков {_numbers[tmp1]} единиц ");
                    }
                    else if (tmp2==0&&tmp1!=0)
                    {
                        Console.WriteLine($"{_numbers[tmp2]} десятков {tmp1} единицы ");
                    }
                    else if (tmp2!=0&&tmp1==0)
                    {
                        Console.WriteLine($"{_numbers[tmp2]} десятка {_numbers[tmp1]} единиц ");
                    }
                    else
                    {
                        Console.WriteLine($"{_numbers[tmp2]} десятка {_numbers[tmp1]} единицы ");
                    }
                    break;
                default:
                    break;
            }


        }
    }
}

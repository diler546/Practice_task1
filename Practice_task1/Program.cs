using System;
using System.Text.RegularExpressions;

namespace Cheesboard
{
    class Program
    {
        static string input = "";
        static string rookCoordinates = "";
        static string figureCoordinates = "";

        static bool IsValidChessCoordinateFormat()
        {
            string patter = @"^[a-h]+[1-8]\s[a-h]+[1-8]$";
            return Regex.IsMatch(input, patter);
        }

        static void EnteringString()
        {
            Console.WriteLine("Введите координаты ладьи x1y1 и координаты фигуры x2y2(Пример:a1 a2): ");
            input = Console.ReadLine().ToLower();
        }

        static void SplittingAString()
        {
            string[] parts = input.Split(' ');
            rookCoordinates = parts[0];
            figureCoordinates = parts[1];
        }

        static void CanRookAttack()
        {
            if (rookCoordinates[0] == figureCoordinates[0] || rookCoordinates[1] == figureCoordinates[1])
            {
                Console.WriteLine("Ладья сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Ладья не сможет побить фигуру");
            }
        }

        static bool CheckRookMoveValidity()
        {
            if (!(IsValidChessCoordinateFormat()))
            {
                Console.WriteLine("Вы вели строку неправильного формата \n" +
                                  "Формат:a1 a2");
                return true;
            }
            else if (input[0] == input[3] && input[1] == input[4])
            {
                Console.WriteLine("Вы вели одинаковые позиции фигур \n" +
                                  "Введите разные позиции фигур");
                return true;
            }
            return false;
        }

        static void Main()
        {
            do
            {
                EnteringString();

            } while (CheckRookMoveValidity());

            SplittingAString();

            CanRookAttack();

        }
    }
}
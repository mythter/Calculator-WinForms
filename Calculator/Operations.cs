/*
Файл: Operations.cs
Лабораторная робота № 1
Автор: Положий А. С.
Тема: Розробка та дослідження лінійних програм
Дата створення: 09.02.2023
*/

using System;
using System.Globalization;

namespace Calculator
{
    public class Operations
    {
        public static string Add(string a, string b)
        {
            double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture);
            double.Parse(b, NumberStyles.Any, CultureInfo.InvariantCulture);
            return ((
                Math.Round(
                    double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture) +
                    double.Parse(b, NumberStyles.Any, CultureInfo.InvariantCulture), 3))
                .ToString()
                .Replace(",", "."));
        }

        public static string Sub(string a, string b)
        {
            return ((
                Math.Round(
                    double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture) -
                    double.Parse(b, NumberStyles.Any, CultureInfo.InvariantCulture), 3))
                .ToString()
                .Replace(",", "."));
        }

        public static string Mul(string a, string b)
        {
            return ((
                Math.Round(
                    double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture) *
                    double.Parse(b, NumberStyles.Any, CultureInfo.InvariantCulture), 3))
                .ToString()
                .Replace(",", "."));
        }

        public static string Div(string a, string b)
        {
            if (b == "0")
                return "Err";

            else
                return ((
                    Math.Round(
                        double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture) /
                        double.Parse(b, NumberStyles.Any, CultureInfo.InvariantCulture), 3))
                    .ToString()
                    .Replace(",", "."));
        }

        public static string Sin(string a)
        {
            return Math.Round(Math.Sin(double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture)), 3).ToString().Replace(",", ".");
        }

        public static string Cos(string a)
        {
            return Math.Round(Math.Cos(double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture)), 3).ToString().Replace(",", ".");
        }

        public static string Sqrt(string a)
        {
            if (double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture) < 0)
                return "Err";
            else
                return Math.Round(Math.Sqrt(double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture)), 3).ToString().Replace(",", ".");
        }

        public static string CubeRoot(string a)
        {
            double num = double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture);
            if (num < 0)
                return Math.Round(Math.Pow(num * -1, 1 / 3f) * -1, 3).ToString().Replace(",", ".");
            else
                return Math.Round(Math.Pow(num, 1 / 3f), 3).ToString().Replace(",", ".");
        }

        public static string Square(string a)
        {
            return Math.Round(Math.Pow(double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture), 2), 3).ToString().Replace(",", ".");
        }

        public static string Cube(string a)
        {
            return Math.Round(Math.Pow(double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture), 3), 3).ToString().Replace(",", ".");
        }

        public static string Fraction(string a)
        {
            if (a == "0")
                return "Err";
            else
                return Math.Round(1.0 / double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture), 3).ToString().Replace(",", ".");
        }

        public static string Log10(string a)
        {
            if (a == "0" || double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture) < 0)
                return "Err";
            else
                return Math.Round(Math.Log10(double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture)), 3).ToString().Replace(",", ".");
        }

        public static string Inverse(string a)
        {
            return (-1.0 * double.Parse(a, NumberStyles.Any, CultureInfo.InvariantCulture)).ToString().Replace(",", ".");
        }
    }
}

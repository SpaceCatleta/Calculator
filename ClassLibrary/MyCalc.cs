using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class MyCalc
    {
        public static readonly char[] supportedOperators = "*/+-".ToCharArray();
        public static readonly char[] allDigits = "0123456789".ToCharArray();
        public static readonly int[] priorities = new[] { 0, 0, 1, 1 };

        public double? ParseExpression(string expString)
        {
            expString = expString.Replace(" ", ""); //убираем пробелы 
            List<char> ops = expString.Split(allDigits, StringSplitOptions.RemoveEmptyEntries).Select(s => s[0]).ToList(); //создаем лист с операциями
            List<double> numbers = expString.Split(supportedOperators, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToList(); //лист с числами
            if (ops.Count + 1 != numbers.Count)
            {
                return null;
            }
            foreach (int priority in priorities.Distinct())
            {
                List<char> operators = new List<char>();
                for (int i = 0; i < priorities.Length; i++)
                {
                    if (priorities[i] == priority)
                        operators.Add(supportedOperators[i]);
                }
                for (int i = 0; i < ops.Count; i++)
                {
                    if (operators.Contains(ops[i]))
                    {
                        numbers[i] = Calculate(numbers[i], numbers[i + 1], ops[i]);
                        numbers.RemoveAt(i + 1);
                        ops.RemoveAt(i);
                        i--;
                    }
                }

            }
            return numbers[0];
        }

        public static double Calculate(double left, double right, char op) => op switch
        {
            '*' => left * right,
            '/' => left / right,
            '+' => left + right,
            '-' => left - right,
            _ => throw new NotSupportedException("Неподдерживаемый оператор")
        };
    }
}
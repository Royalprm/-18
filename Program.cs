using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_18
{
    internal class Program
    {
        /* Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. 
         * Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, 
         * а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо; 
         * для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка 
         * в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); 
         * в конце прохода стек должен быть пуст.
         */
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите последовательность символов");
            string s = Console.ReadLine();

            
            Dictionary<char, char> bracket = new Dictionary<char, char>();
            bracket.Add('[', ']');
            bracket.Add('(', ')');
            bracket.Add('{', '}');

            Stack<char> stack = new Stack<char>(); 
            char[] sChars = s.ToCharArray(); 
            foreach (char c in sChars)
            {
                if (bracket.ContainsKey(c)) 
                {
                    stack.Push(bracket[c]);
                }
                else if (stack.Count() == 0) 
                {
                    Console.WriteLine("Скобки поставлены некорректно");
                    Console.WriteLine("\nНажмите любую кнопку");
                    Console.ReadKey();
                    return;
                }
                else if (stack.Peek() == c) 
                {
                    stack.Pop();
                }
            }
            if (stack.Count() != 0) 
            {
                Console.WriteLine("Скобки поставлены некорректно");
            }
            else
            {
                Console.WriteLine("Скобки поставлены корректно");
            }

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();
        }
    }
}

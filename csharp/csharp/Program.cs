using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World.");
            pokemon pokemon1 = new pokemon(); //新增一隻寶可夢
            pokemon1.Height = 2.0f; //f=float
            pokemon1.Weight = 12.7f;
            pokemon1.Category = "Lizard";
            pokemon1.Abilities = "Blaze";
            pokemon1.Gender = "M";
            Console.WriteLine("身高:{0},體重{1}", pokemon1.Height, pokemon1.Weight);
        }
    }
}
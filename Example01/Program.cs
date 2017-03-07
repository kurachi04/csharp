using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入使用者名稱:");
            string name = Console.ReadLine(); //把讀到的設定給name
            /*輸入的內容只能存成文字
             若輸入內容為數字，則需將文字轉成數字*/
            Console.Write("請輸入密碼:");
            string password = Console.ReadLine();

            Console.WriteLine("嗨，{0}，歡迎回來!", name);
        }
    }
}
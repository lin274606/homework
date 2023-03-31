using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請問以下哪些話符合今天中秋節?");
            Console.WriteLine("A.應該要划龍舟 B.要穿紅通通小心年獸 C.去找聖誕老公公堆雪人 D.鐵人賽還是要發文QQ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "A"://讀進來的A是字串型態喔
                case "B":
                case "C":
                    Console.WriteLine("給你十秒google一下什麼是中秋節");
                    break;
                case "D":
                    Console.WriteLine("沒錯這就是2019的中秋節QQ");
                    break;

                default:
                    Console.WriteLine("欸認真回答啦");
                    break;

            }

            Console.ReadKey();
        }
    }
}

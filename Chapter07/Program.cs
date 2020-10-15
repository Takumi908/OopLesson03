using Section01;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07 {
    class Program {
        static void Main(string[] args) {
            var dict = new Dictionary<string, List<string>>() { };

            Console.WriteLine("**********************");
            Console.WriteLine("* 辞書登録プログラム *");
            Console.WriteLine("**********************");
           
         
            while (true) {
                Console.WriteLine("1.登録 2.内容を表示 3.終了 ");
                int x = int.Parse(Console.ReadLine());
                if (x == 1) {
                    // ディクショナリに追加
                    Console.Write("KEYを入力:");
                    var key = Console.ReadLine();
                    Console.Write("VALUEを入力:");
                    var value = Console.ReadLine();

                    if (dict.ContainsKey(key)) {
                        dict[key].Add(value);
                    } else {
                        dict[key] = new List<string> { value };
                    }
                    Console.WriteLine("登録しました!");
                } else if (x == 2) {
                    foreach (var item in dict) {
                        foreach (var term in item.Value) {
                            Console.WriteLine("{0} : {1}", item.Key, term);
                        }
                    }
                } else if (x == 3) {
                    break;
                }
            }
        }
    }
}
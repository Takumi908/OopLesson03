using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Chapter06 {
    class Program {
        static void Main(string[] args) {
            //整数の例
            var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };

             //重複排除
            var strings = numbers.Distinct().ToArray();
            foreach (var str in strings) {
                Console.WriteLine(str + " ");
            }
             

            numbers.Select(n => n.ToString("0000")).ToList().ForEach(s => Console.WriteLine(s + " "));

            //並べ替え
            Console.WriteLine();   //改行
            var sortedNumbers = numbers.OrderBy(n => n);
            foreach (var item in sortedNumbers) {
                Console.Write(item+ " ");
            }

            //文字列の例
            Console.WriteLine("\n\n---------");
            var words = new List<string> {
             "Microsoft","Apple","Google","Oracle","Facebook",};

            //ToArray()を付けることで即時実行
            //ないと遅延実行(処理をする時に初めて実行される）
            var lower = words.Select(name => name.ToLower()).ToArray();

            //オブジェクトの例
            var books = Books.GetBooks();
            //タイトルリスト
            var titles = books.Select(name => name.Title); 
            foreach (var title in titles) {
                Console.WriteLine(title + " ");
            }

            //ページ数の多い順に並べ替え(または金額の多い順)
            var sortpage = books.OrderByDescending(n=> n.Pages).Take(3);
            foreach (var item in sortpage) {
                Console.WriteLine(item);
            } 
        }
    }
}

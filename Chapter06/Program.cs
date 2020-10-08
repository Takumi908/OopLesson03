using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, -1, 6, 4 };
            Console.WriteLine($"平均:{numbers.Average()}");
            Console.WriteLine($"合計値:{numbers.Sum()}");
            Console.WriteLine($"最小値:{numbers.Where(a => a > 0).Min()}");
            Console.WriteLine($"最大値:{numbers.Max()}");

            bool exists = numbers.Any(n => n % 7 == 0);

            var results = numbers.Where(n => n > 0).Take(5);
            foreach (var result in results) {
                Console.WriteLine(result + " ");
            }


            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格:{books.Average(a => a.Price)}");
            Console.WriteLine($"本の合計価格:{books.Sum(a => a.Price)}");
            Console.WriteLine($"本のページが最大:{books.Max(a => a.Pages)}");
            Console.WriteLine($"高価な本:{books.Max(a => a.Price)}");
            Console.WriteLine($"タイトルに[物語]がある冊数:{books.Count(a => a.Title.Contains("物語"))}");

            //600ページを超える書籍があるかないか

            bool boks = books.Any(n => n.Pages > 600);
            if (boks == true) {
                Console.WriteLine("600ページを超える書籍があります");
            } else {
                Console.WriteLine("ないです");
            }

            //すべてが200ページ以上の書籍か？(ALLメソッド)
            bool bok = books.All(n => n.Pages > 200);
            if (bok == true) {
                Console.WriteLine("200ページ以上の書籍のみです");
            } else {
                Console.WriteLine("違います");
            }
            /*
            //400ページを超える本は何冊目か
            var forbook = books.FirstOrDefault(n => n.Pages > 400);
            int count;
            int i;
                for (count = 0;i < books.Count; i++) {
                if (books[count].Title.Contains(forbook.Title)) {
                    break;
                }
            }
            */
            var forbook = books.FindIndex(x => x.Pages > 1000);
            Console.WriteLine($"400ページを超える本は{forbook + 1}冊目です");

            //本の値段が400円以上のものを三冊表示
            var surrbook = books.Where(x => x.Pages >= 400).Take(3);
            foreach (var item in surrbook) {
                Console.WriteLine(item.Title + " ");
            }
        }
    }
}

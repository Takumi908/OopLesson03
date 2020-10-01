using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(GetProduct());

        }
        private static string GetProduct() {
            Sale sale = new Sale {
                ShopName = "pet store",
                Product = "food"
            };
            sale = null;
            return sale?.Product;  //nullでないならProduct呼び出す
        }
    }

    class Sale {
       //店舗名
       public string ShopName { get; set; }
        //売上高
        public int Amount { get; set; } = 100000;
        public string Product { get => product; set => product = value; }

        private string product;
    }
}

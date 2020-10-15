using Section01;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07 {
    class Program {
        static void Main(string[] args) {

            // ディクショナリの初期化
            var dict = new Dictionary<string, List<string>>() {
               { "PC", new List<string> { "パーソナル コンピュータ", "プログラム カウンタ", } },
               { "CD", new List<string> { "コンパクト ディスク", "キャッシュ ディスペンサー", } },
            };

            // ディクショナリに追加
            var key = "EC";
            var value = "電子商取引";
            if (dict.ContainsKey(key)) {
                dict[key].Add(value);
            } else {
                dict[key] = new List<string> { value };
            }

            // ディクショナリの内容を列挙
            foreach (var item in dict) {
                foreach (var term in item.Value) {
                    Console.WriteLine("{0} : {1}", item.Key, term);
                }
            }
        }



        /*
       var lines = File.ReadAllLines("sample.txt");
       var we = new WordsExtractor(lines);
       foreach (var word in we.Extract()) {
           Console.WriteLine(word);
       }

       var employeeDict = new Dictionary<int, Employee> {
           {100,new Employee(100,"清水遼久") },
           {112,new Employee(112,"芹沢洋和") },
           {125,new Employee(125,"岩瀬奈央子") },

       };

       foreach (KeyValuePair<int,Employee>item in employeeDict) {
           Console.WriteLine($"{item.Value.Id} = {item.Value.Name}");
       }
       var total = employeeDict.Where(x => x.Value.Id %2 == 0);
       foreach (var item in total) {
           Console.WriteLine($"{item.Value.Name}");
       }


       var employee = new List<Employee>() {
           new Employee(100,"清水遼久"), 
           new Employee(112,"芹沢洋和"), 
           new Employee(125,"岩瀬奈央子"),
           new Employee(143,"山田太郎"),
           new Employee(148,"池内次郎"),
           new Employee(152,"長瀬三郎"),
           new Employee(155,"山口達也"),
           new Employee(161,"大口智也"),
       };

       var employeeDict = employee.Where(emp => emp.Id %2 == 0).ToDictionary(emp=> emp.Id);

       foreach (KeyValuePair<int,Employee> item in employeeDict) {
           Console.WriteLine($"{item.Value.Id}{item.Value.Name}");
       }
       */

    }
}

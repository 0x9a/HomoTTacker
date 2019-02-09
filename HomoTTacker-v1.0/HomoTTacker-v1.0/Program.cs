using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace HomoTTacker
{
    class Program
    {
        static void Main(string[] args)
        {

            string Homo;
            //Get my directory
            string pathDic = Directory.GetCurrentDirectory();
            Console.Write("Enter Your String:[Example:google]:");
            Homo = Console.ReadLine();
            var comp = new Dictionary<char, char>
            {
                {'a','а'},
                {'b','Ь'},
                {'c','с'},
                {'d','ԁ'},
                {'e','е'},
                {'h','һ'},
                {'i','і'},
                {'k','ҟ'},
                {'l','ӏ'},
                {'m','м'},
                {'n','п'},
                {'o','о'},
                {'p','р'},
                {'q','ԛ'},
                {'r','г'},
                {'s','ѕ'},
                {'u','џ'},
                {'w','ԝ'},
                {'x','х'},
                {'y','у'},
            };

            var Org = Homo;
            var trnsfor = string.Concat(Org.Select(c => (comp.ContainsKey(c)) ? comp[c] : c));
            // create .txt file
            File.WriteAllText(pathDic + "\\hom.txt", trnsfor+".com");
            
            Console.ReadLine();

            //HomoTTacker V1.0 Coded By Unkn0wn [ 0x9a@protonmail.com ]
            //Iran Cyber Security Group #ICSG (iran-cyber.net]
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace HomoTTacker_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("                                                       \n");
            Console.Write("|                   --.----.--          |              \n");
            Console.Write("|---.,---.,-.-.,---.  |    |  ,---.,---.|__/ ,---.,---.\n");
            Console.Write("|   ||   || | ||   |  |    |  ,---||    |  \\ |---'|    \n");
            Console.Write("`   '`---'` ' '`---'  `    `  `---^`---'`   ``---'`    \n");
            Console.Write("                                                       \n");
            Console.Write("-------------------------------------------------------\n");
            Console.Write("homoTTacker v2.0 Coded By Unkn0wn [0x9a@tuta.io]\n");
            Console.Write("https://github.com/0x9a\n\n");
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
            //jabejaei charecter's
            var Org = Homo;
            var trnsfor = string.Concat(Org.Select(c => (comp.ContainsKey(c)) ? comp[c] : c));
            // create .txt file
            File.WriteAllText(pathDic + "\\hom.txt", trnsfor + ".com");
            Console.Write("Created to your directory:\n"+pathDic+"\\hom.txt\n\n");
            //HomoTTacker V1.0 Coded By Unkn0wn [ 0x9a@tuta.io ]
            
            //https://github.com/0x9a
            //use whoise.cs class
            Whois objUrl = new Whois();
            objUrl.WhoisDomain(objUrl.urlTxt = trnsfor);
            
            Console.ReadLine();


            
        }
    }
}

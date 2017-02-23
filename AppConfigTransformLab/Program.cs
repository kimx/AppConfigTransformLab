using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigTransformLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start:" + DateTime.Now);
            Console.WriteLine(ConfigurationManager.AppSettings["Stage"]);
            Console.WriteLine(ConfigurationManager.ConnectionStrings["Name"].ConnectionString);
            Console.WriteLine("End:" + DateTime.Now);

            Console.Read();
        }
    }
}

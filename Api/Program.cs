using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Core.Domain;

namespace Api
{
    public class Program    
    {
        public static void Main(string[] args)
        {
            Event ev = new Event();
            ev.StartdAt = DateTime.UtcNow;
            Console.WriteLine(ev.StartdAt.ToString());
            Console.ReadKey();
            //yyyyMMddHHmm
            Event eve = new Event("sdvsdv", "sdvsdvdsv", "sdvsdvdsvsd", new  DateTime(2000, 06, 18,06,15,55), new DateTime(2000,06,20));
            Console.WriteLine(eve.StartdAt.ToString());
            Console.ReadKey();


            //{
            //    var host = new WebHostBuilder()
            //        .UseKestrel()
            //        .UseContentRoot(Directory.GetCurrentDirectory())
            //        .UseIISIntegration()
            //        .UseStartup<Startup>()
            //        .UseApplicationInsights()
            //        .Build();

            //    host.Run();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQL;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using dngit.Core.Models;

namespace dngit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();

            var schema = Schema.For(@"
                type Query {
                    hello: String
                }
            ");

            var json = schema.Execute((x) =>
            {
                x.Query = "{ hello }";
                x.Root = new { Hello = "Hello World!" };
            });

            Console.WriteLine(json);

        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}

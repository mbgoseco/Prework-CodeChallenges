using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Program.cs
{
    public class Program
    {
        public int MaxResult(int e)
        {

        }

        public string IsLeapYear(int year)
        {

        }

        public string IsPerfectSequence(int[] arr)
        {

        }

        public int[] SumOfRows(int[,] matrix)
        {

        }

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();


        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

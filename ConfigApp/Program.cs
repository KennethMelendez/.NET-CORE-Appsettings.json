using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConfigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                        .AddJsonFile("appsettings.json", false)
                        .Build();
            var thing = configuration.GetSection("EmailAddress").Value;
            Console.WriteLine(thing);

        }

    }
}

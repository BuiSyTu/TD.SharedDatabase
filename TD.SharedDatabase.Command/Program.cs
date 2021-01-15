using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TD.SharedDatabase.Command.Services;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tinhThanhService = new TinhThanhService();

            tinhThanhService.Post();
            Console.ReadLine();
        }
    }
}

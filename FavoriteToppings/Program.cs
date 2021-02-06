using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FavoriteToppings
{
    class Program
    {
        static void Main(string[] args)
        {
            //read a file from disk
            var json = File.ReadAllText("./toppings.json");
            //deserialize from json to C#
            var toppingSelections = JsonConvert.DeserializeObject<List<PizzaSelection>>(json);
        }
    }
}

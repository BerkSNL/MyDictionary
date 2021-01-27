using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> buildingMaterials = new MyDictionary<int, string>();
            buildingMaterials.Add(13, "Cement");
            buildingMaterials.Add(55, "Clay");
            buildingMaterials.Add(7, "Wood");
            buildingMaterials.Add(81, "Building Sand");

            Console.WriteLine(buildingMaterials.Count);
            buildingMaterials.Print();
        }
    }
}

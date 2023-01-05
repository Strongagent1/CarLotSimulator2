using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
    
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        

        public void MakeEngineNoise (string model, string engineNoise)
        {
            Console.WriteLine($" The {model} makes an engine sound like {engineNoise}!");
        }
        public void MakeHonkNoise(string model, string honkNoise)
        {
            Console.WriteLine($"The {model} makes an horn sound like {honkNoise}!");
        }
        
    }
}

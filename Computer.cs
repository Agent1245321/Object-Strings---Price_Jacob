using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object___Strings___Price_Jacob
{
    /// <summary>
    /// This is the Computer class implimenting the IBootUp interface, it contains a constructer fore the brand and type of computer
    /// as well as the power status. It assigns these values to 3 auto properties. It then defines the PowerOnOff Method and ovverides the
    /// ToString() method to describe the objects.
    /// </summary>
    internal class Computer : IBootUp
    {
        string Brand { get; set; }
        string Type { get; set; }

        public bool IsOn { get; set; }

        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;

        }

        public void PowerOnOff() 
        {
            IsOn = !IsOn;
            
            if(IsOn) { Console.WriteLine("The Computer is booting up..."); }
            else { Console.WriteLine("The Computer is shutting down..."); }
        }

        public override string ToString()
        {
            return $"This is a {Type} computer by {Brand}.";
        }
    }
}

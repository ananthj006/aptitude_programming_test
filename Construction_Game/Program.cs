using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_Game
{
    class Program
    {
        private static void Main(string[] args)
        {
            var myHouse = new Building()
                            .AddKitchen()
                            .AddBedroom("master")
                            .AddBedroom("guest")
                            .AddBalcony();

            var normalHouse = myHouse.Build();

            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuryHouse = myHouse.Build();

            Console.WriteLine(luxuryHouse.Describe());
        }
    }
}

using System;

namespace Humanoid
{
    class Program
    {
        private static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill());
            
            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());
            
            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());

            Console.WriteLine("press any key to exit...");
            Console.ReadLine();

        }
    }
}

using System;
using System.Threading.Tasks;

namespace Alexa_Settings
{
    public class Method_Signature
    {
        public async void Calculate()
        {
            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);
        }

        public async Task<(long,int)> SomeCalculation(long i, int n, bool isSame)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Asynchronous operation");
            });
            
            return (i, n);
        }
    }
}

using Tyuiu.MedvederovaAB.Sprint0.Task6.V0.Lib;

namespace Tyuiu.MedvederovaAB.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = { 1, 2, 3, 4, 5 }; 
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(arraynums));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}

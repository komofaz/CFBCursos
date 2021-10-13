using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Treinando CSharp do Zero!");
            if(args.GetLength(0) > 0){
                Console.WriteLine(args.GetValue(0));
            }
            
        }
    }
}

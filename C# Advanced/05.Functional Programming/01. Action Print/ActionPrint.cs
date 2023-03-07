namespace _1.Action_Print
{
    using System;

    public class ActionPrint
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            
            Action<string[]> action = Print;
            action(input);

            Console.WriteLine();

           
            
            //lambdaAction(input);
        }

        public static void Print(string[] array)
        {
            Console.WriteLine(string.Join(Environment.NewLine, array));
        }
    }
}

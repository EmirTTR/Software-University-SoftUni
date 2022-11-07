namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            var path = Path.Combine(@"D:\SoftUni\COURSES\3.C# Advanced\8.Streams, Files and Directories - Exercises\Skeleton-Exercise\Skeleton\EvenLines\text.txt");
            var dir = Path.Combine(@"D:\SoftUni\COURSES\3.C# Advanced\8.Streams, Files and Directories - Exercises\Skeleton-Exercise\Skeleton\EvenLines\output.txt");

            var charsToReplace = new char[] { '-', ',', '.', '!', '?' };

            char charForReplacing = '@';
            using (var reader = new StreamReader(path))
            {
                var line = "";
                int counter = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (counter++ % 2 == 0)
                    {
                        var replacedString = charsToReplace
                        .Aggregate(line, (x1, x2) => x1.Replace(x2, charForReplacing))
                        .Split()
                        .ToList();

                        replacedString.Reverse();

                        using (var writer = new StreamWriter(dir, true))
                        {
                            Console.Write(string.Join(" ", replacedString));
                            writer.Write(string.Join(" ", replacedString));

                            Console.WriteLine();
                            writer.WriteLine();
                        }
                    }
                }
            } return null;
            
        }
    }
}

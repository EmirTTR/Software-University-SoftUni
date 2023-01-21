namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;///////////////////////

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"D:\SoftUni\COURSES\3.C# Advanced\8.Streams, Files and Directories - Exercises\Skeleton-Exercise\Skeleton\LineNumbers\text.txt";
            string outputFilePath = @"D:\SoftUni\COURSES\3.C# Advanced\8.Streams, Files and Directories - Exercises\Skeleton-Exercise\Skeleton\LineNumbers\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var path = Path.Combine(@"D:\SoftUni\COURSES\3.C# Advanced\8.Streams, Files and Directories - Exercises\Skeleton-Exercise\Skeleton\LineNumbers\text.txt");
            var dir = Path.Combine(@"D:\SoftUni\COURSES\3.C# Advanced\8.Streams, Files and Directories - Exercises\Skeleton-Exercise\Skeleton\LineNumbers\output.txt");

            var file = File.ReadAllLines(path).ToList();
            for (int i = 0; i < file.Count; i++)
            {
                var lettersPattern = @"[A-Za-z]";
                var lettersCount = Regex.Matches(file[i], lettersPattern);

                var punctsPattern = @"[\.\,\!\?\-\']";
                var punctsCount = Regex.Matches(file[i], punctsPattern);

                file[i] = $"Line {i + 1}:{file[i]} ({lettersCount.Count})({punctsCount.Count})";

                Console.WriteLine(file[i]);
            }

            File.WriteAllLines(dir, file);
        }
    }
}

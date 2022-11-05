namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, List<FileInfo>> extentionInfo = new Dictionary<string, List<FileInfo>>();
            var sb = new StringBuilder();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                var extention = fileInfo.Extension;
                if (extentionInfo.ContainsKey(extention))
                {
                    extentionInfo.Add(extention, new List<FileInfo>());
                }
                extentionInfo[extention].Add(fileInfo);
                foreach (var entry in extentionInfo.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
                {
                    var extentionKey = entry.Key;
                    sb.AppendLine(extentionKey);
                    List<FileInfo> filesInfo = entry.Value;
                    filesInfo.OrderByDescending(x => x.Length);

                    foreach (var item in filesInfo)
                    {
                        sb.AppendLine($"--{fileInfo.Name} - {fileInfo.Length / 1024}kb");
                    }
                }
                
            }
            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string pathReport = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllText(pathReport, textContent);

        }
    }
}

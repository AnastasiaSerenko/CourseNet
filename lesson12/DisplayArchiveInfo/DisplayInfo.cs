using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DisplayArchiveInfo
{
    class DisplayInfo
    {
        public static void GetInfo(string path)
        {
            try
            {
                string pathCSV;
                List<string> dataFromCSV = new();

                using (var stream = new StreamReader(path))
                {
                    pathCSV = stream.ReadLine();
                }

                Directory.Delete(path.Substring(0, path.LastIndexOf("\\")), true);

                using (var stream = new StreamReader(pathCSV))
                {
                    string input = stream.ReadLine();
                    while (input != null)
                    {
                        dataFromCSV.Add(input);
                        input = stream.ReadLine();
                    }
                }

                var sortData = from s in dataFromCSV
                               where (s.Split("\t"))[0] == "FILE"
                               orderby DateTime.Parse((s.Split("\t"))[2])
                               select s;

                foreach (var data in sortData)
                    Console.WriteLine(data);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! {ex.Message}");
            }
        }
    }
}

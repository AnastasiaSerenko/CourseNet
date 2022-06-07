using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace GetArchiveInfo
{
    class Archive
    {
        DirectoryInfo _subDirectory;
        string _sourceArchiveFileName;
        string _sourceCSVFileName;
        List<ComponentDiscription> _directoryDiscription;

        public Archive(string sourceArchiveFileName)
        {
            try
            {
                _subDirectory = (new DirectoryInfo
                    (Directory.GetCurrentDirectory())).CreateSubdirectory("UnPack");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! Create new folder \"UnPack\": {ex.Message}");
            }
            
            _sourceArchiveFileName = sourceArchiveFileName;
            _directoryDiscription = new();
            _sourceCSVFileName = $"C:\\Course\\{_subDirectory.Name}.csv";
        }
        
        public void GetInfo()
        {
            if (!UnPack()) return;
            if (!AddItems()) return;
            if (!WriteCSV()) return;
            if (!DeleteSubDirectory()) return;
            WriteTXT();
        }

        bool AddItems()
        { 
            try
            {
                foreach (DirectoryInfo item in _subDirectory.GetDirectories())
                    _directoryDiscription.Add
                        (new ComponentDiscription(ComponentType.FOLDER, item.Name, item.LastWriteTime));

                foreach (FileInfo item in _subDirectory.GetFiles())
                    _directoryDiscription.Add
                        (new ComponentDiscription(ComponentType.FILE, item.Name, item.LastWriteTime));
            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! Get components of {_subDirectory.Name}: {ex.Message}");
                DeleteSubDirectory();
                return false;
            }

            return true;
        }

        bool UnPack()
        { 
            try
            {
                ZipFile.ExtractToDirectory(_sourceArchiveFileName, _subDirectory.FullName);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! Extract ZipFile: {ex.Message}");
                DeleteSubDirectory();
                return false;
            }

            return true;
        }

        bool DeleteSubDirectory()
        { 
            try
            {
                if (_subDirectory.Exists)
                    _subDirectory.Delete(true);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! Delete {_subDirectory.Name}: {ex.Message}");
                return false;
            }

            return true;
        }

        bool WriteTXT()
        {
            string path = _sourceArchiveFileName.Substring
                    (0, _sourceArchiveFileName.LastIndexOf("\\"))
                    + "\\%AppData%";

            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);              
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }


            path += "\\Lesson12Homework.txt";
            WriteFile(path, _sourceCSVFileName);
            return true;                
        }

        bool WriteCSV()
        {
            List<string> dataToWrite = new();

            dataToWrite.Add("Type\tName\tLastWriteTime");
            foreach (ComponentDiscription item in _directoryDiscription)
                dataToWrite.Add(item.ToString());
            dataToWrite.Add("");

            WriteFile(_sourceCSVFileName, dataToWrite);

            return true;               
        }

        bool WriteFile(string path, List<string> data)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                using (TextWriter stream = new StreamWriter
                    (new FileStream(path, FileMode.Create, FileAccess.Write)))
                {
                    foreach (string item in data)
                        stream.WriteLine(item);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"ERROR! Write File {path}: {ex.Message}");
                return false;
            }

            return true;
        }

        bool WriteFile(string path, string data)
        {
            return WriteFile(path, new List<string> { data });
        }
    }
}

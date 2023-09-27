using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂设计模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请选择要进入的磁盘");
                string path = Console.ReadLine();
                Console.WriteLine("请选择要打开的文件");
                string fileName = Console.ReadLine();
                FileFather fileFather = GetFile(fileName, path + fileName);
                fileFather.OpenFile();
            }
        }
        public static FileFather GetFile(string fileName, string fullPath)
        {
            string extension = Path.GetExtension(fileName);
            FileFather file = null;
            switch (extension)
            {
                case ".txt": file = new TxtPath(fullPath); break;
                case ".jpeg": file = new JEPGFile(fullPath); break;
                case ".wav": file = new WAVFile(fullPath); break;
            }
            return file;
        }
    }

    public abstract class FileFather
    {
        public string fileName
        { get; set; }
        public FileFather(string fileName)
        {
            this.fileName = fileName;
        }

        public abstract void OpenFile();
    }
    public class TxtPath : FileFather
    {
        public TxtPath(string fullPath) : base(fullPath) { }
        public override void OpenFile()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(this.fileName);
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }
    }
    public class JEPGFile : FileFather
    {
        public JEPGFile(string fullPath) : base(fullPath) { }
        public override void OpenFile()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(this.fileName);
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }
    }
    public class WAVFile : FileFather
    {
        public WAVFile(string fullPath) : base(fullPath) { }
        public override void OpenFile()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(this.fileName);
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02打开文件练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要打开文件的路径");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入要打开的文件名称");
            string fileName = Console.ReadLine();
            BaseFile bf = OpenFile(filePath,fileName);
            if(bf!=null)
            {
                bf.OpenFile();
            }

        }
        static BaseFile OpenFile(string filePath,string fileName)
        {
            BaseFile bf = null;
            string extension = Path.GetExtension(fileName);
            switch (extension)
            {
                case".txt":
                    bf=new TxtFile(filePath,fileName);
                    break;
                case".mp4":
                    bf=new Mp4File(filePath,fileName);
                    break;
                case".avi":
                    bf= new AviFile(filePath,fileName);
                    break;

            }
            return bf;
        }
      
       
    }

    class BaseFile
    {
        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public string FileName { get; set; }
        public BaseFile (string filePath,string fileName)
	    {
            this.FilePath=filePath;
            this.FileName=fileName;
	    }

        public void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(FilePath+"//"+FileName);
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
        }
    }

    class Mp4File:BaseFile
    {
        public Mp4File(string filePath,string fileName):base(filePath,fileName)
        {

        }
    }
    class AviFile:BaseFile
    {
        public AviFile(string filePath,string fileName):base(filePath,fileName)
        {

        }
    }
    class TxtFile:BaseFile
    {
        public TxtFile(string filePath,string fileName):base(filePath,fileName)
        {

        }
    }
   
    
}

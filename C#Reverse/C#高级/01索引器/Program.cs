using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01索引器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndexNamees indexNamees = new IndexNamees();
            indexNamees[0] = "hellp";
            indexNamees[1] = "e";
            indexNamees[2] = "heqq2ellp";
            indexNamees[3] = "heqeqllp";
            indexNamees[4] = "heltlp";
            indexNamees[5] = "helqserlp";
            indexNamees[6] = "heleaeealp";
            indexNamees[7] = "r";
            indexNamees[8] = "heledylp";
            indexNamees[9] = "heltlp";

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(indexNamees[i]);
            }

        }
    }
    class IndexNamees
    {
        private string[] nameList = new string[10];

        public IndexNamees()
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                nameList[i] = i.ToString();
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp = "";
                if (index >= 0 && index <= this.nameList.Length - 1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index <= this.nameList.Length - 1)
                {
                    nameList[index] = value;
                }
            }
        }
    }
}

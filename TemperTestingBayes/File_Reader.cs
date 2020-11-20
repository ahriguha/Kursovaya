using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperTestingBayes
{
    class File_Reader
    {
        public static List<string[]> GetQuestions(string path)
        {
            List<string[]> questionList = new List<string[]>();
            using (StreamReader reader = new StreamReader(path))
            {
                for(int i = 0; i < 5; i++)
                {
                    questionList.Add(reader.ReadLine().Split(' '));
                }
            }
            return questionList;
        }

        public static int[,] GetTrainTable(string path)
        { 
            int lines = 0;
            string line;
            int[,] trainTable;
            using (StreamReader counter = new StreamReader(path))
            {
                while (counter.ReadLine()!= null)
                {
                    lines++;
                }                   
            }

            using (StreamReader reader = new StreamReader(path))
            {
                trainTable = new int[lines,6];
                for(int i = 0; i < lines; i++)
                {
                    int j = 0;
                    line = reader.ReadLine();
                    int[] temp = new int[6];
                    foreach(string s in line.Split(','))
                    {
                        temp[j] = int.Parse(s);
                        j++;
                    }
                    for(int k = 0; k < 6; k++)
                    {
                        trainTable[i, k] = temp[k];
                    }
                }
            }
            return trainTable;
        }
     
    }
}

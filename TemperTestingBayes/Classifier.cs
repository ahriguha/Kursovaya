using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperTestingBayes
{
    class Classifier
    {
        int[,] trainTable;
        int[] ClassesFreqTable;
        List<List<double[]>> xFreqsList;

        static int[] testCase = new int[] { 3, 1, 3, 3, 4 };

        public Classifier()
        {
            
        }

        public void Fit(int[,] trainTable)
        {
            this.trainTable = trainTable;
            ClassesFreqTable = GetClassesFreqTable();

            xFreqsList = new List<List<double[]>>();
            for (int i = 1; i < 6; i++)
            {
                xFreqsList.Add(GetXFreqList(i, ClassesFreqTable));
            }
        }
        //public Classifier()
        //{
            
        //    int[] ClassesFreqTable = GetClassesFreqTable();

        //    List<List<double[]>> xFreqsList = new List<List<double[]>>();
        //    for (int i = 1; i < 6; i++)
        //    {
        //        xFreqsList.Add(GetXFreqList(i, ClassesFreqTable));
        //    }

        //    Print(GetPrediction(testCase, xFreqsList));
        //    Console.ReadLine();
        //}


        int[] GetClassesFreqTable()
        {
            int[] frqTable = new int[4];
            for (int i = 0; i < trainTable.GetLength(0); i++)
            {
                frqTable[trainTable[i, 5] - 1]++;
            }
            return frqTable;
        }

        List<double[]> GetXFreqList(int x, int[] ClassesFreq)
        {
            List<double[]> frqXList = new List<double[]>
            {
                new double[4],
                new double[4],
                new double[4],
                new double[4]
            };
            for (int j = 0; j < trainTable.GetLength(0); j++)
            {
                frqXList[trainTable[j, x - 1] - 1][trainTable[j, 5] - 1]++;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    frqXList[i][j] /= ClassesFreq[j];
                    if (frqXList[i][j] == 0)
                        frqXList[i][j] = 0.09f;
                    else if (frqXList[i][j] == 1)
                        frqXList[i][j] = 0.99f;
                }
            }

            return frqXList;
        }

        public double[] GetPrediction(int[] testCase)
        {      
            
                double[] predictedClasses = new double[4];
                double probability;
                for (int i = 0; i < 4; i++)
                {
                    probability = xFreqsList[0][testCase[0]-1][i];
                    for (int j = 1; j < 5; j++)
                    {
                        probability *= xFreqsList[j][testCase[j] - 1][i];
                    }
                    predictedClasses[i] = probability;
                }
                
                return probabilityNormalize(predictedClasses);
        }

        double[] probabilityNormalize(double[] predictedClasses)
        {
            double sum = 0;
            foreach (double d in predictedClasses)
                sum += d;
            for (int i = 0; i < predictedClasses.Length; i++)
                predictedClasses[i] /= sum;
            return predictedClasses;
        }

        void Print(double[] array)
        {
            foreach (double d in array)
                Console.WriteLine(Math.Round(d, 2));
        }
    }
}


//public static List<TrainData> trainDatas = new List<TrainData>
//{
//    new TrainData(new List<string>{"тихий", "ригидный", "тревожный", "ранимый", "необщительный" }, "melanholik"),
//    new TrainData(new List<string>{"беспокойный", "непостоянный", "чувствительный", "обидчивый", "активный" }, "holerik"),
//    new TrainData(new List<string>{"беззаботный", "жизнерадостный", "отзывчивый", "неунывающий", "инициативный" }, "sangvinik"),
//    new TrainData(new List<string>{"пассивный", "спокойный", "осмотрительный", "миролюбивый", "доброжелательный" }, "flegmatik")
//};
//public static int[,] trainTable = new int[,]
//{/* five question answers and result from 1 to 4*/
//    { 1, 1, 1, 1, 1, 1},
//    { 2, 1, 3, 1, 1, 1},
//    { 1, 1, 1, 1, 4, 1},
//    { 1, 4, 1, 1, 1, 1},
//    { 3, 4, 1, 1, 2, 1},
//    { 1, 1, 1, 3, 1, 1},
//    { 4, 1, 1, 1, 1, 1},
//    { 1, 2, 1, 4, 3, 1},
//    { 1, 2, 1, 2, 1, 1},
//    { 1, 3, 1, 1, 2, 1},
//    { 4, 1, 1, 1, 4, 1},
//    { 2, 2, 2, 2, 2, 2},
//    { 2, 2, 2, 2, 3, 2},
//    { 2, 1, 2, 4, 2, 2},
//    { 3, 2, 1, 2, 4, 2},
//    { 2, 2, 2, 2, 1, 2},
//    { 2, 1, 2, 3, 2, 2},
//    { 1, 2, 2, 2, 1, 2},
//    { 2, 2, 4, 2, 4, 2},
//    { 2, 2, 2, 2, 2, 2},
//    { 1, 2, 4, 3, 2, 2},
//    { 2, 4, 1, 2, 3, 2},
//    { 3, 3, 3, 3, 3, 3},
//    { 3, 1, 3, 3, 3, 3},
//    { 3, 3, 2, 3, 4, 3},
//    { 3, 2, 3, 1, 3, 3},
//    { 1, 3, 4, 3, 3, 3},
//    { 3, 1, 1, 3, 3, 3},
//    { 3, 3, 3, 2, 4, 3},
//    { 3, 2, 1, 3, 3, 3},
//    { 4, 3, 3, 3, 1, 3},
//    { 3, 3, 3, 2, 2, 3},
//    { 1, 2, 3, 3, 4, 3},
//    { 4, 4, 4, 4, 4, 4},
//    { 4, 3, 4, 4, 4, 4},
//    { 4, 4, 2, 4, 1, 4},
//    { 2, 4, 3, 4, 4, 4},
//    { 4, 2, 4, 1, 4, 4},
//    { 4, 4, 1, 2, 3, 4},
//    { 2, 3, 4, 4, 4, 4},
//    { 1, 4, 4, 1, 1, 4},
//    { 4, 4, 4, 2, 2, 4},
//    { 3, 4, 1, 4, 4, 4},
//    { 4, 2, 4, 2, 4, 4}
//};
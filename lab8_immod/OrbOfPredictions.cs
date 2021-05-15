using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_immod
{
    class OrbOfPredictions
    {
        private List<double> ProbList = new List<double>();
        private Random random = new Random();

        private void GenerateProbArray()
        {
            ProbList.Clear();
            double sum_p = 0.0;

            for (int i = 0; i < 8; i++)
            {
                double rand_p = random.NextDouble();
                ProbList.Add(rand_p);
                sum_p += rand_p;
            }

            double new_sum = 0.0;
            for (int i = 0; i < 8; i++)
            {
                ProbList[i] /= sum_p;
                new_sum += ProbList[i];
            }
        }

        public int MakeOrbPred()
        {
            double A = random.NextDouble();
            int k = 1;
            GenerateProbArray();

            while (A > 0)
            {
                A -= ProbList[k - 1];
                k++;
            }

            return k;
        }
    }
}

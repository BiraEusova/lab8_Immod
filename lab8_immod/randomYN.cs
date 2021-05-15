using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_immod
{
    class randomYN // random answers YES NO
    {
        private Random random = new Random();
        private double fixProbability = 0.5;

        public string getAnswer()
        {
            double probability = random.NextDouble();

            if (probability > fixProbability) return "YES";
            else return "NO";
        }
    }
}

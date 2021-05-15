using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_immod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetAnswer_Click(object sender, EventArgs e)
        {
            var randomAnswer = new randomYN();
            var answer = randomAnswer.getAnswer();

            labelAnswer.Text = answer;
        }

        private void buttonGetAnswerOrb_Click(object sender, EventArgs e)
        {
            var OrbOfPred = new OrbOfPredictions();
            var randEvent = OrbOfPred.MakeOrbPred();

            labelAnswerOrb.Text = randEvent.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form ,View
    {
        Model model;
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
            model = new TwoZeroFourEightModel();
        }

        public void Notify(Model m)
        {
            //UpdateBoard(((TwoZeroFourEightModel)m).GetBoard());
            UpdateScore(((TwoZeroFourEightModel)m).GetScore());
        }

        private void UpdateScore(int score)
        {

            //fs.temp_score(score);
            label1.Text = Convert.ToString(score);
            //fs.Show();


        }



        //public void temp_score(int s) {
        //    lblScore.Text = Convert.ToString(s);
       // }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

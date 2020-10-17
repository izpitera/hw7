using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7  // Konstantin Konovalov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            toolStripMenuItem1.Text = "Игра";
            this.Text = "Удвоитель";


        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblClicks.Text = (int.Parse(lblClicks.Text) + 1).ToString();

        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblClicks.Text = (int.Parse(lblClicks.Text) + 1).ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            lblClicks.Text = (int.Parse(lblClicks.Text) + 1).ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            lblClicks.Text = "0";
            Random r = new Random();
            lblAim.Text = Convert.ToString(r.Next(0, 100));
        }
    }
}

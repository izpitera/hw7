using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7
{
    public partial class Form2 : Form
    {
        int aim;
        public Form2()
        {
            InitializeComponent();
            Random r = new Random();
            this.aim = r.Next(0, 100);
            lblTry.Text = "0";
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            int input;
            lblTry.Text = Convert.ToString(Convert.ToInt32(lblTry.Text) + 1);
            if (Int32.TryParse(txtResult.Text, out input))
            {
                //lblGuess.Text = Convert.ToString(aim);
                if (aim == input)
                {
                    lblMessage.Text = $"Точно в цель!!! Количество попыток: {lblTry.Text}! Попробуете ещё раз?";
                    this.aim = new Random().Next(0, 100);
                    lblTry.Text = "0";
                }
                else if (aim < input)
                {
                    lblMessage.Text = "Меньше...";
                }
                else if (aim > input)
                {
                    lblMessage.Text = "Больше...";
                }
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

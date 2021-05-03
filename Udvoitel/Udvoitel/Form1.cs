using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udvoitel
{

    

    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            label1.Text = "0";
            this.Text = "Удвоитель";
        }
        int c = 1;
        public void button1_Click(object sender, EventArgs e)
        {
          lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            
          label1.Text = c++.ToString();
        }

        public void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            label1.Text = c++.ToString();
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
        }

        public void lblNumber_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }
        
        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
           
            Random rnd = new Random();
            int value = rnd.Next(1,10);
            MessageBox.Show("Попробуй поучить число" + value);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Угадай число от 1 до 100");
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        public void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            int UserAnswer = int.Parse(textBox1.Text);
                    
            if (UserAnswer == number)
            {
                MessageBox.Show("Вы угадали!");
            }
            else if (UserAnswer>number)
            {
             MessageBox.Show("Вы ввели слишком большое число.");
            }
            else if (UserAnswer < number)
            {
                MessageBox.Show("Вы ввели слишком маленькое число.");
            }
            label1.Text = c++.ToString();

        }
    }
}

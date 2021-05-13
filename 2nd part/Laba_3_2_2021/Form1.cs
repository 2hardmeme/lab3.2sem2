using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3_2_2021
{
    public partial class Form1 : Form
    {
        int count = 0;
        int index = 0;
        Random ra = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Enlarge();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveDown();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            
            int randSize = ra.Next(40, 150);
            int rand = ra.Next(30, 610 - randSize);
            int rand2 = ra.Next(30, 445 - randSize);
            CEmblem figure = new CEmblem(rand, rand2, randSize, "Фігура " + count, Color.DarkBlue);
            figure.Show();
            figure.Draw(pictureBox1);
            comboBox1.Items.Add(figure);
            comboBox1.SelectedIndex = index;
            index++;
            figure = (CEmblem)comboBox1.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Hide();
            figure.Draw(pictureBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndUp();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveUp();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndLeft();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveLeft();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.MoveRight();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndDown();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.EndRight();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Reduce();
            figure.Show();
            figure.Draw(pictureBox1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            CEmblem figure = (CEmblem)comboBox1.SelectedItem;
            if (figure.currentColor == Color.White) { return; }
            figure.Hide();
            figure.Draw(pictureBox1);
            figure.Rotate(pictureBox1);
            figure.Show();
            figure.Draw(pictureBox1);
        }
    }
}
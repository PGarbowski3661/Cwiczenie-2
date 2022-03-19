using Przykładowa_aplikacja.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przykładowa_aplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StudenciListBox.ValueMember = "ImieiNazwisko";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To jest jakieś info");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(ImieTextBox.Text))
            {
                MessageBox.Show("Imię nie może być puste");
                return;
            }
            if (string.IsNullOrWhiteSpace(NazwiskoTextBox.Text))
            {
                MessageBox.Show("Nazwisko nie może być puste");
                return;
            }

                Student nowyStudent = new Student();
            
            nowyStudent.Imie = ImieTextBox.Text;
            nowyStudent.Nazwisko = NazwiskoTextBox.Text;

            StudenciListBox.Items.Add(nowyStudent);

            ImieTextBox.Text = "";
            NazwiskoTextBox.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudenciListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

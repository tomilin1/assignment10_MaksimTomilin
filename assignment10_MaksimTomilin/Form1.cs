using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment10_MaksimTomilin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pet != null)
            {
                listBox1.Items.Add("Pet's name: " + pet.Name);
                listBox1.Items.Add("Pet's type: " + pet.Type);
                listBox1.Items.Add("Pet's age: " + pet.Age);
            }
            else
            {
                MessageBox.Show("Enter your data please");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        PetClass pet;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string type = textBox2.Text;
            decimal age = 0.0m;
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(textBox3.Text, out age))
            {
                pet = new PetClass(name, type, age);
            }
            else
                MessageBox.Show("Wrong inputr, try again");

        }
    }
}

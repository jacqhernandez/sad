using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GenerateChecklist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"Saved Generated Checklist.xls", FileMode.Create);
                     StreamWriter writeout = new StreamWriter(fs);
                     writeout.WriteLine("Order Number: " + textBox1.Text);
                     writeout.WriteLine("Contract Number: " +textBox2.Text);
                     writeout.WriteLine("Product: " + textBox4.Text);
                     writeout.WriteLine("Packaging: " + textBox3.Text);
                     writeout.WriteLine("Brand: " + textBox7.Text);
                     writeout.WriteLine("Origin: " + textBox5.Text);
                     writeout.WriteLine("Supplier: " + textBox6.Text);
                     writeout.WriteLine("Container Number: " + textBox14.Text);
                     writeout.WriteLine("Quantity: " + textBox12.Text);
                     writeout.WriteLine("Condition: " + textBox13.Text);
                     writeout.WriteLine("Cold Storage: " + textBox11.Text);
                     writeout.WriteLine("Date: " + textBox10.Text);
                     writeout.WriteLine("No of Cartons: " + textBox8.Text);
                     writeout.Close();
                fs.Close();
            }

            catch (Exception E)
            {
 
            }
        }
    }
}

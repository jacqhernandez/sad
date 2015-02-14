using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace FinalProjectSAD
{
    public partial class View_All_Orders : Form
    {
        public View_All_Orders()
        {
            InitializeComponent();
        }

        private void View_All_Orders_Load(object sender, EventArgs e)
        {

        }

        private void AddDocsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                listBox1.Items.Add(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
                pdf.Dock = System.Windows.Forms.DockStyle.Fill;
                pdf.Enabled = true;
                
                pdf.Name = "pdfReader";

                System.Diagnostics.Process.Start(openFileDialog1.FileName);
                // Add pdf viewer to current form        
                this.Controls.Add(pdf);

                pdf.LoadFile(openFileDialog1.FileName);
                pdf.setView("Fit");
                pdf.Visible = true;
                sr.Close();
            }
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ViewDocuments : Form
    {
        public ViewDocuments()
        {
            InitializeComponent();
        }

    
        private void UpdateTextPosition()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();
        }
       GeneratetodoChecklist genform = new GeneratetodoChecklist();
       private void button4_Click(object sender, EventArgs e)
       {
           genform.ShowDialog();
           List<string> list = genform.SelectedItem;
           for (int i = 0; i < list.Count; i++)
           {
               checkedListBox1.Items.Add(list[i]);
           }
           genform.SelectedItem.RemoveRange(0, list.Count);
       }

       AddtodoChecklist addform = new AddtodoChecklist();
       private void button2_Click(object sender, EventArgs e)
       {
           addform.ShowDialog();
           checkedListBox1.Items.Add(addform.AddItem);
       }
     }
}

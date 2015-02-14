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
    public partial class GeneratetodoChecklist : Form
    {
        private List<string> _selectedItems = new List<String>();
       
            
        public GeneratetodoChecklist()
        {
            InitializeComponent();
        }
        public List<string> SelectedItem
        {
            get { return _selectedItems; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    _selectedItems.Add(checkedListBox1.Items[i].ToString());
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

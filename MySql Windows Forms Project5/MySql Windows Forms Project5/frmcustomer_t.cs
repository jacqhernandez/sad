/*
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* This code is generated by a tool and is provided "as is", without warranty of any kind,
* express or implied, including but not limited to the warranties of merchantability,
* fitness for a particular purpose and non-infringement.
* In no event shall the authors or copyright holders be liable for any claim, damages or
* other liability, whether in an action of contract, tort or otherwise, arising from,
* out of or in connection with the software or the use or other dealings in the software.
* ++++++++++++++++++++++++++++++++++++++++++++++++++
* */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Objects;

namespace MySql_Windows_Forms_Project5
{
	public partial class frmcustomer_t : Form
	{
		private Model1Entities ctx;
		
		public frmcustomer_t()
		{
			InitializeComponent();
		}
		
		private void frmcustomer_t_Load(object sender, EventArgs e)
		{
			ctx = new Model1Entities();
			ObjectResult<customer_t> _entities = ctx.customer_t.Execute(MergeOption.AppendOnly);
			customer_tBindingSource.DataSource = _entities;
			bindingNavigatorAddNewItem.Enabled = false;
			bindingNavigatorCountItem.Enabled = false;
			bindingNavigatorDeleteItem.Enabled = false;
			bindingNavigatorMoveFirstItem.Enabled = false;
			bindingNavigatorMovePreviousItem.Enabled = false;
			bindingNavigatorPositionItem.Enabled = false;
			bindingNavigatorMoveNextItem.Enabled = false;
			bindingNavigatorMoveLastItem.Enabled = false;
			toolStripButton1.Enabled = true;
			dataGridView1.AutoGenerateColumns = false;
			string strConn2 = "port=3306;server=localhost;user id=root;password=root;database=pinevalley;";
			MySql.Data.MySqlClient.MySqlDataAdapter ad2 = null;
			System.Windows.Forms.DataGridViewTextBoxColumn colcustomer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colcustomer_id.DataPropertyName = "customer_id";
			colcustomer_id.HeaderText = "customer_id";
			colcustomer_id.Name = "colcustomer_id";
			dataGridView1.Columns.Add(colcustomer_id);
			System.Windows.Forms.DataGridViewTextBoxColumn colcustomer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colcustomer_name.DataPropertyName = "customer_name";
			colcustomer_name.HeaderText = "customer_name";
			colcustomer_name.Name = "colcustomer_name";
			dataGridView1.Columns.Add(colcustomer_name);
			System.Windows.Forms.DataGridViewTextBoxColumn colcustomer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colcustomer_address.DataPropertyName = "customer_address";
			colcustomer_address.HeaderText = "customer_address";
			colcustomer_address.Name = "colcustomer_address";
			dataGridView1.Columns.Add(colcustomer_address);
			System.Windows.Forms.DataGridViewTextBoxColumn colcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colcity.DataPropertyName = "city";
			colcity.HeaderText = "city";
			colcity.Name = "colcity";
			dataGridView1.Columns.Add(colcity);
			System.Windows.Forms.DataGridViewTextBoxColumn colstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colstate.DataPropertyName = "state";
			colstate.HeaderText = "state";
			colstate.Name = "colstate";
			dataGridView1.Columns.Add(colstate);
			System.Windows.Forms.DataGridViewTextBoxColumn colpostal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colpostal_code.DataPropertyName = "postal_code";
			colpostal_code.HeaderText = "postal_code";
			colpostal_code.Name = "colpostal_code";
			dataGridView1.Columns.Add(colpostal_code);
			dataGridView1.DataSource = _entities;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			customer_tBindingSource.EndEdit();
			ctx.SaveChanges();
			
		}
		
		private void frmcustomer_t_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string s;
			DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
			object value = e.FormattedValue;
			e.Cancel = false;
			row.ErrorText = "";
			if (row.IsNewRow) return;
			if (e.ColumnIndex == 0)
			{
				int v;
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field customer_id is required";
					return;
				}
				s = value.ToString();
				if( !int.TryParse( s, out v ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field customer_id must be int.";
					return;
				}
			}
			if (e.ColumnIndex == 1)
			{
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field customer_name is required";
					return;
				}
			}
			if (e.ColumnIndex == 2)
			{
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field customer_address is required";
					return;
				}
			}
			if (e.ColumnIndex == 3)
			{
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field city is required";
					return;
				}
			}
			if (e.ColumnIndex == 4)
			{
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field state is required";
					return;
				}
			}
			if (e.ColumnIndex == 5)
			{
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field postal_code is required";
					return;
				}
			}
		}
		
		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			dataGridView1.Rows[e.RowIndex].ErrorText = e.Exception.Message;
			e.Cancel = true;
		}
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			customer_tBindingSource.AddNew();
		}
	}
}

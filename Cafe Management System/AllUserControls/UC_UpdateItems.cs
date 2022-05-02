using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.AllUserControls
{
    public partial class UC_UpdateItems : UserControl
    {

        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
                
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0]; 
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id=int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category=guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = category;
            txtItemName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text != "" && txtCategory.Text != "" && txtPrice.Text != "0")
            {
                query = "update items set name='" + txtItemName.Text + "',category = '" + txtCategory.Text + "',price=" + txtPrice.Text + " where iid = " + id + "";
                fn.setData(query);
                loadData();

                txtItemName.Clear();
                txtCategory.Clear();
                txtPrice.Clear();
            }
            else
            {
                MessageBox.Show("No Item Selected");
            }
        }
    }
}

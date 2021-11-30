using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class testany : Form
    {
        public testany()
        {
            InitializeComponent();
        }
        private const string ConnectionString = @"Data Source=.;Initial Catalog=Warehouse;Integrated Security=True;";
     


        private void testany_Load(object sender, EventArgs e)
        {
         
        }



        void Form1_SelectedIndexChanged(object sender, EventArgs e)

        {

            //throw new Exception("The method or operation is not implemented.");

            int row = this.dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[row].Cells[2].Value = ((ComboBox)sender).SelectedValue;

        }



        private DataTable GetData(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {  
        }
        public object AddColINGrid;//add data from textbox to  datagrid ;

        private void label1_Click(object sender, EventArgs e)
        {
            AddColINGrid = dataGridView1.Rows.Add("1");


            //dataGridView1.Rows[1].Visible = false;

            var loopTo = dataGridView1.Rows.Count - 1;
            for (var i = 0; i <= loopTo; i++)
            {
                DataGridViewRow rw = dataGridView1.Rows[i];
                rw.Height = 32;
                 //textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();


            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Fetch the data from Database.
            dataGridView1.DataSource = this.GetData("SELECT ProdouctsID FROM WatehouseProdoucts");
            
            dataGridView1.AllowUserToAddRows = false;

            //Add a ComboBox Column to the DataGridView.
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Country";
            comboBoxColumn.Width = 100;
            comboBoxColumn.Name = "comboBoxColumn";
            comboBoxColumn.DataSource= this.GetData("SELECT ProdouctsID, Pname FROM WatehouseProdoucts");
            comboBoxColumn.DisplayMember = "Pname";
            comboBoxColumn.ValueMember = "ProdouctsID";
            //if(dataGridView1.Rows.Count < 1) { 
            dataGridView1.Columns.Add(comboBoxColumn);
            //}
            //Loop through the DataGridView Rows.

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(dataGridView1.Rows.Count >1)
                {
                    return;
                }
             
                //Reference the ComboBoxCell.
                DataGridViewComboBoxCell comboBoxCell = (row.Cells[0] as DataGridViewComboBoxCell);
                
                //Fetch the Countries from Database.
                DataTable dt = this.GetData("SELECT ProdouctsID, Pname FROM WatehouseProdoucts");

                //Loop through the DataTable Rows.
                foreach (DataRow drow in dt.Rows)
                {
                    //Fetch the CustomerId (Primary Key) value.
                    string customerId = drow[0].ToString();

                    //Add the Country value to the ComboBoxCell.
                    comboBoxCell.Items.Add(drow[1]);
                    //comboBoxCell.DisplayMember = "llll";
                    //Except for CustomerId #3.
                    if (customerId != "1")
                    {
                        //Compare the value of CustomerId.
                        if (row.Cells[0].Value.ToString() == customerId)
                        {
                            //Once CustomerId is matched, select the Country in ComboBoxCell.
                            comboBoxCell.Value = drow[1];
                        }
                    }
                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }





        ComboBox comboBox;
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            comboBox = e.Control as ComboBox;
            if (comboBox != null)
            {

            
            comboBox.SelectedValueChanged-= new EventHandler(comboBox_ValueMember);

            comboBox.SelectedValueChanged += comboBox_ValueMember;      
               
        }
        }

        private void comboBox_ValueMember(object sender,EventArgs e)
        {
            string selected = (sender as ComboBox).SelectedValue.ToString();
            MessageBox.Show(selected);
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Country";
            comboBoxColumn.Width = 100;
            comboBoxColumn.Name = "comboBoxColumn";
            comboBoxColumn.DataSource = this.GetData("SELECT ProdouctsID, Pname FROM WatehouseProdoucts");
            comboBoxColumn.DisplayMember = "Pname";
            comboBoxColumn.ValueMember = "ProdouctsID"; dataGridView1.Columns.Add(comboBoxColumn);

        }
    }
}


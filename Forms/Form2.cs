using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace sales_application
{
    public partial class Form2 : Form
    {

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-QD1DI59\\ONPRO;Database=SaleDatabase;Trusted_Connection=True;");
        SqlCommand sqlCommand;
        SqlDataAdapter sqlAdapter;
        int ID = 0;

        public Form2()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            sqlConnection.Open();
            DataTable dt = new DataTable();
            sqlAdapter = new SqlDataAdapter("select * from tbl_Record", sqlConnection);
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text != "" && txt_State.Text != "")
            {
                sqlCommand = new SqlCommand("insert into tbl_Record(Name,State) values(@name,@state)", sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@name", txt_Name.Text);
                sqlCommand.Parameters.AddWithValue("@state", txt_State.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
        }

        private void ClearData()
        {
            txt_Name.Text = "";
            txt_State.Text = "";
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_State.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text != "" && txt_State.Text != "")
            {
                sqlCommand = new SqlCommand("update tbl_Record set Name=@name,State=@state where ID=@id", sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", ID);
                sqlCommand.Parameters.AddWithValue("@name", txt_Name.Text);
                sqlCommand.Parameters.AddWithValue("@state", txt_State.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                sqlConnection.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID!=0)
            {
                sqlCommand = new SqlCommand("delete tbl_Record where ID=@id", sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@id", ID);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                sqlConnection.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}

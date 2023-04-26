using MySql.Data.MySqlClient;
using System.Data;


namespace SearchWithMySQL
{
    public partial class Form1 : Form
    {

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        string server = "localhost";
        string username = "root";
        string password = "1234";
        string database = "phone_book";


        public Form1()
        {
            InitializeComponent();
        }
        private void upLoadData()
        {
            sqlConn.ConnectionString = "User Id=root;" + "Host=localhost;" + "Password=" + password + ";" + "Database="  + database + ";";

            sqlConn.Open();
            sqlCmd.Connection= sqlConn;
            sqlCmd.CommandText = "SELECT * FROM phone_book.customer_list";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource= sqlDt; 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("Confirm if you want to exit", "MySQL Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Control c in panel4.Controls){
                    if(c is TextBox)
                        ((TextBox)c).Clear();
                }
                //textSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            upLoadData();
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "User Id=root;" + "Host=localhost;" + "Password=" + password + ";" + "Database=" + database + ";";
            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandText = "delete from phone_book.customer_list where id = @id";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            sqlConn.Close();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
 
            upLoadData();
            sqlConn.Close();

        }

        private void Add_NewClick(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "User Id=root;" + "Host=localhost;" + "Password=" + password + ";" + "Database=" + database + ";";

            try
            {
                sqlConn.Open();
                sqlQuery = "insert into phone_book.customer_list (id, first_name, last_name, age, date_of_birth, debt, cell_number, land_line, email, address, comment)" +
                    "values('" + textId.Text + "','" + textFirstName.Text + "','" + textLastName.Text + "','" + textAge.Text + "','" + textDateOfBirth.Text + "','"
                    + textDebt.Text + "','" + textCellNumber.Text + "','" + textLandLine.Text + "','" + textEmail.Text + "','" + textAddress.Text + "','" + "NULL" + "');";

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlConn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            { sqlConn.Close(); }
            upLoadData();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //sqlConn.ConnectionString = "User Id=root;" + "Host=localhost;" + "Password=" + password + ";" + "Database=" + database + ";";
            sqlConn.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "UPDATE phone_book.customer_list SET id = @id, first_name = @first_name, " +
                    "last_name = @last_name, age = @age, date_of_birth = @date_of_birth, debt = @debt, cell_number = @cell_number" +
                    "land_line = @land_line, email = @email, address = @address, comment = @comment";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@id", textId.Text);
                sqlCmd.Parameters.AddWithValue("@first_name", textFirstName.Text);
                sqlCmd.Parameters.AddWithValue("@last_name", textLastName.Text);
                sqlCmd.Parameters.AddWithValue("@age", textAge.Text);
                sqlCmd.Parameters.AddWithValue("@date_of_birth", textDateOfBirth.Text);
                sqlCmd.Parameters.AddWithValue("@debt", textDebt.Text);
                sqlCmd.Parameters.AddWithValue("@cell_number", textCellNumber.Text);
                sqlCmd.Parameters.AddWithValue("@land_line", textLandLine.Text);
                sqlCmd.Parameters.AddWithValue("@email", textEmail.Text);
                sqlCmd.Parameters.AddWithValue("@address", textAddress.Text);
                //sqlCmd.Parameters.AddWithValue("@comment", textBox11.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                upLoadData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textAge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textDateOfBirth.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textDebt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textCellNumber.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textLandLine.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textEmail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                textAddress.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
               

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            try 
            {
                DataView dv = sqlDt.DefaultView;
                dv.RowFilter = string.Format("Firstname like'%{0}%'", textBox11.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

    }
}
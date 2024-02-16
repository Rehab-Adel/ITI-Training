using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlDataAdapter DAdapter;
        SqlConnection sqlConnection;
        DataSet DSet;

        SqlCommand SelectCmd;
        SqlCommand InsertCmd;
        SqlCommand UpdateCmd;
        public Form1()
        {
            InitializeComponent();
            DAdapter = new SqlDataAdapter();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source = . ; Initial Catalog = Company; Integrated Security = true";
            DSet = new DataSet();
            SelectCmd = new SqlCommand();
            SelectCmd.Connection = sqlConnection;
            SelectCmd.CommandText = "Select * from Employee";
            DAdapter.SelectCommand = SelectCmd;

            InsertCmd = new SqlCommand();
            InsertCmd.Connection = sqlConnection;
            InsertCmd.CommandText = "insert into employee (id, name, departmentno) values (@Id, @Name, @Departmentno)";
            SqlParameter s_id = new SqlParameter("@id", SqlDbType.Int, 0, "Id");
            SqlParameter s_name = new SqlParameter("@name", SqlDbType.VarChar, 0, "Name");
            SqlParameter s_deptNo = new SqlParameter("@departmentno", SqlDbType.Int, 0, "Departmentno");
            InsertCmd.Parameters.Add(s_id);
            InsertCmd.Parameters.Add(s_name);
            InsertCmd.Parameters.Add(s_deptNo);
            DAdapter.InsertCommand = InsertCmd;

            UpdateCmd = new SqlCommand();
            UpdateCmd.Connection = sqlConnection;
            UpdateCmd.CommandText = "UPDATE Employee SET Id = @Id, Name = @Name, Departmentno = @Departmentno WHERE Id = @Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAdapter.Fill(DSet);
            dataGridView1.DataSource = DSet.Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow DRow = DSet.Tables[0].NewRow();
            DRow[0] = int.Parse(textBox1.Text);
            DRow[1] = textBox2.Text;
            DRow[2] = int.Parse(textBox3.Text);
            DSet.Tables[0].Rows.Add(DRow);
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAdapter.Update(DSet);
            MessageBox.Show("Updated Successfully");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;

namespace Connected_Model
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source = .; Initial Catalog = Company; Integrated Security = true;";
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            listBox1.Items.Clear();
            sqlCommand.CommandText = "Select number, name From Department";
            sqlConnection.Open();
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string str = ((int)reader[0]).ToString() + "\t-\t" + reader[1].ToString();
                listBox1.Items.Add(str);
            }
            reader.Close();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Insert Into Department Values(" + textBox1.Text + ", '" + textBox2.Text + "')";
            Excution(str);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Update Department Set name = '" + textBox2.Text + "' Where number = " + textBox1.Text;
            Excution(str);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "Delete From Department Where name = '" + textBox2.Text + "'";
            Excution(str);
            
        }
        private void Excution(string str)
        {
            sqlCommand.CommandText = str;
            sqlConnection.Open();
            int affectedRows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(affectedRows.ToString() + " Affected Rows");
            textBox1.Text = textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sqlConnection.Close();
        }
    }
}

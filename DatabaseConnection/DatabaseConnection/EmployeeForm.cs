using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["localDbString"].ConnectionString;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM EMPLOYEE", connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    MessageBox.Show(dataReader["FirtName"].ToString());
                }
                
            } catch(SqlException ex)
            {
                MessageBox.Show("Error on SQL Connection", ex.Message);
            }
            
        }
    }
}

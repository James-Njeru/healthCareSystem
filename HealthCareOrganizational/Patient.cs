using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HealthCareOrganizational
{
    public partial class Patient : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Patient()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jimmy\Documents\HealthCareOrganizational.accdb;Persist Security Info=False;";

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Patient ([PatientID], [PatientName], [DiseaseType], [PatientDOB], [DoctorID], [NurseID], [BillID], [WardBoyID]) values('" + TextBox1.Text + "','" +
                    TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')";
                command.ExecuteNonQuery();

                MessageBox.Show("Data Saved");
                connection.Close();
                connection.Dispose();
            }
            catch
            {
                MessageBox.Show("Failed to save");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Patient set PatientName='" + TextBox2.Text + "', DiseaseType='" + TextBox3.Text + "', PatientDOB='" + TextBox4.Text + "', DoctorID='" + TextBox5.Text + "',NurseID='" + TextBox6.Text + "',BillID='" +
                    TextBox7.Text + "', WardBoyID='" + TextBox8.Text + "' where PatientID=" + TextBox1.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Data Updated");
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Update" + ex);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Patient where EmployeeID=" + TextBox1.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Data Deleted");
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Dellete" + ex);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }
    }
}

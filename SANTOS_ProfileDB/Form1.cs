using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SANTOS_ProfileDB
{
    public partial class frmHome : Form
    {
        MySqlConnection con = new MySqlConnection(@" 
            datasource = 107.180.41.126;
             port=3306;
            database=ccs2601db;
            username=ccs2601user;
            password=ccs2601pw; "); // inside the partial class, must be outside constructor   // conenction code to public sql
        MySqlCommand cmd; 
        MySqlDataReader rdr;


        public frmHome()
        {
            InitializeComponent();
        }

        // load data fresh new copy 
        public void LoadStudent()
        {
            dataSTudents.Rows.Clear();
            con.Open(); // connection open
            cmd = new MySqlCommand(@"SELECT ID, studID, lastname, firstname, middlename 
                FROM Students;", con);  // basically an sql command
            rdr = cmd.ExecuteReader();
            while (rdr.Read()) // if data grid is present 
            {
                dataSTudents.Rows.Add(rdr.GetString(0), rdr.GetString(1), 
                    rdr.GetString(2), rdr.GetString(3), rdr.GetString(4));
            }
            con.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnstudADD_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand(@"INSERT INTO Students
                (studID, lastname, firstname, middlename) VALUES 
                ('" + txtstudID.Text + "','" + txtLname.Text + "','"
                   + txtFname.Text + "','" + txtMname.Text + "');", con); // try one quote only inside and outside
            cmd.ExecuteNonQuery();
            con.Close(); //close connection


            MessageBox.Show("Student Added Successfully!", "Success");
            LoadStudent();
            clearALL();// clear after pressing add
        }
        private void clearALL() // clear button
        {
            txtID.Clear();
            txtFname.Clear();
            txtstudID.Clear();
            txtLname.Clear();
            txtMname.Clear();
        }

        private void dataSTudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataSTudents.SelectedRows.Count > 0) // if data is present
            {
                txtID.Text = dataSTudents.SelectedRows[0].Cells[0].Value.ToString(); // transfer value to texbox
                txtstudID.Text = dataSTudents.SelectedRows[0].Cells[1].Value.ToString();
                txtLname.Text = dataSTudents.SelectedRows[0].Cells[2].Value.ToString();
                txtFname.Text = dataSTudents.SelectedRows[0].Cells[3].Value.ToString();
                txtMname.Text = dataSTudents.SelectedRows[0].Cells[4].Value.ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand(@"UPDATE Students SET StudID = '" + txtstudID.Text
                + "', lastname = '" + txtLname.Text
                + "', firstname = '" + txtFname.Text
                + "', middlename = '" + txtMname.Text
                + "' WHERE ID = '" + txtID.Text + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Student record updated!", "Success");
            LoadStudent();
            clearALL();
        }


        private void LmaooCLear()
        {
            dataSTudents.ClearSelection();
        }


        private void btnCLear_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new MySqlCommand(@"DELETE FROM Students; '", con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}

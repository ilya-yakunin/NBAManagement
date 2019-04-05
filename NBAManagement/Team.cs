using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAManagement
{
    public partial class Team : Form
    {
        private OleDbConnection con;
        private OleDbCommand request;
        private DataTable tabl;
        private OleDbDataAdapter adapter;
        private DataTable ds;
        public Team()
        {
            InitializeComponent();
            con = new OleDbConnection("File Name = connect.udl");
            con.Open();
            string sql = "select * from TablTeam";
            adapter = new OleDbDataAdapter(sql, con);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tmp = dataGridView1.CurrentRow.Index;
            int nom = Convert.ToInt32(dataGridView1 [0, tmp].Value);
            TeamDetals teamDetals = new TeamDetals(nom);
            teamDetals.Show();
        }
    }
}

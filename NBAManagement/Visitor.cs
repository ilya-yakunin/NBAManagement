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

namespace NBAManagement
{
    public partial class Visitor : Form
    {
        private OleDbConnection con;
        private OleDbCommand request;
        private DataTable tabl;
        private OleDbDataAdapter adapter;
        private DataTable ds;
        public Visitor()
        {
            InitializeComponent();
            con = new OleDbConnection("File Name = connect.udl");
            con.Open();
            string sql = "select * from schedule";
            adapter = new OleDbDataAdapter(sql, con);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.mm.yyyy";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            string sql = "select * from results";
            adapter = new OleDbDataAdapter(sql, con);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd.mm.yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            string sql = "select * from schedule";
            adapter = new OleDbDataAdapter(sql, con);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.mm.yyyy";
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tmp = dataGridView1.CurrentRow.Index;
            int nom = Convert.ToInt32(dataGridView1[0, tmp].Value);
            Matchup matchup = new Matchup(nom);
            matchup.Show();

        }
    }
}

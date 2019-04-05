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
    public partial class EditTeam : Form
    {
        private OleDbConnection con;
        private OleDbCommand request;
        private DataTable tabl;
        private OleDbDataAdapter adapter;
        private DataTable ds;

        public EditTeam()
        {
            InitializeComponent();
            con = new OleDbConnection("File Name = connect.udl");
            con.Open();
            string sql = "SELECT     dbo.Team.id, dbo.Team.name AS Название, dbo.Country.name AS Страна, dbo.Team.games AS Игр, dbo.Team.victori AS Побед, dbo.Team.loss AS Проигрышей, dbo.Team.country " +
" FROM dbo.Team INNER JOIN "+
                      " dbo.Country ON dbo.Team.country = dbo.Country.id ";
            adapter = new OleDbDataAdapter(sql, con);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tmp = dataGridView1.CurrentRow.Index;
            int nom = Convert.ToInt32(dataGridView1[0, tmp].Value);
            EditTeam2 editTeam2 = new EditTeam2(dataGridView1[1, tmp].Value.ToString(),
                dataGridView1[2, tmp].Value.ToString(), dataGridView1[3, tmp].Value.ToString(),
                dataGridView1[4, tmp].Value.ToString(), dataGridView1[5, tmp].Value.ToString(),
                Convert.ToInt32(dataGridView1[6,tmp].Value), nom
                );
            editTeam2.ShowDialog ();

            string sql = "SELECT     dbo.Team.id, dbo.Team.name AS Название, dbo.Country.name AS Страна, dbo.Team.games AS Игр, dbo.Team.victori AS Побед, dbo.Team.loss AS Проигрышей, dbo.Team.country " +
" FROM dbo.Team INNER JOIN " +
                      " dbo.Country ON dbo.Team.country = dbo.Country.id ";
            adapter = new OleDbDataAdapter(sql, con);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditTeam2 editTeam2 = new EditTeam2();
            editTeam2.ShowDialog();

            string sql = "SELECT     dbo.Team.id, dbo.Team.name AS Название, dbo.Country.name AS Страна, dbo.Team.games AS Игр, dbo.Team.victori AS Побед, dbo.Team.loss AS Проигрышей, dbo.Team.country " +
" FROM dbo.Team INNER JOIN " +
                      " dbo.Country ON dbo.Team.country = dbo.Country.id ";
            adapter = new OleDbDataAdapter(sql, con);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int tmp = dataGridView1.CurrentRow.Index;
                int nom = Convert.ToInt32(dataGridView1[0, tmp].Value);
                string sql = "DELETE FROM Team WHERE id="+nom.ToString();
                //MessageBox.Show(sql);
                OleDbCommand zapros = new OleDbCommand(sql, con);
                zapros.ExecuteNonQuery();
                MessageBox.Show("Удалено");

                sql = "SELECT     dbo.Team.id, dbo.Team.name AS Название, dbo.Country.name AS Страна, dbo.Team.games AS Игр, dbo.Team.victori AS Побед, dbo.Team.loss AS Проигрышей, dbo.Team.country " +
" FROM dbo.Team INNER JOIN " +
                      " dbo.Country ON dbo.Team.country = dbo.Country.id ";
                adapter = new OleDbDataAdapter(sql, con);
                ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = ds;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
        }
    }
}

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
    public partial class EditTeam2 : Form
    {
        public EditTeam2(string name, string country,string g, string v,string p, int nomCountry, int id)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = country;
            textBox2.Tag
                = nomCountry;
            textBox3.Text = g;
            textBox4.Text = v;
            textBox5.Text = p;
            Tag = id;
        }
        public EditTeam2()
        {
            InitializeComponent();
            button2.Click -= button2_Click;
            button2.Click += button2_Click2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("File Name = connect.udl");
            con.Open();
            string sql = "UPDATE Team set name='" + textBox1.Text + "', country=" + textBox2.Tag.ToString() +
                ", games=" + textBox3.Text + ", victori=" + textBox4.Text + ", loss=" + textBox5.Text +
                " WHERE id=" + Tag.ToString();
            //MessageBox.Show(sql);
            OleDbCommand zapros = new OleDbCommand(sql, con);
            zapros.ExecuteNonQuery();
            MessageBox.Show("Сохранено");
            Close();
        }

        private void button2_Click2(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                OleDbConnection con = new OleDbConnection("File Name = connect.udl");
                con.Open();
                string tmp = Convert.ToString(textBox2.Tag);
                string sql = "INSERT INTO Team (name,country,games,victori,loss) VALUES " +
                    "('" + textBox1.Text + "'," + ((tmp!="")?tmp:"null") + "," + textBox3.Text + "," +
                    textBox4.Text + "," + textBox5.Text + ")";
                OleDbCommand zapros = new OleDbCommand(sql, con);
                //MessageBox.Show(sql);
                zapros.ExecuteNonQuery();
                MessageBox.Show("Добавлено");
                Close();
            }
            else MessageBox.Show("Не вес поля заполнены");
        }
    }
}

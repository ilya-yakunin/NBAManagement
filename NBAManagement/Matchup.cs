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
    public partial class Matchup : Form
    {
        private OleDbConnection con;

        public Matchup(int id)
        {
            InitializeComponent();
            con = new OleDbConnection("File Name = connect.udl");
            con.Open();
            string sql =
                "SELECT     dbo.Team.name AS [Команда 1], Team_1.name AS [Команда 2], dbo.Matchup.date AS Дата, dbo.Matchup.result AS Счет, dbo.MatchupDetail.locate AS Стадион, " +
                      "dbo.MatchupDetail.detals AS Описание " +
"FROM         dbo.Matchup INNER JOIN " +
                      "dbo.Team AS Team_1 ON dbo.Matchup.team2 = Team_1.id INNER JOIN " +
                      "dbo.Team ON dbo.Matchup.team1 = dbo.Team.id INNER JOIN " +
                      " dbo.MatchupDetail ON dbo.Matchup.id = dbo.MatchupDetail.nom " +
"WHERE(dbo.Matchup.id = " + id.ToString() + ")";

            OleDbCommand zapros = new OleDbCommand(sql, con);
            OleDbDataReader tabl = zapros.ExecuteReader();
            tabl.Read();

            label1.Text += " " + Convert.ToString( tabl[0]);
            label2.Text += " " + Convert.ToString( tabl[1]);
            string[] tmp = tabl[2].ToString().Split(' ');
            label3.Text += " " + tmp[0];
            label7.Text += " " + tmp[1];
            if (tabl[3].ToString()
                != "") { label4.Text += " " + tabl[3].ToString();
                label7.Visible = false;
            }
            else label4.Visible = false;
            label5.Text += " " + tabl[4].ToString();
            label6.Text += " " + tabl[5].ToString();
        }
    }
}

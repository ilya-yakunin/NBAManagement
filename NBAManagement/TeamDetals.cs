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
    public partial class TeamDetals : Form
    {
        private OleDbConnection con;
        private OleDbCommand request;
        private DataTable tabl;
        private OleDbDataAdapter adapter;
        private DataTable ds;
        public TeamDetals(int nom)
        {
            InitializeComponent();
            con = new OleDbConnection("File Name = connect.udl");
            con.Open();
            string sql = "SELECT     dbo.Team.id, dbo.Team.name, dbo.Country.name AS country, "+
            " dbo.Team.games , dbo.Team.victori ,  dbo.Team.loss " +
            "FROM dbo.Team INNER JOIN "+
            "dbo.Country ON dbo.Team.country = dbo.Country.id "+
            "WHERE dbo.Team.id = " + Convert.ToInt32(nom);
            OleDbCommand zapros = new OleDbCommand(sql, con);
            OleDbDataReader tabl = zapros.ExecuteReader();
            tabl.Read();
            labelCountry.Text = tabl[2].ToString();
            labelName.Text = tabl[1].ToString();

            label5.Text = tabl[3].ToString();
            label7.Text = tabl[4].ToString();
            label9.Text = tabl[5].ToString();



            sql =
               " SELECT     dbo.Player.name AS Имя, dbo.PositionOfPlayer.name AS Позиция, dbo.Player.detail AS Описание" +
" FROM         dbo.Player INNER JOIN" +
 " dbo.PlayerInTeam ON dbo.Player.id = dbo.PlayerInTeam.Player INNER JOIN " +
"dbo.PositionOfPlayer ON dbo.Player.position = dbo.PositionOfPlayer.nom " +
"WHERE(dbo.PlayerInTeam.Team = "+nom.ToString()+")";

            adapter = new OleDbDataAdapter(sql, con);
            ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
           

        }
    }
}

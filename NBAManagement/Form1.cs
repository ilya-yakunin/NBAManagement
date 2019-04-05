using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            Visitor forma = new Visitor();
            forma.Show();
        }

        private void btnEventAdmin_Click(object sender, EventArgs e)
        {
            EventAdmin
                eventAdmin = new EventAdmin();
            eventAdmin.Show();
        }
    }
}

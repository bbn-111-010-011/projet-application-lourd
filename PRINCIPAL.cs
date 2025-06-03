using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_SECURITE
{
    public partial class PRINCIPAL : Form
    {

        Form frm_gst_agent = new Gestion_Agents();
        Form frm_cli = new CLIENT();

        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void gestionAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_gst_agent.Show();
        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cli.Show();

        }
    }
}

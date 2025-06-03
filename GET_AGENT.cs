using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ouverture bbilbiotheue expression 
using System.Text.RegularExpressions;



namespace GESTION_SECURITE
{
    public partial class GET_AGENT : Form
    {
        public GET_AGENT()
        {
            InitializeComponent();
        }

        private void GET_AGENT_Load(object sender, EventArgs e)
        {

        }

        private void btn_enrgst_Click(object sender, EventArgs e)
        {

            //  DECLA EXPRESSION REGULIERE 

            var nummero = new Regex(@"{0-9}+");
            var maj = new Regex(@"{A-Z}+");

            // tets expression
            if (!nummero.IsMatch()
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asadero_Pollitos_En_Fuga
{
    public partial class MenuPlatos : Form
    {
        public MenuPlatos()
        {
            InitializeComponent();
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            MenuExtras menuExtras = new MenuExtras();
            this.Hide();
            menuExtras.Show();
    }
    }
}

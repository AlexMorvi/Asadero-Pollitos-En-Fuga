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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void lblbnvnd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
           
            using(MenuCombos ventanaMenuCombos = new MenuCombos())
            ventanaMenuCombos.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_V1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            this.hora.Text = DateTime.Now.ToString("HH:mm:ss");
            this.data.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPLASH
{
    public partial class SPLASH : Form
    {
        public SPLASH()
        {
            InitializeComponent();
        }

        private void timeBar_Tick(object sender, EventArgs e)
        {
            // se incrementa el valor de la barra de carga 
            barraCarga.Increment(1);

            // verificamos si llega a 100 y  paramos el timer 
            if(barraCarga.Value == 100)
            {
                timeBar.Stop();
            }
        }

        private void SPLASH_Load(object sender, EventArgs e)
        {

        }
    }
}

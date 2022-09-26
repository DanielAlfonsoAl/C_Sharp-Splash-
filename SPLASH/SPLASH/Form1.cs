using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SPLASH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // creamos un Hilo
                                     //metodo que arranca el Hilo
            Thread hilo = new Thread(new ThreadStart(SplashStart));

            // Arrancamos el Hilo
            hilo.Start();

            //Aca se pone todo lo que se tiene que inicializar 
            Thread.Sleep(6000);

            InitializeComponent();

            //Abortamos el Hilo
            hilo.Abort();
        }

        public void SplashStart()
        {
            // se arranca la  instancia de form splash
            Application.Run(new SPLASH());
        }
    }
}

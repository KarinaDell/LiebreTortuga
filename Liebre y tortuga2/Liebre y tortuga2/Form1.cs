using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liebre_y_tortuga2
{
    public partial class Form1 : Form
    {

        Tortuga tortuga = new Tortuga();
        Liebre liebre = new Liebre();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            liebre = new Liebre();
            tortuga = new Tortuga();
            txtPista.Clear();
            carrera();
            ganador();

        }

        public void ganador()
        {
            if (tortuga.Avance >= 80 && liebre.Avance >= 80)
                txtPista.Text += "Empate";
            else if (tortuga.Avance >= 80)
                txtPista.Text += "Ganó la tortuga";
            else
                txtPista.Text += "Ganó la liebre";
        }

        public void carrera()
        {
            txtPista.Text += "Tortuga" + tortuga.mostrar() + "Liebre" + liebre.mostrar() + Environment.NewLine;
            while(tortuga.Avance < 80 && liebre.Avance < 80)
            {
                liebre.avanceLiebre();
                tortuga.avanceTortuga();
                txtPista.Text += "Tortuga " + tortuga.mostrar();
                txtPista.Text += "Liebre" + liebre.mostrar();

            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot__PARCIAL2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            r.Show();
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            Retirar re = new Retirar();
            re.Show();
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            Registros reg = new Registros();
            reg.Show();
        }
    }
}

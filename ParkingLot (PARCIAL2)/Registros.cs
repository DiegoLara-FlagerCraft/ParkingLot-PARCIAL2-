using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParkingLot__PARCIAL2_
{
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
            TextReader Leer = new StreamReader("BasedeDatosParkingLot.txt");
            RichTxtBoxRegistros.Text = (Leer.ReadToEnd());
            Leer.Close();
        }

        private void BtnVolver2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

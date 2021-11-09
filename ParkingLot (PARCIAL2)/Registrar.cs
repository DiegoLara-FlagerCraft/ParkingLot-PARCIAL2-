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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBorrarDatos_Click(object sender, EventArgs e)
        {
            TxtBoxPlacaV.Clear();
            TxtBoxMarcaV.Clear();
            TxtBoxNumI.Clear();
        }

        private void BtnRegistrarV_Click(object sender, EventArgs e)
        {

            Vehiculo v = new Vehiculo();
            Conductor c = new Conductor();
            v.Tipo = ComBoxTipoV.Text;
            v.Placa = TxtBoxPlacaV.Text;
            v.Marca = TxtBoxMarcaV.Text;

            c.Identidicacion = TxtBoxNumI.Text;
            c.Sexo = ComBoxSexo.Text;
            c.Afiliado = ComBoxAfiliacion.Text;

            RichTxtBoxRegistros.Text += ("REGISTRO \n" + "Tipo de Vehículo: " + v.Tipo + "\n" + "Placa del Vehículo: " + v.Placa + "\n" + "Marca del Vehículo: " + v.Marca + "\n"
                + "Nombre del Conductor: " + TxtBoxNombreC.Text + "\n" + "Identificación del Conductor: " + c.Identidicacion + "\n" + "Sexo del Conductor: " + c.Sexo + "\n" + "Afiliación: " + c.Afiliado + "\n"
                + "------------------------------------------------------------------ \n");


            TextWriter RegistaraVe = new StreamWriter("BasedeDatosParkingLot.txt");
            RegistaraVe.WriteLine(RichTxtBoxRegistros.Text);
            RegistaraVe.Close();

            MessageBox.Show("Vehículo Registrado");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}

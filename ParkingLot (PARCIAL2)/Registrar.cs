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
        int Contador = 10;
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
            LugarParqueadero p = new LugarParqueadero();
            Vehiculo v = new Vehiculo();
            Conductor c = new Conductor();
            v.Tipo = ComBoxTipoV.Text;
            v.Placa = TxtBoxPlacaV.Text;
            v.Marca = TxtBoxMarcaV.Text;

            c.Identidicacion = TxtBoxNumI.Text;
            c.Sexo = ComBoxSexo.Text;
            c.Afiliado = ComBoxAfiliacion.Text;

            p.Fecha = LblFecha.Text;
            p.Hora = LblHora.Text;


            if (Contador > 0)
                RichTxtBoxRegistros.Text += ("REGISTRO \n" + "Tipo de Vehículo: " + v.Tipo + "\n" + "Placa del Vehículo: " + v.Placa + "\n" + "Marca del Vehículo: " + v.Marca + "\n"
                    + "Nombre del Conductor: " + TxtBoxNombreC.Text + "\n" + "Identificación del Conductor: " + c.Identidicacion + "\n" + "Sexo del Conductor: " + c.Sexo + "\n" + "Afiliación: " + c.Afiliado + "\n"
                    + "Fecha: " + p.Fecha + "\n" + "Hora: " + p.Hora + "\n" + "------------------------------------------------------------------ \n");
            if (Contador > 0)
                Contador = Contador - 1;
            if (Contador > 0)
                MessageBox.Show("Vehículo Registrado");
            if (Contador > 0)
                BtnRegistrarV.Visible = true;

            if (Contador <= 0)
                BtnRegistrarV.Visible = false;
            if (Contador > 0)
                BtnRetirarV.Visible = true;
            if (Contador <= 0)
                MessageBox.Show("NO SE PUEDEN AGREGAR MAS VEHICULOS PORQUE EL PARQUEADERO ESTA LLENO");
                

            TextWriter RegistaraVe = new StreamWriter("BasedeDatosParkingLot.txt");
            RegistaraVe.WriteLine(RichTxtBoxRegistros.Text);
            RegistaraVe.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnRetirarV_Click(object sender, EventArgs e)
        {
            LugarParqueadero p = new LugarParqueadero();
            Vehiculo v = new Vehiculo();
            Conductor c = new Conductor();
            v.Tipo = ComBoxTipoV.Text;
            v.Placa = TxtBoxPlacaV.Text;
            v.Marca = TxtBoxMarcaV.Text;

            c.Identidicacion = TxtBoxNumI.Text;
            c.Sexo = ComBoxSexo.Text;
            c.Afiliado = ComBoxAfiliacion.Text;

            p.Fecha = LblFecha.Text;
            p.Hora = LblHora.Text;
            if (Contador < 10)
                RichTxtBoxRegistros.Text += ("RETIRO \n" + "Tipo de Vehículo: " + v.Tipo + "\n" + "Placa del Vehículo: " + v.Placa + "\n" + "Marca del Vehículo: " + v.Marca + "\n"
                    + "Nombre del Conductor: " + TxtBoxNombreC.Text + "\n" + "Identificación del Conductor: " + c.Identidicacion + "\n" + "Sexo del Conductor: " + c.Sexo + "\n" + "Afiliación: " + c.Afiliado + "\n"
                    + "Fecha: " + p.Fecha + "\n" + "Hora: " + p.Hora + "\n" + "------------------------------------------------------------------ \n");

            if (Contador < 10)
                MessageBox.Show("VEHÍCULO RETIRADO");

            TextWriter RegistaraVe = new StreamWriter("BasedeDatosParkingLot.txt");
            RegistaraVe.WriteLine(RichTxtBoxRegistros.Text);
            RegistaraVe.Close();

            Contador = Contador + 1;
            if (Contador > 0)
                BtnRegistrarV.Visible = true;
            if (Contador >= 10)
                BtnRetirarV.Visible = false;
            if (Contador >= 10)
                MessageBox.Show("NO SE PUEDEN RETIRAR MAS VEHICULOS PORQUE EL PARQUEADERO ESTA VACIO");
        }
    }
}

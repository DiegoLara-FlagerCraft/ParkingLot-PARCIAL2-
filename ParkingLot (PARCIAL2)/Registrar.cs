﻿using System;
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
    }
}

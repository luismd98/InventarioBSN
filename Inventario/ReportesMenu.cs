﻿using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ReportesMenu : Form
    {
        public ReportesMenu()
        {
            InitializeComponent();
        }

        private void BtnConsolidar_Click(object sender, EventArgs e)
        {
            Reportes nuevoReporte = new Reportes();

            if (rbTarjetasConteo.Checked == true)               //Reporte 1
                nuevoReporte.ExpTarjetasConteos();
            else if (rbConsolidadoConteo.Checked == true)       //Reporte 2
                nuevoReporte.ExpConsolidadoNart();
            else if (rbDiferencia.Checked == true)              //Reporte 3
                nuevoReporte.ExpConteoVsCierre();
            else if (rbNartDigitados.Checked == true)           //Reporte 4
                nuevoReporte.ExpNoDigitados(1);
            else if (rbFotoCierre.Checked == true)              //Reporte 5
                nuevoReporte.ExpNoDigitados(2);
            else if (rbTotalConteoFoto.Checked == true)         //Reporte 6
                nuevoReporte.ReporteTotales();
            else if (rbFaltante.Checked == true)                //Reporte 7
                nuevoReporte.ExpTarjetasConteoFaltante();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new MainMenu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void BtnConteo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDisenoLavadero
{
    public partial class frmLavados : Form
    {
        string[] patentes = new string[100];
        string[] servicios = new string[100];
        string[] entregas = new string[100];
        double[] totales = new double[100];
        int cant = 0;
        double recaudacion = 0;

        public frmLavados()
        {
            InitializeComponent();
        }

        private void frmLavados_Load(object sender, EventArgs e)
        {
            cmboservicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbovehiculos.DropDownStyle = ComboBoxStyle.DropDownList;

            cmboservicio.Items.Add("Lavado exterior");
            cmboservicio.Items.Add("Lavado completo");
            cmboservicio.Items.Add("Lavado con encerado");

            for (int i = 1; i <= 5; i++)
                cmbovehiculos.Items.Add(i);

            cmboservicio.SelectedIndex = 0;
            cmbovehiculos.SelectedIndex = 0;
            chknormal.Checked = true;
        }

        private void chknormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chknormal.Checked) chkexpress.Checked = false;
        }

        private void chkexpress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkexpress.Checked) chknormal.Checked = false;
        }

        bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtcliente.Text) ||
                string.IsNullOrWhiteSpace(txtpatente.Text) ||
                cmboservicio.SelectedIndex == -1 ||
                cmbovehiculos.SelectedIndex == -1 ||
                (!chknormal.Checked && !chkexpress.Checked))
            {
                MessageBox.Show("Por favor, completá todos los datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        double Calcular()
        {
            int precio = 0;
            if (cmboservicio.Text == "Lavado exterior") precio = 8000;
            if (cmboservicio.Text == "Lavado completo") precio = 14000;
            if (cmboservicio.Text == "Lavado con encerado") precio = 20000;

            int vehiculos = Convert.ToInt32(cmbovehiculos.Text);
            double sub = precio * vehiculos;

            double rec = 0;
            if (chkexpress.Checked) rec = sub * 0.25;

            double pDesc = 0;
            if (vehiculos == 2 || vehiculos == 3) pDesc = 0.10;
            if (vehiculos == 4 || vehiculos == 5) pDesc = 0.15;
            if (chkcliente.Checked) pDesc = pDesc + 0.05;

            double desc = sub * pDesc;
            double total = sub + rec - desc;

            txtsubtotal.Text = "$ " + sub.ToString("N0");
            txtrecargo.Text = "$ " + rec.ToString("N0");
            txtdescuento.Text = "$ " + desc.ToString("N0");
            txttotalpagar.Text = "$ " + total.ToString("N0");

            return total;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            Calcular();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            double total = Calcular();

            patentes[cant] = txtpatente.Text.Trim().ToUpper();
            servicios[cant] = cmboservicio.Text;
            entregas[cant] = chkexpress.Checked ? "Express" : "Normal";
            totales[cant] = total;
            cant++;

            recaudacion = recaudacion + total;

            txtlavadosdia.Text = cant.ToString();
            txtrecaudacion.Text = "$ " + recaudacion.ToString("N0");

            MessageBox.Show("Lavado registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcliente.Clear();
            txtpatente.Clear();
            cmboservicio.SelectedIndex = 0;
            cmbovehiculos.SelectedIndex = 0;
            chknormal.Checked = true;
            chkexpress.Checked = false;
            chkcliente.Checked = false;
            txtsubtotal.Clear();
            txtrecargo.Clear();
            txtdescuento.Clear();
            txttotalpagar.Clear();
        }

        private void cmboservicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryCadoppiSP2EjercicioResolver
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cboTipoBoleto.Items.Add("Estandar");
            cboTipoBoleto.Items.Add("Premium");
            cboTipoBoleto.Items.Add("Ultra");

            cboTipoBoleto.DropDownStyle = ComboBoxStyle.DropDownList;

            opCorta.Checked = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Complete el código.", "Carga Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Focus();
                txtCodigo.BackColor = Color.Green;
            }
            else
            {
                if (cboTipoBoleto.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un tipo de boleto.", "Carga Datos", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    cboTipoBoleto.Focus();
                    cboTipoBoleto.BackColor = Color.Green;

                }
                else
                {
                    //Sirve para crear archivos
                    //Deja manipularlo

                    StreamWriter archivo;
                    archivo = new StreamWriter("RegistroBoletos.txt");

                    archivo.WriteLine("Código: " + txtCodigo.Text + 
                        " Tipo Boleto: " + cboTipoBoleto.Text);

                    archivo.Close();

                    MessageBox.Show("Registramos su boleto.", "Registro de Boleto", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 ) 
            {
                e.Handled = true;
            }
        }
    }
}

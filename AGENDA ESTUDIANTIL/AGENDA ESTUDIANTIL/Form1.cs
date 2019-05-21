using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AGENDA_ESTUDIANTIL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int indice = 0;
        
        string genero;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF.Checked)
            {
                genero = chkF.Text;
                chk1M.Enabled = false;
            }
            else
            {
                chk1M.Enabled = true;
            }
        }

        private void tbDatosPersonales_Click(object sender, EventArgs e)
        {
            indice = 0;
            tbAgendaE.SelectTab(indice);
        }

        private void chk1M_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1M.Checked)
            {
                genero = chk1M.Text;
                chkF.Enabled = false;
            }
            else
            {
                chkF.Enabled = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice = 1;
            tbAgendaE.SelectTab(indice);
        }

        private void cbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCedula.SelectedIndex == 0)
            {
                label4.Text = "Cedula Ecu.:";
                cbNacionalid.Enabled = false;
                txtCedula.Enabled = true;
                cbNacionalid.SelectedIndex = -1;
            }
            if (cbCedula.SelectedIndex == 1)
            {
                label4.Text = "id. Pasaport:";
                txtCedula.MaxLength = 15;
                txtCedula.Enabled = true;
                cbNacionalid.Enabled = true;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") // Verificar Nombre 
            {
                errorProvider1.SetError(txtNombre,"Ingrese su nombre");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, null);
            }

            if (txtApellido.Text == "") // Verificar Apellido 
            {
                errorProvider1.SetError(txtApellido, "Ingrese su Apellido");
                txtApellido.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellido, null);
            }

            if (txtDireccion.Text == "") // Verificar direccion 
            {
                errorProvider1.SetError(txtDireccion, "Ingrese Direccion de su domicilio");
                txtDireccion.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtDireccion, null);
            }

            if (txtTelef.Text == "") // Verificar Telefono 
            {
                errorProvider1.SetError(txtTelef, "Ingrese su Telefono");
                txtTelef.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtTelef, null);
            }

            if (txtCedula.Text == "") // Verificar Cedula 
            {
                errorProvider1.SetError(txtCedula, "Eliga el Tipo de Cedula");
                txtCedula.Focus();
                return;
            }
            int ced;
            int.TryParse(txtCedula.Text, out ced); // Intento convertir de TXT a INT ced
            int primdig;
            primdig = ced / 100000000;
            switch (primdig)
            {
                case 1:
                    MessageBox.Show("Pertenece a la Provincia del Azuay");
                    break;
                case 2:
                    MessageBox.Show("Pertenece a la Provincia del Bolivar");
                    break;
                case 3:
                    MessageBox.Show("Pertenece a la Provincia del Cañar");
                    break;
                case 4:
                    MessageBox.Show("Pertenece a la Provincia del Carchi");
                    break;
                case 5:
                    MessageBox.Show("Pertenece a la Provincia del Cotopaxi");
                    break;
                case 6:
                    MessageBox.Show("Pertenece a la Provincia del Chimborazo");
                    break;
                case 7:
                    MessageBox.Show("Pertenece a la Provincia del El Oro");
                    break;
                case 8:
                    MessageBox.Show("Pertenece a la Provincia del Esmeraldas");
                    break;
                case 9:
                    MessageBox.Show("Pertenece a la Provincia del Guayas");
                    break;
                case 10:
                    MessageBox.Show("Pertenece a la Provincia del Imbabura");
                    break;
                case 11:
                    MessageBox.Show("Pertenece a la Provincia del Loja");
                    break;
                case 12:
                    MessageBox.Show("Pertenece a la Provincia del Los Rios");
                    break;
                case 13:
                    MessageBox.Show("Pertenece a la Provincia del Manabi");
                    break;
                case 14:
                    MessageBox.Show("Pertenece a la Provincia del Morona Santiago");
                    break;
                case 15:
                    MessageBox.Show("Pertenece a la Provincia del Napo");
                    break;
                case 16:
                    MessageBox.Show("Pertenece a la Provincia del Pastaza");
                    break;
                case 17:
                    MessageBox.Show("Pertenece a la Provincia del Pichincha");
                    break;
                case 18:
                    MessageBox.Show("Pertenece a la Provincia del Tungurahua");
                    break;
                case 19:
                    MessageBox.Show("Pertenece a la Provincia del Zamora Chinchipe");
                    break;
                case 20:
                    MessageBox.Show("Pertenece a la Provincia del Galapagos");
                    break;
                case 21:
                    MessageBox.Show("Pertenece a la Provincia del Sucumbios");
                    break;
                case 22:
                    MessageBox.Show("Pertenece a la Provincia del Orellana");
                    break;
                case 23:
                    MessageBox.Show("Pertenece a la Provincia del Santo Domingo");
                    break;
                case 24:
                    MessageBox.Show("Pertenece a la Provincia del Santa Elena");
                    break;
                case 30:
                    MessageBox.Show("Usted es un Ecuatoriano registrado en el Exterior.");
                    break;
                default:
                    MessageBox.Show("No es Ecuatoriano/a.");
                    break;

            }
            errorProvider1.SetError(txtCedula, null);
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtCedula.TextLength > 0)
            {
                cbCedula.Enabled = false;
            }
            else
            {
                cbCedula.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
        }
        private void LIMPIAR()
        {
            foreach (Control txt in this.tbDatosPersonales.Controls) // Sirve para realizar una funcion especificando a cual deseo hacerle la accion
            {
                if (txt is TextBox)
                {
                    txt.Text = " ";
                }
            }

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos;
            pos = dgv1.CurrentRow.Index;
            txtNombre.Text = dgv1[1, pos].Value.ToString();
            txtApellido.Text = dgv1[2, pos].Value.ToString();
            txtCedula.Text = dgv1[3, pos].Value.ToString();
            cbNacionalid.Text = dgv1[4, pos].Value.ToString();
            txtEdad.Text = dgv1[5, pos].Value.ToString();
            genero = dgv1[6, pos].Value.ToString();
            cbSangre.Text = dgv1[7, pos].Value.ToString();
            txtDireccion.Text = dgv1[8, pos].Value.ToString();
            txtTelef.Text = dgv1[9, pos].Value.ToString();
        }

        private void GUARDAR()
        {
            string nomb, ape, cedul, nacionaldd, edad, gener, sangre, dir, telef;
            nomb = txtNombre.Text;
            ape = txtApellido.Text;
            cedul = txtCedula.Text;
            nacionaldd = cbNacionalid.Text;
            edad = txtEdad.Text;
            gener = genero;
            sangre = cbSangre.Text;
            dir = txtDireccion.Text;
            telef = txtTelef.Text;
            dgv1.Rows.Add(nomb, ape, cedul, nacionaldd, edad, gener, sangre, dir, telef);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GUARDAR();
            LIMPIAR();
        }
    }
}

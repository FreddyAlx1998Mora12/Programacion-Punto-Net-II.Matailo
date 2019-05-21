using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BARRADEESTADO
{
    struct Agenda
    {
        string cedula;
        string nombre;
        string direccion;
        string telefono;
        string correo;

        public Agenda(string ced, string nom, string dir, string telef, string corr)
        {
            cedula = ced;
            nombre = nom;
            direccion = dir;
            telefono = telef;
            correo = corr;
        }

        public void setnombre(string nom) // SET PARA GUARDAR EL DATO
        {
            nombre = nom;
        }
        public string getnombre() // GET PARA SACAR EL DATO
        {
            return nombre;
        }

        public void setced(string ced)
        {
            cedula = ced;
        }
        public string getced()
        {
            return cedula;
        }

        public void setdireccion(string dir)
        {
            direccion = dir;
        }
        public string getdireccion()
        {
            return direccion;
        }

        public void settelefono(string telef)
        {
            telefono = telef;
        }
        public string gettelef()
        {
            return telefono;
        }

        public void setcorreo(string cor)
        {
            correo = cor;
        }
        public string getcorreo()
        {
            return correo;
        }
    }
    public partial class Form1 : Form
    {
        int indice = 0;
        Agenda[] contactos = new Agenda[100];
        int pos = 0; // Va a ser el valor del vector donde constan los elementos de AGENDA[], dentro de esta estructura estan los cinco elementos personales.
        int pe = 0;
        string estado = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsl2.Text += DateTime.Now.ToString(); 
        }

        private void tsm1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollador", "Profesion");
        }

        private void tsl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Personales");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tcDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tcDatos.SelectTab(indice);
        }

        private void ingresoAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indice = 1;
            tcDatos.SelectTab(indice);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            indice = 0;
            tcDatos.SelectTab(indice);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indice = 0;
            tcDatos.SelectTab(indice);
        }

        private void ingresoBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indice = 2;
            tcDatos.SelectTab(indice);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            indice = 1;
            tcDatos.SelectTab(indice);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            indice = 2;
            tcDatos.SelectTab(indice);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            indice = 1;
            tcDatos.SelectTab(indice);
            estado = "N";
            LIMPIAR();
        }

        private void btnGuardr_Click(object sender, EventArgs e)
        {
            if (estado == "N")
            {
                llenaestructura(pos);
                pos++;
                lstAgenda.Items.Add(txtCed.Text + " , " + txtNombr.Text);
                estado = " ";
            }
            if (estado == "E")
            {
                llenaestructura(pe);
                lstAgenda.Items.Insert(pe, txtCed.Text + " , " + txtNombr.Text);
                estado = " ";
                lstAgenda.Items.RemoveAt(pe + 1);
            }
            indice = 2;
            tcDatos.SelectTab(indice);
        }

        // Metodo Llenar estructura
        private void llenaestructura(int i)
        {
            contactos[i].setced(txtCed.Text);
            contactos[i].setnombre(txtNombr.Text);
            contactos[i].setdireccion(txtDir.Text);
            contactos[i].setcorreo(txtCorr.Text);
            contactos[i].settelefono(txtTelef.Text);
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            indice = 0;
            tcDatos.SelectTab(indice);
            LIMPIAR();
            btnRegreso.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAgenda.SelectedIndex >= 0)
            {
                pe = lstAgenda.SelectedIndex;
                txtCed.Text = contactos[pe].getced();
                txtNombr.Text = contactos[pe].getnombre();
                txtDir.Text = contactos[pe].getdireccion();
                txtCorr.Text = contactos[pe].getcorreo();
                txtTelef.Text = contactos[pe].gettelef();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            indice = 1;
            tcDatos.SelectTab(indice);
            estado = "E";
        }
        private void LIMPIAR()
        {
            foreach (Control txt in this.panel2.Controls) // Sirve para realizar una funcion especificando a cual deseo hacerle la accion
            {
                if (txt is TextBox)
                {
                    txt.Text = " ";
                }
            }
            foreach (Control txt in this.panel3.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Text = " ";
                }
            }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (txtPrim.TextLength > 0 || txtBach.TextLength > 0 || txtTitBach.TextLength > 0)
            {
                btnRegreso.Enabled = true;
            }
        }

        private void btnCancelr_Click(object sender, EventArgs e)
        {
            if (pos == 0)
            {
                indice = 0;
                tcDatos.SelectTab(indice);
            }
            if (pos > 0)
            {
                pos--;
                indice = 0;
                tcDatos.SelectTab(indice);
            }
        }
    }
}

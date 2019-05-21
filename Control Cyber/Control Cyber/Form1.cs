using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Cyber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables globales 
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Metodo para llenado 
        private void LLenado(TextBox Estado, TextBox TiempoUs, TextBox TiempTot, TextBox TiempFalt, TextBox ValorCobrar, Timer Cobro, Timer P)
        {
            if (nudHor.Value > 0 && nudMin.Value > 0) 
            {
                Estado.Text = txtOcupado.Text;
                TiempTot.Text = nudHor.Value +" : "+nudMin.Value;
                P.Start();
                //Reloj(P,TiempoUs);
                
            }
            if (nudHor.Value == 0 && nudMin.Value == 0) 
            {
                Estado.Text = TxtLibre.Text;
            }
        }
        // Metodo Inicia tiempo para cada PC
        private void Reloj(Timer Pc, TextBox TiempoUso)
        {
            int hh = 0, mm = 0, ss = 0, dd = 0;
            Pc.Start();
            string h, m, s;
            dd++;
            if (dd == 10)
            {
                dd = 0;
                ss++;
                if (ss == 60) 
                {
                    mm++;
                    ss = 0;
                }
                if (mm==60)
                {
                    hh++;
                    mm = 0;
                }
            }
            if (hh < 10) h = "0" + Convert.ToString(hh);
            else h = Convert.ToString(hh);
            if (mm < 10) m = "0" + Convert.ToString(mm);
            else m = Convert.ToString(mm);
            if (ss < 10) s = "0" + Convert.ToString(ss);
            else s = Convert.ToString(ss);

            TiempoUso.Text = h + ":" + m + ":" + s + "." + Convert.ToString(dd);
        }

        private void btnPc1_Click(object sender, EventArgs e)
        {
            LLenado(txtEs1, txtTiemUs1, txtTiemTot1, txtTiemFal1, txtVlrCob1, Pc1, Pc1);
            nudHor.Value = 0;
            nudMin.Value = 0;
        }

        private void Pc1_Tick(object sender, EventArgs e)
        {
            Reloj(Pc1, txtTiemUs1);
        }

        private void btnPc2_Click(object sender, EventArgs e)
        {
            LLenado(txtEs2, txtTiemUs2, txtTiemTot2, txtTiemFal2, txtVlrCob2, Pc2, Pc2);
            nudHor.Value = 0;
            nudMin.Value = 0;
        }

        private void btnPc3_Click(object sender, EventArgs e)
        {
            LLenado(txtEs3, txtTiemUs3, txtTiemTot3, txtTiemFal3, txtVlrCob3, Pc3, Pc3);
            nudHor.Value = 0;
            nudMin.Value = 0;
        }

        private void btnPc4_Click(object sender, EventArgs e)
        {
            LLenado(txtEs4, txtTiemUs4, txtTiemTot4, txtTiemFal4, txtVlrCob4, Pc4, Pc4);
            nudHor.Value = 0;
            nudMin.Value = 0;
        }

        private void btnPc5_Click(object sender, EventArgs e)
        {
            LLenado(txtEs5, txtTiemUs5, txtTiemTot5, txtTiemFal5, txtVlrCob5, Pc5, Pc5);
            nudHor.Value = 0;
            nudMin.Value = 0;
        }

        private void btnPc6_Click(object sender, EventArgs e)
        {
            LLenado(txtEs6, txtTiemUs6, txtTiemTot6, txtTiemFal6, txtVlrCob6, Pc6, Pc6);
            nudHor.Value = 0;
            nudMin.Value = 0;
        }

        private void Pc2_Tick(object sender, EventArgs e)
        {
            Reloj(Pc2, txtTiemUs2);
        }

        private void Pc3_Tick(object sender, EventArgs e)
        {
            Reloj(Pc3, txtTiemUs3);
        }

        private void Pc4_Tick(object sender, EventArgs e)
        {
            Reloj(Pc4, txtTiemUs4);
        }

        private void Pc5_Tick(object sender, EventArgs e)
        {
            Reloj(Pc5, txtTiemUs5);
        }

        private void Pc6_Tick(object sender, EventArgs e)
        {
            Reloj(Pc6, txtTiemUs6);
        }
    }
}

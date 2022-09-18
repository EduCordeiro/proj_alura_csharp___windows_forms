﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_alura_csharp___windows_forms
{
    public partial class frm_ValidaCPF : Form
    {
        public frm_ValidaCPF()
        {
            InitializeComponent();
        }



        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCpf = false;

            validaCpf = cls_Uteis.Valida(Msk_CPF.Text);

            if(validaCpf == true)
            {
                Lbl_Resultado.Text = "Cpf válido";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "Cpf inválido";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }
    }
}

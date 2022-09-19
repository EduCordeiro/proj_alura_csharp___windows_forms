using System;
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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_DemostracaoKey_Click(object sender, EventArgs e)
        {
            frm_DemonstracaoKey f = new frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            frm_HelloWorld f = new frm_HelloWorld();
            f.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            frm_Mascara f = new frm_Mascara();
            f.ShowDialog();

        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF f = new frm_ValidaCPF();
            f.ShowDialog();
        }

        private void Btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF2 f = new frm_ValidaCPF2();
            f.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            frm_ValidaSenha f = new frm_ValidaSenha();
            f.ShowDialog();
        }
    }
}

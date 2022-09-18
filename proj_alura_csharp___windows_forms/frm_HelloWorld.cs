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
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }


        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {

            lbl_Titulo.Text = "Label modificado";

        }
    }
}

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
    public partial class frm_ValidaCPF2 : Form
    {
        public frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {            
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {

            string vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Trim();

            if(vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um cpf", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (MessageBox.Show("Você deseja relamente validar o cpf?", "Mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool validaCpf = false;

                validaCpf = cls_Uteis.Valida(Msk_CPF.Text);

                if (validaCpf == true)
                {
                    MessageBox.Show("Cpf válido", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cpf inválido", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

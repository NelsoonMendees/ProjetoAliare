using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAliare
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        //altera a mascara para cpf ou cnpj
        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            mskCpfCnpj.Mask = rbCPF.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
        }
    
    }
}

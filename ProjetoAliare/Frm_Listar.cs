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
    public partial class Frm_Listar : Form
    {
        public Frm_Listar ()
        {
            InitializeComponent();
        }

        //altera a mascara para CPF
        private void rbCPF_CheckedChanged (object sender, EventArgs e)
        {
            mskConsulta.Mask = rbCPF.Checked ? @"000\.000\.000\-00" : @"00\.000\.000\/0000\-00";
        }

        //altera a mascara para CNPJ
        private void rbCNPJ_CheckedChanged (object sender, EventArgs e)
        {
            mskConsulta.Mask = rbCNPJ.Checked ? @"00\.000\.000\/0000\-00" : @"000\.000\.000\-00";
        }
    }
}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAliare
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro ()
        {
            InitializeComponent();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        //altera a mascara para cpf ou cnpj
        private void rbCPF_CheckedChanged (object sender, EventArgs e)
        {
            mskCpfCnpj.Text = "";
            if (rbCPF.Checked && mskCpfCnpj.Enabled == false)
            {
                mskCpfCnpj.Mask = "000,000,000-00";
                mskCpfCnpj.Enabled = true;
            }
            else
            {
                mskCpfCnpj.Enabled = false;
            }
        }
        private void rbCNPJ_CheckedChanged (object sender, EventArgs e)
        {
            mskCpfCnpj.Text = "";

            if (rbCNPJ.Checked && mskCpfCnpj.Enabled == false)
            {
                mskCpfCnpj.Mask = "00,000,000/0000-00";
                mskCpfCnpj.Enabled = true;
            }
            else
            {
                mskCpfCnpj.Enabled = false;
            }

        }

        //
        private void mskCep_Leave (object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(mskCep.Text))
            {
                MessageBox.Show("Informe um CEP valido!", this.Text, MessageBoxButtons.OK);
            }
            else
            {
                string strURL = string.Format("https://viacep.com.br/ws/{0}/json/", mskCep.Text.Trim());

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = client.GetAsync(strURL).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            var result = response.Content.ReadAsStringAsync().Result;
                            cls_ConsultaCep res = JsonConvert.DeserializeObject<cls_ConsultaCep>(result);

                            txtLogradouro.Text = res.Logradouro;
                            txtComplemento.Text = res.Complemento;
                            txtCidade.Text = res.Localidade;
                            txtEstado.Text = res.Estado;
                            txtBairro.Text = res.Bairro;

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void mskCpfCnpj_Leave (object sender, EventArgs e)
        {

            string conteudoCPF;
            conteudoCPF = mskCpfCnpj.Text;
            conteudoCPF = conteudoCPF.Replace(".", "").Replace("-", "");
            conteudoCPF = conteudoCPF.Trim();

            string conteudoCNPJ = mskCpfCnpj.Text;
            conteudoCNPJ = conteudoCNPJ.Replace(".", "");
            conteudoCNPJ = conteudoCNPJ.Replace("/", "");
            conteudoCNPJ = conteudoCNPJ.Replace("-", "");
            conteudoCNPJ = conteudoCNPJ.Trim();

            if (rbCPF.Checked)
            {
             
                //if(conteudo == "")
                //{
                //    MessageBox.Show("Por Favor, inserir os dados corretamente!", "CPF Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                if (conteudoCPF.Length != 11)
                {
                    MessageBox.Show("CPF deve conter 11 digitos!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool validaCPF = false;
                    validaCPF = cls_Valida.ValidaCPF(mskCpfCnpj.Text);
                    if (validaCPF == true)
                    {
                        lblConsulta.Text = "CPF Válido!";
                        lblConsulta.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblConsulta.Text = "CPF Inválido!";
                        lblConsulta.ForeColor = Color.Red;
                    }
                }
                //}

            }
            if (rbCNPJ.Checked)
            {
          

                if (conteudoCNPJ.Length != 14)
                {
                    MessageBox.Show("CNPJ deve conter 14 digitos!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                bool validaCNPJ = false;

                validaCNPJ = cls_Valida.ValidaCNPJ(mskCpfCnpj.Text);
                if (validaCNPJ == true)
                {
                    lblConsulta.Text = "CNPJ Válido!";
                    lblConsulta.ForeColor = Color.Green;
                }
                else
                {
                    lblConsulta.Text = "CNPJ Inválido!";
                    lblConsulta.ForeColor = Color.Red;
                }
            }

        }

        private void btnCancelar_Click (object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLimpar_Click (object sender, EventArgs e)
        {
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtNome.Text = "";
            txtLogradouro.Text = "";
            mskCep.Text = "";
            mskCpfCnpj.Text = "";
            lblConsulta.Text = "";


        }


    }
}

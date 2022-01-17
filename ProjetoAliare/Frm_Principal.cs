namespace ProjetoAliare
{
    public partial class Frm_Principal : Form
    {
        private Form frmAtivo;


        public Frm_Principal()
        {
            InitializeComponent();
        }

        //Metodo para mostrar o formulario no painel central
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            paneCentral.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if(frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in paneMenu.Controls) //executa conjunto de comandos
            ctrl.ForeColor = Color.White; //altera a cor da letra do button nao ativo
            frmAtivo.ForeColor = Color.Red; // altera a cor da letra do button ativo
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ActiveButton(btnCadastro);
           FormShow(new Frm_Cadastro());
            lblTitulo.Text = "Cadastro";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
            lblTitulo.Text = "Menu Principal";
        }
    }
}
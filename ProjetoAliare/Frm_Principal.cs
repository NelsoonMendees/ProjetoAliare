namespace ProjetoAliare
{
    public partial class Frm_Principal : Form
    {
        private Form frmAtivo;

        //Codigo para habilitar o arraste da janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage (IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture ();

        public Frm_Principal ()
        {
            InitializeComponent();
        }


        //Metodo para mostrar o formulario no painel central
        private void FormShow (Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            paneCentral.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose ()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void ActiveButton (Button frmAtivo)
        {
            foreach (Control ctrl in paneMenu.Controls) //executa conjunto de comandos
                ctrl.ForeColor = Color.White; //altera a cor da letra do button nao ativo
            frmAtivo.ForeColor = Color.Red; // altera a cor da letra do button ativo
        }

        private void btnCadastro_Click (object sender, EventArgs e)
        {
            ActiveButton(btnCadastro);
            FormShow(new Frm_Cadastro());
            lblTitulo.Text = "Cadastro";
            //atalho F1
        }

        private void btnHome_Click (object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
            lblTitulo.Text = "Menu Principal";
            //atalho ESC
        }

        private void btnConsulta_Click (object sender, EventArgs e)
        {
            ActiveButton(btnConsulta);
            FormShow(new Frm_Listar());
            lblTitulo.Text = "Consultar";
            //atalho F2
        }

        private void Frm_Principal_KeyDown (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                ActiveButton(btnHome);
                ActiveFormClose();
                lblTitulo.Text = "Menu Principal";
                break;

                case Keys.F1:
                ActiveButton(btnCadastro);
                FormShow(new Frm_Cadastro());
                lblTitulo.Text = "Cadastro";
                break;

                case Keys.F2:
                ActiveButton(btnConsulta);
                FormShow(new Frm_Listar());
                lblTitulo.Text = "Consultar";
                break;

            }
        }

        //fecha a aplicação
        private void btnClose_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }


        //miniminiza a janela
        private void btnMinimize_Click (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //habilita o painel superior para arrastar com o click do mouse
        private void paneTitulo_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
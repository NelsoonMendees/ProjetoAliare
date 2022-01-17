namespace ProjetoAliare
{
    partial class Frm_Listar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Listar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.mskConsulta = new System.Windows.Forms.MaskedTextBox();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.CPFCNPJ,
            this.Logradouro,
            this.Numero,
            this.Complemento,
            this.CEP,
            this.Bairro,
            this.Estado,
            this.Cidade});
            this.dataGridView1.Location = new System.Drawing.Point(47, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(813, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.HeaderText = "CPF / CNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            // 
            // Logradouro
            // 
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Complemento
            // 
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(203, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Location = new System.Drawing.Point(716, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 33);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeletar.Location = new System.Drawing.Point(566, 384);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(144, 33);
            this.btnDeletar.TabIndex = 19;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(68)))), ((int)(((byte)(83)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnEditar.Location = new System.Drawing.Point(416, 384);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(144, 33);
            this.BtnEditar.TabIndex = 20;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // mskConsulta
            // 
            this.mskConsulta.Location = new System.Drawing.Point(47, 40);
            this.mskConsulta.Name = "mskConsulta";
            this.mskConsulta.Size = new System.Drawing.Size(153, 23);
            this.mskConsulta.TabIndex = 21;
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCNPJ.Location = new System.Drawing.Point(141, 15);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(52, 19);
            this.rbCNPJ.TabIndex = 23;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.rbCNPJ_CheckedChanged);
            // 
            // rbCPF
            // 
            this.rbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCPF.Location = new System.Drawing.Point(47, 15);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(45, 19);
            this.rbCPF.TabIndex = 22;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // Frm_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(903, 429);
            this.Controls.Add(this.rbCNPJ);
            this.Controls.Add(this.rbCPF);
            this.Controls.Add(this.mskConsulta);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Listar";
            this.Text = "Frm_Listar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnDeletar;
        private Button BtnEditar;
        private MaskedTextBox mskConsulta;
        private RadioButton rbCNPJ;
        private RadioButton rbCPF;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPFCNPJ;
        private DataGridViewTextBoxColumn Logradouro;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Cidade;
    }
}
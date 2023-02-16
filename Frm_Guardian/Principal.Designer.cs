namespace Frm_Guardian
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btn_instalar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nome_servico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nome_executavel = new System.Windows.Forms.Label();
            this.Mnu_principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_opcao_importar = new System.Windows.Forms.ToolStripMenuItem();
            this.Ofd_importar = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.Mnu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_instalar
            // 
            this.btn_instalar.BackColor = System.Drawing.Color.Green;
            this.btn_instalar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_instalar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_instalar.Image = global::Frm_Guardian.Properties.Resources.icons8_salvar_30;
            this.btn_instalar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_instalar.Location = new System.Drawing.Point(289, 181);
            this.btn_instalar.Name = "btn_instalar";
            this.btn_instalar.Size = new System.Drawing.Size(89, 48);
            this.btn_instalar.TabIndex = 1;
            this.btn_instalar.Text = "Salvar ";
            this.btn_instalar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_instalar.UseVisualStyleBackColor = false;
            this.btn_instalar.Click += new System.EventHandler(this.btn_instalar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho do Executável:";
            // 
            // lbl_nome_servico
            // 
            this.lbl_nome_servico.Location = new System.Drawing.Point(128, 167);
            this.lbl_nome_servico.Name = "lbl_nome_servico";
            this.lbl_nome_servico.PlaceholderText = "Guardian Teste";
            this.lbl_nome_servico.Size = new System.Drawing.Size(326, 23);
            this.lbl_nome_servico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(128, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Serviço:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nome_executavel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_instalar);
            this.groupBox1.Location = new System.Drawing.Point(76, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 248);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração";
            // 
            // lbl_nome_executavel
            // 
            this.lbl_nome_executavel.AutoSize = true;
            this.lbl_nome_executavel.ForeColor = System.Drawing.Color.Red;
            this.lbl_nome_executavel.Location = new System.Drawing.Point(52, 74);
            this.lbl_nome_executavel.Name = "lbl_nome_executavel";
            this.lbl_nome_executavel.Size = new System.Drawing.Size(96, 15);
            this.lbl_nome_executavel.TabIndex = 0;
            this.lbl_nome_executavel.Text = "Não Selecionado";
            // 
            // Mnu_principal
            // 
            this.Mnu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.Mnu_principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_principal.Name = "Mnu_principal";
            this.Mnu_principal.Size = new System.Drawing.Size(784, 24);
            this.Mnu_principal.TabIndex = 6;
            this.Mnu_principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_opcao_importar});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // Mnu_opcao_importar
            // 
            this.Mnu_opcao_importar.Image = ((System.Drawing.Image)(resources.GetObject("Mnu_opcao_importar.Image")));
            this.Mnu_opcao_importar.Name = "Mnu_opcao_importar";
            this.Mnu_opcao_importar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.Mnu_opcao_importar.Size = new System.Drawing.Size(166, 22);
            this.Mnu_opcao_importar.Text = "Importar";
            this.Mnu_opcao_importar.Click += new System.EventHandler(this.Mnu_opcao_importar_Click);
            // 
            // Ofd_importar
            // 
            this.Ofd_importar.FileName = "openFileDialog1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nome_servico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Mnu_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Mnu_principal;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 360);
            this.MinimumSize = new System.Drawing.Size(800, 360);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardian";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Mnu_principal.ResumeLayout(false);
            this.Mnu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_instalar;
        private Label label1;
        private TextBox lbl_nome_servico;
        private Label label2;
        private GroupBox groupBox1;
        private MenuStrip Mnu_principal;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem Mnu_opcao_importar;
        private OpenFileDialog Ofd_importar;
        private Label lbl_nome_executavel;
    }
}
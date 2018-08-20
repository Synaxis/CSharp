namespace WindowsFormsApp3 {
    partial class frmAtiv2 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblUni = new System.Windows.Forms.Label();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluirTd = new System.Windows.Forms.Button();
            this.lstUni = new System.Windows.Forms.ListBox();
            this.txtUni = new System.Windows.Forms.TextBox();
            this.btnIncluirUni = new System.Windows.Forms.Button();
            this.btnExcluirUni = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(19, 24);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso:";
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.Location = new System.Drawing.Point(19, 197);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(72, 13);
            this.lblUni.TabIndex = 1;
            this.lblUni.Text = "Universidade:";
            // 
            // lstCursos
            // 
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.Location = new System.Drawing.Point(206, 24);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(143, 95);
            this.lstCursos.TabIndex = 2;
            this.lstCursos.SelectedIndexChanged += new System.EventHandler(this.lstCursos_SelectedIndexChanged);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(22, 55);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(22, 99);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir Curso";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(22, 128);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 22);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir Curso";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lista de Universidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lista de Cursos:";
            // 
            // btnExcluirTd
            // 
            this.btnExcluirTd.Location = new System.Drawing.Point(193, 321);
            this.btnExcluirTd.Name = "btnExcluirTd";
            this.btnExcluirTd.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirTd.TabIndex = 8;
            this.btnExcluirTd.Text = "Excluir Tudo";
            this.btnExcluirTd.UseVisualStyleBackColor = true;
            this.btnExcluirTd.Click += new System.EventHandler(this.btnExcluirTd_Click);
            // 
            // lstUni
            // 
            this.lstUni.FormattingEnabled = true;
            this.lstUni.Location = new System.Drawing.Point(193, 220);
            this.lstUni.Name = "lstUni";
            this.lstUni.Size = new System.Drawing.Size(156, 95);
            this.lstUni.TabIndex = 9;
            this.lstUni.SelectedIndexChanged += new System.EventHandler(this.lstUni_SelectedIndexChanged);
            // 
            // txtUni
            // 
            this.txtUni.Location = new System.Drawing.Point(22, 213);
            this.txtUni.Name = "txtUni";
            this.txtUni.Size = new System.Drawing.Size(100, 20);
            this.txtUni.TabIndex = 10;
            // 
            // btnIncluirUni
            // 
            this.btnIncluirUni.Location = new System.Drawing.Point(22, 258);
            this.btnIncluirUni.Name = "btnIncluirUni";
            this.btnIncluirUni.Size = new System.Drawing.Size(113, 23);
            this.btnIncluirUni.TabIndex = 11;
            this.btnIncluirUni.Text = "Incluir Universidade";
            this.btnIncluirUni.UseVisualStyleBackColor = true;
            this.btnIncluirUni.Click += new System.EventHandler(this.btnIncluirUni_Click);
            // 
            // btnExcluirUni
            // 
            this.btnExcluirUni.Location = new System.Drawing.Point(22, 288);
            this.btnExcluirUni.Name = "btnExcluirUni";
            this.btnExcluirUni.Size = new System.Drawing.Size(113, 23);
            this.btnExcluirUni.TabIndex = 12;
            this.btnExcluirUni.Text = "Excluir Universidade";
            this.btnExcluirUni.UseVisualStyleBackColor = true;
            this.btnExcluirUni.Click += new System.EventHandler(this.btnExcluirUni_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(274, 321);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmAtiv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 356);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluirUni);
            this.Controls.Add(this.btnIncluirUni);
            this.Controls.Add(this.txtUni);
            this.Controls.Add(this.lstUni);
            this.Controls.Add(this.btnExcluirTd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lstCursos);
            this.Controls.Add(this.lblUni);
            this.Controls.Add(this.lblCurso);
            this.Name = "frmAtiv2";
            this.Text = "Ensino Superior";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblUni;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluirTd;
        private System.Windows.Forms.ListBox lstUni;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.Button btnIncluirUni;
        private System.Windows.Forms.Button btnExcluirUni;
        private System.Windows.Forms.Button btnSair;
    }
}


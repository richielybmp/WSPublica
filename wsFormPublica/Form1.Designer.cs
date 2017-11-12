namespace wsFormPublica
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_usuario = new MetroFramework.Controls.MetroLabel();
            this.lb_senha = new MetroFramework.Controls.MetroLabel();
            this.btn_entrar = new MetroFramework.Controls.MetroButton();
            this.tb_usuario = new MetroFramework.Controls.MetroTextBox();
            this.tb_senha = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(35, 90);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(53, 19);
            this.lb_usuario.TabIndex = 0;
            this.lb_usuario.Text = "Usuário";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(35, 127);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(44, 19);
            this.lb_senha.TabIndex = 1;
            this.lb_senha.Text = "Senha";
            // 
            // btn_entrar
            // 
            this.btn_entrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_entrar.Location = new System.Drawing.Point(156, 171);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 2;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(94, 90);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(267, 23);
            this.tb_usuario.TabIndex = 3;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(94, 127);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(267, 23);
            this.tb_senha.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 217);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_usuario);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lb_usuario;
        private MetroFramework.Controls.MetroLabel lb_senha;
        private MetroFramework.Controls.MetroButton btn_entrar;
        private MetroFramework.Controls.MetroTextBox tb_usuario;
        private MetroFramework.Controls.MetroTextBox tb_senha;
    }
}


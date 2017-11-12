namespace wsFormPublica
{
    partial class Catálogo
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
            this.tabsCatalogo = new MetroFramework.Controls.MetroTabControl();
            this.tabConsultar = new MetroFramework.Controls.MetroTabPage();
            this.gridResultado = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.tbBuscar = new MetroFramework.Controls.MetroTextBox();
            this.lbBuscar = new MetroFramework.Controls.MetroLabel();
            this.tabIncluir = new MetroFramework.Controls.MetroTabPage();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnIncluir = new MetroFramework.Controls.MetroButton();
            this.tbEnderecoEletronico = new MetroFramework.Controls.MetroTextBox();
            this.tbEditor = new MetroFramework.Controls.MetroTextBox();
            this.tbPublicacao = new MetroFramework.Controls.MetroTextBox();
            this.tbPalavraChave = new MetroFramework.Controls.MetroTextBox();
            this.tbAutores = new MetroFramework.Controls.MetroTextBox();
            this.tbTitulo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbPalavraChave = new MetroFramework.Controls.MetroLabel();
            this.lbAutores = new MetroFramework.Controls.MetroLabel();
            this.lbTitulo = new MetroFramework.Controls.MetroLabel();
            this.tabsCatalogo.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            this.tabIncluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsCatalogo
            // 
            this.tabsCatalogo.Controls.Add(this.tabConsultar);
            this.tabsCatalogo.Controls.Add(this.tabIncluir);
            this.tabsCatalogo.Location = new System.Drawing.Point(24, 64);
            this.tabsCatalogo.Name = "tabsCatalogo";
            this.tabsCatalogo.SelectedIndex = 0;
            this.tabsCatalogo.Size = new System.Drawing.Size(968, 311);
            this.tabsCatalogo.TabIndex = 0;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.gridResultado);
            this.tabConsultar.Controls.Add(this.btnBuscar);
            this.tabConsultar.Controls.Add(this.tbBuscar);
            this.tabConsultar.Controls.Add(this.lbBuscar);
            this.tabConsultar.HorizontalScrollbarBarColor = true;
            this.tabConsultar.Location = new System.Drawing.Point(4, 25);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Size = new System.Drawing.Size(960, 282);
            this.tabConsultar.TabIndex = 0;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.VerticalScrollbarBarColor = true;
            // 
            // gridResultado
            // 
            this.gridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultado.Location = new System.Drawing.Point(0, 55);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.Size = new System.Drawing.Size(962, 224);
            this.gridResultado.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(572, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(54, 16);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(512, 23);
            this.tbBuscar.TabIndex = 3;
            this.tbBuscar.Text = " ";
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(-1, 16);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(47, 19);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Buscar";
            // 
            // tabIncluir
            // 
            this.tabIncluir.Controls.Add(this.btnCancelar);
            this.tabIncluir.Controls.Add(this.btnIncluir);
            this.tabIncluir.Controls.Add(this.tbEnderecoEletronico);
            this.tabIncluir.Controls.Add(this.tbEditor);
            this.tabIncluir.Controls.Add(this.tbPublicacao);
            this.tabIncluir.Controls.Add(this.tbPalavraChave);
            this.tabIncluir.Controls.Add(this.tbAutores);
            this.tabIncluir.Controls.Add(this.tbTitulo);
            this.tabIncluir.Controls.Add(this.metroLabel6);
            this.tabIncluir.Controls.Add(this.metroLabel5);
            this.tabIncluir.Controls.Add(this.metroLabel4);
            this.tabIncluir.Controls.Add(this.lbPalavraChave);
            this.tabIncluir.Controls.Add(this.lbAutores);
            this.tabIncluir.Controls.Add(this.lbTitulo);
            this.tabIncluir.HorizontalScrollbarBarColor = true;
            this.tabIncluir.Location = new System.Drawing.Point(4, 25);
            this.tabIncluir.Name = "tabIncluir";
            this.tabIncluir.Size = new System.Drawing.Size(960, 282);
            this.tabIncluir.TabIndex = 1;
            this.tabIncluir.Text = "Incluir";
            this.tabIncluir.VerticalScrollbarBarColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(882, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(801, 256);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 26;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // tbEnderecoEletronico
            // 
            this.tbEnderecoEletronico.Location = new System.Drawing.Point(165, 204);
            this.tbEnderecoEletronico.Name = "tbEnderecoEletronico";
            this.tbEnderecoEletronico.Size = new System.Drawing.Size(792, 23);
            this.tbEnderecoEletronico.TabIndex = 25;
            // 
            // tbEditor
            // 
            this.tbEditor.Location = new System.Drawing.Point(165, 175);
            this.tbEditor.Name = "tbEditor";
            this.tbEditor.Size = new System.Drawing.Size(792, 23);
            this.tbEditor.TabIndex = 24;
            // 
            // tbPublicacao
            // 
            this.tbPublicacao.Location = new System.Drawing.Point(165, 146);
            this.tbPublicacao.Name = "tbPublicacao";
            this.tbPublicacao.Size = new System.Drawing.Size(792, 23);
            this.tbPublicacao.TabIndex = 23;
            // 
            // tbPalavraChave
            // 
            this.tbPalavraChave.Location = new System.Drawing.Point(164, 117);
            this.tbPalavraChave.Name = "tbPalavraChave";
            this.tbPalavraChave.Size = new System.Drawing.Size(793, 23);
            this.tbPalavraChave.TabIndex = 22;
            // 
            // tbAutores
            // 
            this.tbAutores.Location = new System.Drawing.Point(164, 43);
            this.tbAutores.Name = "tbAutores";
            this.tbAutores.Size = new System.Drawing.Size(793, 68);
            this.tbAutores.TabIndex = 21;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(164, 14);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(793, 23);
            this.tbTitulo.TabIndex = 20;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 204);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(126, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Endereço eletrônico";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 175);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Editor";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 146);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Publicação";
            // 
            // lbPalavraChave
            // 
            this.lbPalavraChave.AutoSize = true;
            this.lbPalavraChave.Location = new System.Drawing.Point(14, 117);
            this.lbPalavraChave.Name = "lbPalavraChave";
            this.lbPalavraChave.Size = new System.Drawing.Size(88, 19);
            this.lbPalavraChave.TabIndex = 16;
            this.lbPalavraChave.Text = "Palavra chave";
            // 
            // lbAutores
            // 
            this.lbAutores.AutoSize = true;
            this.lbAutores.Location = new System.Drawing.Point(14, 43);
            this.lbAutores.Name = "lbAutores";
            this.lbAutores.Size = new System.Drawing.Size(54, 19);
            this.lbAutores.TabIndex = 15;
            this.lbAutores.Text = "Autores";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(14, 14);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(41, 19);
            this.lbTitulo.TabIndex = 14;
            this.lbTitulo.Text = "Titulo";
            // 
            // Catálogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 398);
            this.Controls.Add(this.tabsCatalogo);
            this.Name = "Catálogo";
            this.Text = "Catálogo";
            this.tabsCatalogo.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            this.tabIncluir.ResumeLayout(false);
            this.tabIncluir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabsCatalogo;
        private MetroFramework.Controls.MetroTabPage tabConsultar;
        private System.Windows.Forms.DataGridView gridResultado;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox tbBuscar;
        private MetroFramework.Controls.MetroLabel lbBuscar;
        private MetroFramework.Controls.MetroTabPage tabIncluir;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnIncluir;
        private MetroFramework.Controls.MetroTextBox tbEnderecoEletronico;
        private MetroFramework.Controls.MetroTextBox tbEditor;
        private MetroFramework.Controls.MetroTextBox tbPublicacao;
        private MetroFramework.Controls.MetroTextBox tbPalavraChave;
        private MetroFramework.Controls.MetroTextBox tbAutores;
        private MetroFramework.Controls.MetroTextBox tbTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbPalavraChave;
        private MetroFramework.Controls.MetroLabel lbAutores;
        private MetroFramework.Controls.MetroLabel lbTitulo;
    }
}
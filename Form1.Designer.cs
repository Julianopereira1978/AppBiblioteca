
namespace AppBiblioteca
{
    partial class FormBiblioteca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbSinopse = new System.Windows.Forms.TextBox();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbEdicao = new System.Windows.Forms.TextBox();
            this.tbEmprestado = new System.Windows.Forms.TextBox();
            this.tbEmprPara = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgbiblioteca_pessoal = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSinopse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmprestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmprPara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbiblioteca_pessoal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sinopse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Emprestado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Emprestado Para";
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(109, 9);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(100, 20);
            this.tbnome.TabIndex = 8;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(109, 38);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(100, 20);
            this.tbGenero.TabIndex = 9;
            // 
            // tbSinopse
            // 
            this.tbSinopse.Location = new System.Drawing.Point(109, 75);
            this.tbSinopse.Name = "tbSinopse";
            this.tbSinopse.Size = new System.Drawing.Size(100, 20);
            this.tbSinopse.TabIndex = 10;
            // 
            // tbEditora
            // 
            this.tbEditora.Location = new System.Drawing.Point(109, 106);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(100, 20);
            this.tbEditora.TabIndex = 11;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(109, 145);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(100, 20);
            this.tbAutor.TabIndex = 12;
            // 
            // tbEdicao
            // 
            this.tbEdicao.Location = new System.Drawing.Point(109, 185);
            this.tbEdicao.Name = "tbEdicao";
            this.tbEdicao.Size = new System.Drawing.Size(100, 20);
            this.tbEdicao.TabIndex = 13;
            // 
            // tbEmprestado
            // 
            this.tbEmprestado.Location = new System.Drawing.Point(109, 223);
            this.tbEmprestado.Name = "tbEmprestado";
            this.tbEmprestado.Size = new System.Drawing.Size(100, 20);
            this.tbEmprestado.TabIndex = 14;
            // 
            // tbEmprPara
            // 
            this.tbEmprPara.Location = new System.Drawing.Point(109, 262);
            this.tbEmprPara.Name = "tbEmprPara";
            this.tbEmprPara.Size = new System.Drawing.Size(100, 20);
            this.tbEmprPara.TabIndex = 15;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(1049, 288);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 16;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgbiblioteca_pessoal
            // 
            this.dgbiblioteca_pessoal.AllowUserToOrderColumns = true;
            this.dgbiblioteca_pessoal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbiblioteca_pessoal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.ColNome,
            this.ColGenero,
            this.ColSinopse,
            this.ColEditora,
            this.ColAutor,
            this.ColEdicao,
            this.ColEmprestado,
            this.ColEmprPara});
            this.dgbiblioteca_pessoal.Location = new System.Drawing.Point(215, 9);
            this.dgbiblioteca_pessoal.Name = "dgbiblioteca_pessoal";
            this.dgbiblioteca_pessoal.Size = new System.Drawing.Size(1029, 273);
            this.dgbiblioteca_pessoal.TabIndex = 17;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.Width = 150;
            // 
            // ColGenero
            // 
            this.ColGenero.HeaderText = "Genero";
            this.ColGenero.Name = "ColGenero";
            this.ColGenero.Width = 45;
            // 
            // ColSinopse
            // 
            this.ColSinopse.HeaderText = "Sinopse";
            this.ColSinopse.Name = "ColSinopse";
            this.ColSinopse.Width = 300;
            // 
            // ColEditora
            // 
            this.ColEditora.HeaderText = "Editora";
            this.ColEditora.Name = "ColEditora";
            // 
            // ColAutor
            // 
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.Name = "ColAutor";
            // 
            // ColEdicao
            // 
            this.ColEdicao.HeaderText = "Edição";
            this.ColEdicao.Name = "ColEdicao";
            this.ColEdicao.Width = 45;
            // 
            // ColEmprestado
            // 
            this.ColEmprestado.HeaderText = "Emprestado";
            this.ColEmprestado.Name = "ColEmprestado";
            this.ColEmprestado.Width = 65;
            // 
            // ColEmprPara
            // 
            this.ColEmprPara.HeaderText = "Emprestado Para";
            this.ColEmprPara.Name = "ColEmprPara";
            this.ColEmprPara.Width = 150;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(1148, 288);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 18;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FormBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 319);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.dgbiblioteca_pessoal);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbEmprPara);
            this.Controls.Add(this.tbEmprestado);
            this.Controls.Add(this.tbEdicao);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbEditora);
            this.Controls.Add(this.tbSinopse);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBiblioteca";
            this.Text = "Biblioteca Pessoal";
            this.Load += new System.EventHandler(this.FormBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbiblioteca_pessoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbSinopse;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbEdicao;
        private System.Windows.Forms.TextBox tbEmprestado;
        private System.Windows.Forms.TextBox tbEmprPara;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgbiblioteca_pessoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSinopse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmprestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmprPara;
        private System.Windows.Forms.Button btSalvar;
    }
}


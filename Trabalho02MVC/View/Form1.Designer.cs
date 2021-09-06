
namespace Trabalho02MVC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSair = new System.Windows.Forms.Button();
            this.txtInsira = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnGerarNovo = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.dgPontos = new System.Windows.Forms.DataGridView();
            this.PalavraCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PontosCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPontos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(513, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 40);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtInsira
            // 
            this.txtInsira.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsira.Location = new System.Drawing.Point(73, 251);
            this.txtInsira.Name = "txtInsira";
            this.txtInsira.Size = new System.Drawing.Size(245, 45);
            this.txtInsira.TabIndex = 11;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.Lime;
            this.btnExecutar.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(73, 325);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(245, 90);
            this.btnExecutar.TabIndex = 12;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnGerarNovo
            // 
            this.btnGerarNovo.BackColor = System.Drawing.Color.Black;
            this.btnGerarNovo.Font = new System.Drawing.Font("Times New Roman", 25F);
            this.btnGerarNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGerarNovo.Location = new System.Drawing.Point(343, 95);
            this.btnGerarNovo.Name = "btnGerarNovo";
            this.btnGerarNovo.Size = new System.Drawing.Size(247, 87);
            this.btnGerarNovo.TabIndex = 13;
            this.btnGerarNovo.Text = "Gerar Novo Tabuleiro";
            this.btnGerarNovo.UseVisualStyleBackColor = false;
            this.btnGerarNovo.Click += new System.EventHandler(this.btnGerarNovo_Click);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(73, 74);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(75, 40);
            this.btn00.TabIndex = 14;
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(154, 74);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 40);
            this.btn01.TabIndex = 15;
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(235, 74);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(83, 40);
            this.btn02.TabIndex = 16;
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(73, 120);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 40);
            this.btn10.TabIndex = 17;
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(154, 120);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 40);
            this.btn11.TabIndex = 18;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(235, 120);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(83, 39);
            this.btn12.TabIndex = 19;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(73, 166);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 39);
            this.btn20.TabIndex = 20;
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(154, 166);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(75, 39);
            this.btn21.TabIndex = 21;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(235, 166);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(83, 40);
            this.btn22.TabIndex = 22;
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(166, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Caça - Palavras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(120, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Insira uma palavra";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Location = new System.Drawing.Point(376, 264);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(0, 13);
            this.lblPontos.TabIndex = 25;
            // 
            // dgPontos
            // 
            this.dgPontos.AllowUserToAddRows = false;
            this.dgPontos.AllowUserToDeleteRows = false;
            this.dgPontos.AllowUserToOrderColumns = true;
            this.dgPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PalavraCol,
            this.PontosCol});
            this.dgPontos.Location = new System.Drawing.Point(343, 226);
            this.dgPontos.Name = "dgPontos";
            this.dgPontos.ReadOnly = true;
            this.dgPontos.Size = new System.Drawing.Size(247, 189);
            this.dgPontos.TabIndex = 26;
            // 
            // PalavraCol
            // 
            this.PalavraCol.HeaderText = "Palavra";
            this.PalavraCol.Name = "PalavraCol";
            this.PalavraCol.ReadOnly = true;
            this.PalavraCol.Width = 104;
            // 
            // PontosCol
            // 
            this.PontosCol.HeaderText = "Pontos";
            this.PontosCol.Name = "PontosCol";
            this.PontosCol.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.dgPontos);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btnGerarNovo);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtInsira);
            this.Controls.Add(this.btnSair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPontos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtInsira;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnGerarNovo;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.DataGridView dgPontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalavraCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PontosCol;
    }
}


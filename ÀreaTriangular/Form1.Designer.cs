namespace ÀreaTriangular
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
            this.lblarea = new System.Windows.Forms.Label();
            this.grboperacao = new System.Windows.Forms.GroupBox();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.grboperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(128, 30);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(121, 13);
            this.lblarea.TabIndex = 0;
            this.lblarea.Text = "AREA DO TRIANGULO";
            // 
            // grboperacao
            // 
            this.grboperacao.Controls.Add(this.lblaltura);
            this.grboperacao.Controls.Add(this.lblBase);
            this.grboperacao.Controls.Add(this.txtaltura);
            this.grboperacao.Controls.Add(this.txtbase);
            this.grboperacao.Location = new System.Drawing.Point(90, 70);
            this.grboperacao.Name = "grboperacao";
            this.grboperacao.Size = new System.Drawing.Size(200, 100);
            this.grboperacao.TabIndex = 1;
            this.grboperacao.TabStop = false;
            this.grboperacao.Text = "Operação:";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(41, 20);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 0;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(41, 47);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(0, 20);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(0, 50);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 3;
            this.lblaltura.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(93, 176);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(197, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(93, 206);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(32, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Area:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 275);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grboperacao);
            this.Controls.Add(this.lblarea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grboperacao.ResumeLayout(false);
            this.grboperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.GroupBox grboperacao;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblresultado;
    }
}


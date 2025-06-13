namespace projetoPizzaria
{
    partial class AdicionarFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeFunc = new System.Windows.Forms.TextBox();
            this.TxtSenhaFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericNivel = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Funcionario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel:";
            // 
            // TxtNomeFunc
            // 
            this.TxtNomeFunc.Location = new System.Drawing.Point(41, 187);
            this.TxtNomeFunc.Multiline = true;
            this.TxtNomeFunc.Name = "TxtNomeFunc";
            this.TxtNomeFunc.Size = new System.Drawing.Size(241, 25);
            this.TxtNomeFunc.TabIndex = 3;
            // 
            // TxtSenhaFunc
            // 
            this.TxtSenhaFunc.Location = new System.Drawing.Point(41, 285);
            this.TxtSenhaFunc.Multiline = true;
            this.TxtSenhaFunc.Name = "TxtSenhaFunc";
            this.TxtSenhaFunc.Size = new System.Drawing.Size(241, 25);
            this.TxtSenhaFunc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adicionar Funcionario";
            // 
            // NumericNivel
            // 
            this.NumericNivel.Location = new System.Drawing.Point(108, 350);
            this.NumericNivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericNivel.Name = "NumericNivel";
            this.NumericNivel.Size = new System.Drawing.Size(120, 20);
            this.NumericNivel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar Funcionario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdicionarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumericNivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSenhaFunc);
            this.Controls.Add(this.TxtNomeFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarFuncionario";
            this.Text = "AdicionarFuncionario";
            this.Load += new System.EventHandler(this.AdicionarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeFunc;
        private System.Windows.Forms.TextBox TxtSenhaFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericNivel;
        private System.Windows.Forms.Button button1;
    }
}
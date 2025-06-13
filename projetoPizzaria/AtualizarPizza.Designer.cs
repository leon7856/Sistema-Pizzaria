namespace projetoPizzaria
{
    partial class AtualizarPizza
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
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.txtNovoValor = new System.Windows.Forms.TextBox();
            this.btnAtualizar_Click = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Novo Valor:";
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Location = new System.Drawing.Point(148, 88);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(205, 20);
            this.txtNovoNome.TabIndex = 2;
            // 
            // txtNovoValor
            // 
            this.txtNovoValor.Location = new System.Drawing.Point(148, 163);
            this.txtNovoValor.Name = "txtNovoValor";
            this.txtNovoValor.Size = new System.Drawing.Size(205, 20);
            this.txtNovoValor.TabIndex = 3;
            // 
            // btnAtualizar_Click
            // 
            this.btnAtualizar_Click.Location = new System.Drawing.Point(28, 264);
            this.btnAtualizar_Click.Name = "btnAtualizar_Click";
            this.btnAtualizar_Click.Size = new System.Drawing.Size(159, 51);
            this.btnAtualizar_Click.TabIndex = 4;
            this.btnAtualizar_Click.Text = "Atualizar";
            this.btnAtualizar_Click.UseVisualStyleBackColor = true;
            this.btnAtualizar_Click.Click += new System.EventHandler(this.btnAtualizar_Click_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(148, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 20);
            this.txtID.TabIndex = 6;
            // 
            // AtualizarPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 357);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAtualizar_Click);
            this.Controls.Add(this.txtNovoValor);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AtualizarPizza";
            this.Text = "AtualizarPizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.TextBox txtNovoValor;
        private System.Windows.Forms.Button btnAtualizar_Click;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
    }
}
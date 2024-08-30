namespace Sesion4
{
    partial class Form1
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
            this.Salario = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAumento = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTecho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).BeginInit();
            this.SuspendLayout();
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.Location = new System.Drawing.Point(35, 71);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(72, 24);
            this.Salario.TabIndex = 0;
            this.Salario.Text = "Salario:";
            this.Salario.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(113, 71);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(322, 20);
            this.tbSalario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aumento:";
            // 
            // nudAumento
            // 
            this.nudAumento.Location = new System.Drawing.Point(113, 116);
            this.nudAumento.Name = "nudAumento";
            this.nudAumento.Size = new System.Drawing.Size(322, 20);
            this.nudAumento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Techo:";
            // 
            // tbTecho
            // 
            this.tbTecho.Location = new System.Drawing.Point(113, 158);
            this.tbTecho.Name = "tbTecho";
            this.tbTecho.Size = new System.Drawing.Size(321, 20);
            this.tbTecho.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 389);
            this.Controls.Add(this.tbTecho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.Salario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTecho;
    }
}


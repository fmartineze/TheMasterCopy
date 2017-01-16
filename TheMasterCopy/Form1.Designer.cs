namespace TheMasterCopy
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
            this.txt_origen = new System.Windows.Forms.TextBox();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.Copiar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_origen
            // 
            this.txt_origen.Location = new System.Drawing.Point(55, 37);
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.Size = new System.Drawing.Size(443, 20);
            this.txt_origen.TabIndex = 0;
            this.txt_origen.Text = "Origen";
            this.txt_origen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(55, 63);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(443, 20);
            this.txt_destino.TabIndex = 1;
            this.txt_destino.Text = "Destino";
            // 
            // Copiar
            // 
            this.Copiar.Location = new System.Drawing.Point(541, 37);
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(107, 46);
            this.Copiar.TabIndex = 2;
            this.Copiar.Text = "Copiar";
            this.Copiar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(593, 246);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 369);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Copiar);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.txt_origen);
            this.Name = "Form1";
            this.Text = "TheMasterCopy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_origen;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.Button Copiar;
        private System.Windows.Forms.TextBox textBox1;
    }
}


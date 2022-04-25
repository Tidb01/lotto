namespace SkandinavSzimulacio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelChBoxTarol = new System.Windows.Forms.Panel();
            this.btnSorsol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.tippeklista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelChBoxTarol
            // 
            this.panelChBoxTarol.BackColor = System.Drawing.Color.White;
            this.panelChBoxTarol.Location = new System.Drawing.Point(10, 9);
            this.panelChBoxTarol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChBoxTarol.Name = "panelChBoxTarol";
            this.panelChBoxTarol.Size = new System.Drawing.Size(387, 312);
            this.panelChBoxTarol.TabIndex = 0;
            // 
            // btnSorsol
            // 
            this.btnSorsol.Location = new System.Drawing.Point(403, 9);
            this.btnSorsol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSorsol.Name = "btnSorsol";
            this.btnSorsol.Size = new System.Drawing.Size(82, 22);
            this.btnSorsol.TabIndex = 1;
            this.btnSorsol.Text = "Sorsol";
            this.btnSorsol.UseVisualStyleBackColor = true;
            this.btnSorsol.Click += new System.EventHandler(this.btnSorsol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(403, 61);
            this.btnBezar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(82, 22);
            this.btnBezar.TabIndex = 2;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // tippeklista
            // 
            this.tippeklista.AutoSize = true;
            this.tippeklista.Location = new System.Drawing.Point(10, 279);
            this.tippeklista.Name = "tippeklista";
            this.tippeklista.Size = new System.Drawing.Size(0, 15);
            this.tippeklista.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 346);
            this.Controls.Add(this.tippeklista);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnSorsol);
            this.Controls.Add(this.panelChBoxTarol);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelChBoxTarol;
        private System.Windows.Forms.Button btnSorsol;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Label tippeklista;
    }
}

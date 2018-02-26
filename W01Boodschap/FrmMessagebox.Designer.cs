namespace W01Boodschap
{
    partial class FrmMessagebox
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
            this.btnVenster1 = new System.Windows.Forms.Button();
            this.btnVenster2 = new System.Windows.Forms.Button();
            this.btnVenster3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVenster1
            // 
            this.btnVenster1.Location = new System.Drawing.Point(56, 100);
            this.btnVenster1.Name = "btnVenster1";
            this.btnVenster1.Size = new System.Drawing.Size(100, 50);
            this.btnVenster1.TabIndex = 0;
            this.btnVenster1.Text = "Venster 1";
            this.btnVenster1.UseVisualStyleBackColor = true;
            this.btnVenster1.Click += new System.EventHandler(this.btnVenster1_Click);
            // 
            // btnVenster2
            // 
            this.btnVenster2.Location = new System.Drawing.Point(254, 100);
            this.btnVenster2.Name = "btnVenster2";
            this.btnVenster2.Size = new System.Drawing.Size(100, 50);
            this.btnVenster2.TabIndex = 1;
            this.btnVenster2.Text = "Venster 2";
            this.btnVenster2.UseVisualStyleBackColor = true;
            this.btnVenster2.Click += new System.EventHandler(this.btnVenster2_Click);
            // 
            // btnVenster3
            // 
            this.btnVenster3.Location = new System.Drawing.Point(475, 100);
            this.btnVenster3.Name = "btnVenster3";
            this.btnVenster3.Size = new System.Drawing.Size(100, 50);
            this.btnVenster3.TabIndex = 2;
            this.btnVenster3.Text = "Venster 3";
            this.btnVenster3.UseVisualStyleBackColor = true;
            this.btnVenster3.Click += new System.EventHandler(this.btnVenster3_Click);
            // 
            // FrmMessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 226);
            this.Controls.Add(this.btnVenster3);
            this.Controls.Add(this.btnVenster2);
            this.Controls.Add(this.btnVenster1);
            this.Name = "FrmMessagebox";
            this.Text = "FrmMessagebox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVenster1;
        private System.Windows.Forms.Button btnVenster2;
        private System.Windows.Forms.Button btnVenster3;
    }
}
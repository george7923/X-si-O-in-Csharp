namespace XsiO
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
            this.ButonStart = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Jucator1 = new System.Windows.Forms.TextBox();
            this.Jucator2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButonStart
            // 
            this.ButonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonStart.Location = new System.Drawing.Point(294, 319);
            this.ButonStart.Name = "ButonStart";
            this.ButonStart.Size = new System.Drawing.Size(155, 58);
            this.ButonStart.TabIndex = 0;
            this.ButonStart.Text = "START";
            this.ButonStart.UseVisualStyleBackColor = true;
            this.ButonStart.Click += new System.EventHandler(this.ButonStart_Click);
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.Color.Red;
            this.Player1.Location = new System.Drawing.Point(22, 64);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(132, 22);
            this.Player1.TabIndex = 1;
            this.Player1.Text = "Jucator 1 (X):";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.Color.DarkCyan;
            this.Player2.Location = new System.Drawing.Point(22, 101);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(134, 22);
            this.Player2.TabIndex = 2;
            this.Player2.Text = "Jucator 2 (O):";
            // 
            // Jucator1
            // 
            this.Jucator1.Location = new System.Drawing.Point(160, 64);
            this.Jucator1.Name = "Jucator1";
            this.Jucator1.Size = new System.Drawing.Size(165, 22);
            this.Jucator1.TabIndex = 3;
            // 
            // Jucator2
            // 
            this.Jucator2.Location = new System.Drawing.Point(162, 103);
            this.Jucator2.Name = "Jucator2";
            this.Jucator2.Size = new System.Drawing.Size(165, 22);
            this.Jucator2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Jucator2);
            this.Controls.Add(this.Jucator1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.ButonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButonStart;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.TextBox Jucator1;
        private System.Windows.Forms.TextBox Jucator2;
    }
}


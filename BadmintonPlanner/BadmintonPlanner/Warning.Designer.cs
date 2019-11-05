namespace BadmintonPlanner
{
    partial class Warning
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
            this.ConBut = new System.Windows.Forms.Button();
            this.CanBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConBut
            // 
            this.ConBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConBut.Location = new System.Drawing.Point(45, 312);
            this.ConBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConBut.Name = "ConBut";
            this.ConBut.Size = new System.Drawing.Size(165, 46);
            this.ConBut.TabIndex = 0;
            this.ConBut.Text = "Yes";
            this.ConBut.UseVisualStyleBackColor = true;
            this.ConBut.Click += new System.EventHandler(this.ConBut_Click);
            // 
            // CanBut
            // 
            this.CanBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanBut.Location = new System.Drawing.Point(219, 312);
            this.CanBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CanBut.Name = "CanBut";
            this.CanBut.Size = new System.Drawing.Size(165, 46);
            this.CanBut.TabIndex = 1;
            this.CanBut.Text = "No";
            this.CanBut.UseVisualStyleBackColor = true;
            this.CanBut.Click += new System.EventHandler(this.CanBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to continue?";
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CanBut);
            this.Controls.Add(this.ConBut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.Warning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConBut;
        private System.Windows.Forms.Button CanBut;
        private System.Windows.Forms.Label label1;
    }
}
namespace Demo
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
            this.btnRed = new System.Windows.Forms.Button();
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(12, 407);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(22, 23);
            this.btnRed.TabIndex = 0;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.BackColor = System.Drawing.Color.White;
            this.pnlDrawing.Location = new System.Drawing.Point(12, 12);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(778, 389);
            this.pnlDrawing.TabIndex = 1;
            this.pnlDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawing_MouseMove);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGreen.Location = new System.Drawing.Point(68, 407);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(22, 23);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(40, 407);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(22, 23);
            this.btnBlue.TabIndex = 3;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.AutoSize = true;
            this.lblSelectedColor.BackColor = System.Drawing.Color.Black;
            this.lblSelectedColor.Location = new System.Drawing.Point(116, 412);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(76, 13);
            this.lblSelectedColor.TabIndex = 4;
            this.lblSelectedColor.Text = "                       ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 431);
            this.Controls.Add(this.lblSelectedColor);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.pnlDrawing);
            this.Controls.Add(this.btnRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Panel pnlDrawing;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Label lblSelectedColor;
    }
}


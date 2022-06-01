
namespace KR_.Net_
{
    partial class CalculateMenu
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.textBox_dx = new System.Windows.Forms.TextBox();
            this.textBox_xmax = new System.Windows.Forms.TextBox();
            this.textBox_xmin = new System.Windows.Forms.TextBox();
            this.dx = new System.Windows.Forms.Label();
            this.xmax = new System.Windows.Forms.Label();
            this.xmin = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.FlatAppearance.BorderSize = 0;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(170, 150);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(140, 25);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // textBox_dx
            // 
            this.textBox_dx.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dx.Location = new System.Drawing.Point(10, 150);
            this.textBox_dx.Name = "textBox_dx";
            this.textBox_dx.Size = new System.Drawing.Size(60, 22);
            this.textBox_dx.TabIndex = 14;
            // 
            // textBox_xmax
            // 
            this.textBox_xmax.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_xmax.Location = new System.Drawing.Point(10, 110);
            this.textBox_xmax.Name = "textBox_xmax";
            this.textBox_xmax.Size = new System.Drawing.Size(60, 22);
            this.textBox_xmax.TabIndex = 13;
            // 
            // textBox_xmin
            // 
            this.textBox_xmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_xmin.Location = new System.Drawing.Point(10, 70);
            this.textBox_xmin.Name = "textBox_xmin";
            this.textBox_xmin.Size = new System.Drawing.Size(60, 22);
            this.textBox_xmin.TabIndex = 12;
            // 
            // dx
            // 
            this.dx.AutoSize = true;
            this.dx.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dx.Location = new System.Drawing.Point(90, 155);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(19, 15);
            this.dx.TabIndex = 11;
            this.dx.Text = "dx";
            // 
            // xmax
            // 
            this.xmax.AutoSize = true;
            this.xmax.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmax.Location = new System.Drawing.Point(90, 115);
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(32, 15);
            this.xmax.TabIndex = 10;
            this.xmax.Text = "xmax";
            // 
            // xmin
            // 
            this.xmin.AutoSize = true;
            this.xmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmin.Location = new System.Drawing.Point(90, 75);
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(31, 15);
            this.xmin.TabIndex = 9;
            this.xmin.Text = "xmin";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(10, 40);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(307, 19);
            this.text.TabIndex = 8;
            this.text.Text = "Enter xmin, xmax, dx, then press button calculate.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 25);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Location = new System.Drawing.Point(296, -1);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(26, 25);
            this.X.TabIndex = 17;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            this.X.MouseEnter += new System.EventHandler(this.X_MouseEnter);
            this.X.MouseLeave += new System.EventHandler(this.X_MouseLeave);
            // 
            // CalculateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.textBox_dx);
            this.Controls.Add(this.textBox_xmax);
            this.Controls.Add(this.textBox_xmin);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.xmax);
            this.Controls.Add(this.xmin);
            this.Controls.Add(this.text);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculateMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox textBox_dx;
        private System.Windows.Forms.TextBox textBox_xmax;
        private System.Windows.Forms.TextBox textBox_xmin;
        private System.Windows.Forms.Label dx;
        private System.Windows.Forms.Label xmax;
        private System.Windows.Forms.Label xmin;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button X;
    }
}
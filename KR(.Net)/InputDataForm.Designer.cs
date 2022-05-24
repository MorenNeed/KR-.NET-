
using System;

namespace KR_.Net_
{
    partial class InputDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDataForm));
            this.text = new System.Windows.Forms.Label();
            this.xmin = new System.Windows.Forms.Label();
            this.xmax = new System.Windows.Forms.Label();
            this.dx = new System.Windows.Forms.Label();
            this.textBox_xmin = new System.Windows.Forms.TextBox();
            this.textBox_xmax = new System.Windows.Forms.TextBox();
            this.textBox_dx = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.listBox_f1 = new System.Windows.Forms.ListBox();
            this.listBox_f2 = new System.Windows.Forms.ListBox();
            this.f1x = new System.Windows.Forms.Label();
            this.f2x = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Num_f1 = new System.Windows.Forms.Label();
            this.Num_f2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.def_f2 = new System.Windows.Forms.Label();
            this.def_f1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(5, 40);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(307, 19);
            this.text.TabIndex = 0;
            this.text.Text = "Enter xmin, xmax, dx, then press button calculate.";
            // 
            // xmin
            // 
            this.xmin.AutoSize = true;
            this.xmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmin.Location = new System.Drawing.Point(80, 80);
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(31, 15);
            this.xmin.TabIndex = 1;
            this.xmin.Text = "xmin";
            // 
            // xmax
            // 
            this.xmax.AutoSize = true;
            this.xmax.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmax.Location = new System.Drawing.Point(80, 120);
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(32, 15);
            this.xmax.TabIndex = 2;
            this.xmax.Text = "xmax";
            // 
            // dx
            // 
            this.dx.AutoSize = true;
            this.dx.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dx.Location = new System.Drawing.Point(80, 160);
            this.dx.Name = "dx";
            this.dx.Size = new System.Drawing.Size(19, 15);
            this.dx.TabIndex = 3;
            this.dx.Text = "dx";
            // 
            // textBox_xmin
            // 
            this.textBox_xmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_xmin.Location = new System.Drawing.Point(5, 80);
            this.textBox_xmin.Name = "textBox_xmin";
            this.textBox_xmin.Size = new System.Drawing.Size(60, 22);
            this.textBox_xmin.TabIndex = 4;
            // 
            // textBox_xmax
            // 
            this.textBox_xmax.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_xmax.Location = new System.Drawing.Point(5, 120);
            this.textBox_xmax.Name = "textBox_xmax";
            this.textBox_xmax.Size = new System.Drawing.Size(60, 22);
            this.textBox_xmax.TabIndex = 5;
            // 
            // textBox_dx
            // 
            this.textBox_dx.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dx.Location = new System.Drawing.Point(5, 160);
            this.textBox_dx.Name = "textBox_dx";
            this.textBox_dx.Size = new System.Drawing.Size(60, 22);
            this.textBox_dx.TabIndex = 6;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.FlatAppearance.BorderSize = 0;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(160, 160);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(140, 25);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // listBox_f1
            // 
            this.listBox_f1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_f1.FormattingEnabled = true;
            this.listBox_f1.ItemHeight = 15;
            this.listBox_f1.Location = new System.Drawing.Point(5, 300);
            this.listBox_f1.Name = "listBox_f1";
            this.listBox_f1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_f1.Size = new System.Drawing.Size(120, 94);
            this.listBox_f1.TabIndex = 8;
            // 
            // listBox_f2
            // 
            this.listBox_f2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_f2.FormattingEnabled = true;
            this.listBox_f2.ItemHeight = 15;
            this.listBox_f2.Location = new System.Drawing.Point(175, 300);
            this.listBox_f2.Name = "listBox_f2";
            this.listBox_f2.Size = new System.Drawing.Size(120, 94);
            this.listBox_f2.TabIndex = 9;
            // 
            // f1x
            // 
            this.f1x.AutoSize = true;
            this.f1x.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f1x.Location = new System.Drawing.Point(50, 285);
            this.f1x.Name = "f1x";
            this.f1x.Size = new System.Drawing.Size(30, 15);
            this.f1x.TabIndex = 10;
            this.f1x.Text = "f1(x)";
            // 
            // f2x
            // 
            this.f2x.AutoSize = true;
            this.f2x.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f2x.Location = new System.Drawing.Point(220, 285);
            this.f2x.Name = "f2x";
            this.f2x.Size = new System.Drawing.Size(30, 15);
            this.f2x.TabIndex = 11;
            this.f2x.Text = "f2(x)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KR_.Net_.Properties.Resources.image_of_student;
            this.pictureBox1.Location = new System.Drawing.Point(500, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Num_f1
            // 
            this.Num_f1.AutoSize = true;
            this.Num_f1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_f1.Location = new System.Drawing.Point(400, 300);
            this.Num_f1.Name = "Num_f1";
            this.Num_f1.Size = new System.Drawing.Size(179, 15);
            this.Num_f1.TabIndex = 13;
            this.Num_f1.Text = "Number of calculations of f1(x) : ";
            // 
            // Num_f2
            // 
            this.Num_f2.AutoSize = true;
            this.Num_f2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_f2.Location = new System.Drawing.Point(400, 340);
            this.Num_f2.Name = "Num_f2";
            this.Num_f2.Size = new System.Drawing.Size(179, 15);
            this.Num_f2.TabIndex = 14;
            this.Num_f2.Text = "Number of calculations of f2(x) : ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(500, 200);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(138, 15);
            this.name.TabIndex = 15;
            this.name.Text = "Рощупкін Олексій ІТ-02";
            // 
            // def_f2
            // 
            this.def_f2.AutoSize = true;
            this.def_f2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.def_f2.Location = new System.Drawing.Point(650, 340);
            this.def_f2.Name = "def_f2";
            this.def_f2.Size = new System.Drawing.Size(218, 15);
            this.def_f2.TabIndex = 17;
            this.def_f2.Text = "Number of defined expressions of f2(x) : ";
            // 
            // def_f1
            // 
            this.def_f1.AutoSize = true;
            this.def_f1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.def_f1.Location = new System.Drawing.Point(650, 300);
            this.def_f1.Name = "def_f1";
            this.def_f1.Size = new System.Drawing.Size(221, 15);
            this.def_f1.TabIndex = 16;
            this.def_f1.Text = "Number of defined expressions of f1(x) : ";
            // 
            // InputDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.def_f2);
            this.Controls.Add(this.def_f1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Num_f2);
            this.Controls.Add(this.Num_f1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.f2x);
            this.Controls.Add(this.f1x);
            this.Controls.Add(this.listBox_f2);
            this.Controls.Add(this.listBox_f1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.textBox_dx);
            this.Controls.Add(this.textBox_xmax);
            this.Controls.Add(this.textBox_xmin);
            this.Controls.Add(this.dx);
            this.Controls.Add(this.xmax);
            this.Controls.Add(this.xmin);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label xmin;
        private System.Windows.Forms.Label xmax;
        private System.Windows.Forms.Label dx;
        private System.Windows.Forms.TextBox textBox_xmin;
        private System.Windows.Forms.TextBox textBox_xmax;
        private System.Windows.Forms.TextBox textBox_dx;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ListBox listBox_f1;
        private System.Windows.Forms.ListBox listBox_f2;
        private System.Windows.Forms.Label f1x;
        private System.Windows.Forms.Label f2x;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Num_f1;
        private System.Windows.Forms.Label Num_f2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label def_f2;
        private System.Windows.Forms.Label def_f1;
    }
}
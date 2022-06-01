
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
            this.listBox_f1 = new System.Windows.Forms.ListBox();
            this.listBox_f2 = new System.Windows.Forms.ListBox();
            this.f1x = new System.Windows.Forms.Label();
            this.f2x = new System.Windows.Forms.Label();
            this.Num_f1 = new System.Windows.Forms.Label();
            this.Num_f2 = new System.Windows.Forms.Label();
            this.def_f2 = new System.Windows.Forms.Label();
            this.def_f1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_f1
            // 
            this.listBox_f1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_f1.FormattingEnabled = true;
            this.listBox_f1.ItemHeight = 15;
            this.listBox_f1.Location = new System.Drawing.Point(7, 40);
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
            this.listBox_f2.Location = new System.Drawing.Point(177, 40);
            this.listBox_f2.Name = "listBox_f2";
            this.listBox_f2.Size = new System.Drawing.Size(120, 94);
            this.listBox_f2.TabIndex = 9;
            // 
            // f1x
            // 
            this.f1x.AutoSize = true;
            this.f1x.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f1x.Location = new System.Drawing.Point(52, 25);
            this.f1x.Name = "f1x";
            this.f1x.Size = new System.Drawing.Size(30, 15);
            this.f1x.TabIndex = 10;
            this.f1x.Text = "f1(x)";
            // 
            // f2x
            // 
            this.f2x.AutoSize = true;
            this.f2x.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f2x.Location = new System.Drawing.Point(222, 25);
            this.f2x.Name = "f2x";
            this.f2x.Size = new System.Drawing.Size(30, 15);
            this.f2x.TabIndex = 11;
            this.f2x.Text = "f2(x)";
            // 
            // Num_f1
            // 
            this.Num_f1.AutoSize = true;
            this.Num_f1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_f1.Location = new System.Drawing.Point(4, 167);
            this.Num_f1.Name = "Num_f1";
            this.Num_f1.Size = new System.Drawing.Size(179, 15);
            this.Num_f1.TabIndex = 13;
            this.Num_f1.Text = "Number of calculations of f1(x) : ";
            // 
            // Num_f2
            // 
            this.Num_f2.AutoSize = true;
            this.Num_f2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_f2.Location = new System.Drawing.Point(4, 241);
            this.Num_f2.Name = "Num_f2";
            this.Num_f2.Size = new System.Drawing.Size(179, 15);
            this.Num_f2.TabIndex = 14;
            this.Num_f2.Text = "Number of calculations of f2(x) : ";
            // 
            // def_f2
            // 
            this.def_f2.AutoSize = true;
            this.def_f2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.def_f2.Location = new System.Drawing.Point(4, 281);
            this.def_f2.Name = "def_f2";
            this.def_f2.Size = new System.Drawing.Size(221, 15);
            this.def_f2.TabIndex = 17;
            this.def_f2.Text = "Number of defined expressions of f2(x) : ";
            // 
            // def_f1
            // 
            this.def_f1.AutoSize = true;
            this.def_f1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.def_f1.Location = new System.Drawing.Point(4, 199);
            this.def_f1.Name = "def_f1";
            this.def_f1.Size = new System.Drawing.Size(221, 15);
            this.def_f1.TabIndex = 16;
            this.def_f1.Text = "Number of defined expressions of f1(x) : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 25);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(339, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // InputDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.def_f2);
            this.Controls.Add(this.def_f1);
            this.Controls.Add(this.Num_f2);
            this.Controls.Add(this.Num_f1);
            this.Controls.Add(this.f2x);
            this.Controls.Add(this.f1x);
            this.Controls.Add(this.listBox_f2);
            this.Controls.Add(this.listBox_f1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox listBox_f1;
        public System.Windows.Forms.ListBox listBox_f2;
        public System.Windows.Forms.Label f1x;
        public System.Windows.Forms.Label f2x;
        public System.Windows.Forms.Label Num_f1;
        public System.Windows.Forms.Label Num_f2;
        public System.Windows.Forms.Label def_f2;
        public System.Windows.Forms.Label def_f1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
    }
}
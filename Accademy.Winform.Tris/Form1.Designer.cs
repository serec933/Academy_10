﻿using System.Windows.Forms;

namespace Accademy.Winform.Tris
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
            this.txt_00 = new System.Windows.Forms.TextBox();
            this.txt_01 = new System.Windows.Forms.TextBox();
            this.txt_02 = new System.Windows.Forms.TextBox();
            this.txt_12 = new System.Windows.Forms.TextBox();
            this.txt_11 = new System.Windows.Forms.TextBox();
            this.txt_10 = new System.Windows.Forms.TextBox();
            this.txt_22 = new System.Windows.Forms.TextBox();
            this.txt_21 = new System.Windows.Forms.TextBox();
            this.txt_20 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_00
            // 
            this.txt_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_00.Location = new System.Drawing.Point(142, 61);
            this.txt_00.Name = "txt_00";
            this.txt_00.Size = new System.Drawing.Size(47, 45);
            this.txt_00.TabIndex = 0;
            this.txt_00.TextChanged += new System.EventHandler(this.txt_00_TextChanged);
            this.txt_00.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_00_KeyDown);
            this.txt_00.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_00_KeyPress);
            // 
            // txt_01
            // 
            this.txt_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_01.Location = new System.Drawing.Point(225, 61);
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(47, 45);
            this.txt_01.TabIndex = 1;
            this.txt_01.TextChanged += new System.EventHandler(this.txt_01_TextChanged);
            this.txt_01.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_01_KeyDown);
            this.txt_01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_01_KeyPress);
            // 
            // txt_02
            // 
            this.txt_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_02.Location = new System.Drawing.Point(308, 61);
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(47, 45);
            this.txt_02.TabIndex = 2;
            this.txt_02.TextChanged += new System.EventHandler(this.txt_02_TextChanged);
            this.txt_02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_02_KeyDown);
            this.txt_02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_02_KeyPress);
            // 
            // txt_12
            // 
            this.txt_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_12.Location = new System.Drawing.Point(308, 135);
            this.txt_12.Name = "txt_12";
            this.txt_12.Size = new System.Drawing.Size(47, 45);
            this.txt_12.TabIndex = 5;
            this.txt_12.TextChanged += new System.EventHandler(this.txt_12_TextChanged);
            this.txt_12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_12_KeyDown);
            this.txt_12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_12_KeyPress);
            // 
            // txt_11
            // 
            this.txt_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_11.Location = new System.Drawing.Point(225, 135);
            this.txt_11.Name = "txt_11";
            this.txt_11.Size = new System.Drawing.Size(47, 45);
            this.txt_11.TabIndex = 4;
            this.txt_11.TextChanged += new System.EventHandler(this.txt_11_TextChanged);
            this.txt_11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_11_KeyDown);
            this.txt_11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_11_KeyPress);
            // 
            // txt_10
            // 
            this.txt_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_10.Location = new System.Drawing.Point(142, 135);
            this.txt_10.Name = "txt_10";
            this.txt_10.Size = new System.Drawing.Size(47, 45);
            this.txt_10.TabIndex = 3;
            this.txt_10.TextChanged += new System.EventHandler(this.txt_10_TextChanged);
            this.txt_10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_10_KeyDown);
            this.txt_10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_10_KeyPress);
            // 
            // txt_22
            // 
            this.txt_22.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_22.Location = new System.Drawing.Point(308, 214);
            this.txt_22.Name = "txt_22";
            this.txt_22.Size = new System.Drawing.Size(47, 45);
            this.txt_22.TabIndex = 8;
            this.txt_22.TextChanged += new System.EventHandler(this.txt_22_TextChanged);
            this.txt_22.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_22_KeyDown);
            this.txt_22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_22_KeyPress);
            // 
            // txt_21
            // 
            this.txt_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_21.Location = new System.Drawing.Point(225, 214);
            this.txt_21.Name = "txt_21";
            this.txt_21.Size = new System.Drawing.Size(47, 45);
            this.txt_21.TabIndex = 7;
            this.txt_21.TextChanged += new System.EventHandler(this.txt_21_TextChanged);
            this.txt_21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_21_KeyDown);
            this.txt_21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_21_KeyPress);
            // 
            // txt_20
            // 
            this.txt_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_20.Location = new System.Drawing.Point(142, 214);
            this.txt_20.Name = "txt_20";
            this.txt_20.Size = new System.Drawing.Size(47, 45);
            this.txt_20.TabIndex = 6;
            this.txt_20.TextChanged += new System.EventHandler(this.txt_20_TextChanged);
            this.txt_20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_20_KeyDown);
            this.txt_20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_20_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(483, 337);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 31);
            this.lbl_error.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(142, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 11;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_22);
            this.Controls.Add(this.txt_21);
            this.Controls.Add(this.txt_20);
            this.Controls.Add(this.txt_12);
            this.Controls.Add(this.txt_11);
            this.Controls.Add(this.txt_10);
            this.Controls.Add(this.txt_02);
            this.Controls.Add(this.txt_01);
            this.Controls.Add(this.txt_00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_00;
        private System.Windows.Forms.TextBox txt_01;
        private System.Windows.Forms.TextBox txt_02;
        private System.Windows.Forms.TextBox txt_12;
        private System.Windows.Forms.TextBox txt_11;
        private System.Windows.Forms.TextBox txt_10;
        private System.Windows.Forms.TextBox txt_22;
        private System.Windows.Forms.TextBox txt_21;
        private System.Windows.Forms.TextBox txt_20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_error;
        private Label label2;
    }
}


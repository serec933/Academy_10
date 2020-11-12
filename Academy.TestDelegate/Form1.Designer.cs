namespace Academy.TestDelegate
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
            this.label1 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.subj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "from";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(258, 65);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(280, 26);
            this.from.TabIndex = 2;
            // 
            // subj
            // 
            this.subj.Location = new System.Drawing.Point(258, 136);
            this.subj.Name = "subj";
            this.subj.Size = new System.Drawing.Size(280, 26);
            this.subj.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "subject";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(258, 97);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(280, 26);
            this.to.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "to";
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(258, 182);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(280, 162);
            this.body.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "body";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.body);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox subj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}


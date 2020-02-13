namespace EU_Calculator
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.vf1 = new System.Windows.Forms.CheckBox();
            this.va1 = new System.Windows.Forms.CheckBox();
            this.a1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Austria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vf1
            // 
            this.vf1.AutoSize = true;
            this.vf1.Location = new System.Drawing.Point(264, 56);
            this.vf1.Name = "vf1";
            this.vf1.Size = new System.Drawing.Size(63, 17);
            this.vf1.TabIndex = 1;
            this.vf1.Text = "Vote for";
            this.vf1.UseVisualStyleBackColor = true;
            this.vf1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // va1
            // 
            this.va1.AutoSize = true;
            this.va1.Location = new System.Drawing.Point(431, 56);
            this.va1.Name = "va1";
            this.va1.Size = new System.Drawing.Size(85, 17);
            this.va1.TabIndex = 2;
            this.va1.Text = "Vote aganist";
            this.va1.UseVisualStyleBackColor = true;
            this.va1.CheckedChanged += new System.EventHandler(this.va1_CheckedChanged);
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Location = new System.Drawing.Point(613, 56);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(61, 17);
            this.a1.TabIndex = 3;
            this.a1.Text = "Abstain";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.CheckedChanged += new System.EventHandler(this.a1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.va1);
            this.Controls.Add(this.vf1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox vf1;
        private System.Windows.Forms.CheckBox va1;
        private System.Windows.Forms.CheckBox a1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


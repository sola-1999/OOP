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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vote = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultPrint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QM = new System.Windows.Forms.Button();
            this.Unamity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Country,
            this.Population,
            this.Vote});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(487, 621);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Population
            // 
            this.Population.HeaderText = "Population";
            this.Population.Name = "Population";
            this.Population.ReadOnly = true;
            // 
            // Vote
            // 
            this.Vote.HeaderText = "Vote";
            this.Vote.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Abstain"});
            this.Vote.Name = "Vote";
            this.Vote.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "The result is:";
            // 
            // ResultPrint
            // 
            this.ResultPrint.AutoSize = true;
            this.ResultPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultPrint.Location = new System.Drawing.Point(654, 235);
            this.ResultPrint.Name = "ResultPrint";
            this.ResultPrint.Size = new System.Drawing.Size(0, 20);
            this.ResultPrint.TabIndex = 113;
            this.ResultPrint.Click += new System.EventHandler(this.ResultPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "Select a vote rule each time an input is changed";
            // 
            // QM
            // 
            this.QM.Location = new System.Drawing.Point(544, 99);
            this.QM.Name = "QM";
            this.QM.Size = new System.Drawing.Size(117, 71);
            this.QM.TabIndex = 115;
            this.QM.Text = "Qualified Majority";
            this.QM.UseVisualStyleBackColor = true;
            this.QM.Click += new System.EventHandler(this.QM_Click);
            // 
            // Unamity
            // 
            this.Unamity.Location = new System.Drawing.Point(768, 99);
            this.Unamity.Name = "Unamity";
            this.Unamity.Size = new System.Drawing.Size(93, 71);
            this.Unamity.TabIndex = 116;
            this.Unamity.Text = "Unamity";
            this.Unamity.UseVisualStyleBackColor = true;
            this.Unamity.Click += new System.EventHandler(this.Unamity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(988, 641);
            this.Controls.Add(this.Unamity);
            this.Controls.Add(this.QM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "EU vote calculator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population;
        private System.Windows.Forms.DataGridViewComboBoxColumn Vote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QM;
        private System.Windows.Forms.Button Unamity;
    }
}


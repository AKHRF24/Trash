namespace P11
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
            this.buttonGetData = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(637, 422);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(101, 39);
            this.buttonGetData.TabIndex = 1;
            this.buttonGetData.Text = "Tampilkan";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(96, 41);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 62;
            this.dataGridViewData.RowTemplate.Height = 28;
            this.dataGridViewData.Size = new System.Drawing.Size(1189, 375);
            this.dataGridViewData.TabIndex = 2;
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rawr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.buttonGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label label1;
    }
}


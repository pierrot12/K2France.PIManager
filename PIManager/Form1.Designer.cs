namespace PIManager
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.txtProcInstanceId = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.btnLoadPI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatafields = new System.Windows.Forms.DataGridView();
            this.dataFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcessFullName = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlActivities = new System.Windows.Forms.ComboBox();
            this.chkChangeFolio = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatafields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProcInstanceId
            // 
            this.txtProcInstanceId.Location = new System.Drawing.Point(142, 9);
            this.txtProcInstanceId.Name = "txtProcInstanceId";
            this.txtProcInstanceId.Size = new System.Drawing.Size(100, 20);
            this.txtProcInstanceId.TabIndex = 0;
            // 
            // txtFolio
            // 
            this.txtFolio.Enabled = false;
            this.txtFolio.Location = new System.Drawing.Point(142, 58);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(288, 20);
            this.txtFolio.TabIndex = 1;
            // 
            // btnLoadPI
            // 
            this.btnLoadPI.Location = new System.Drawing.Point(295, 9);
            this.btnLoadPI.Name = "btnLoadPI";
            this.btnLoadPI.Size = new System.Drawing.Size(135, 23);
            this.btnLoadPI.TabIndex = 2;
            this.btnLoadPI.Text = "Load process instance";
            this.btnLoadPI.UseVisualStyleBackColor = true;
            this.btnLoadPI.Click += new System.EventHandler(this.btnLoadPI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Process instance ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folio : ";
            // 
            // dgvDatafields
            // 
            this.dgvDatafields.AllowUserToAddRows = false;
            this.dgvDatafields.AllowUserToDeleteRows = false;
            this.dgvDatafields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatafields.Location = new System.Drawing.Point(12, 87);
            this.dgvDatafields.Name = "dgvDatafields";
            this.dgvDatafields.Size = new System.Drawing.Size(635, 369);
            this.dgvDatafields.TabIndex = 5;
            this.dgvDatafields.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatafields_CellContentClick);
            // 
            // dataFieldBindingSource
            // 
            this.dataFieldBindingSource.DataSource = typeof(SourceCode.Workflow.Client.DataField);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(551, 464);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(96, 23);
            this.btnDuplicate.TabIndex = 6;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Process name :";
            // 
            // txtProcessFullName
            // 
            this.txtProcessFullName.Enabled = false;
            this.txtProcessFullName.Location = new System.Drawing.Point(142, 34);
            this.txtProcessFullName.Name = "txtProcessFullName";
            this.txtProcessFullName.Size = new System.Drawing.Size(288, 20);
            this.txtProcessFullName.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn1.HeaderText = "Value";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ddlActivities
            // 
            this.ddlActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlActivities.FormattingEnabled = true;
            this.ddlActivities.Location = new System.Drawing.Point(320, 466);
            this.ddlActivities.Name = "ddlActivities";
            this.ddlActivities.Size = new System.Drawing.Size(211, 21);
            this.ddlActivities.TabIndex = 9;
            // 
            // chkChangeFolio
            // 
            this.chkChangeFolio.AutoSize = true;
            this.chkChangeFolio.Location = new System.Drawing.Point(437, 62);
            this.chkChangeFolio.Name = "chkChangeFolio";
            this.chkChangeFolio.Size = new System.Drawing.Size(88, 17);
            this.chkChangeFolio.TabIndex = 10;
            this.chkChangeFolio.Text = "Change Folio";
            this.chkChangeFolio.UseVisualStyleBackColor = true;
            this.chkChangeFolio.CheckedChanged += new System.EventHandler(this.chkChangeFolio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(490, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 499);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkChangeFolio);
            this.Controls.Add(this.ddlActivities);
            this.Controls.Add(this.txtProcessFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDuplicate);
            this.Controls.Add(this.dgvDatafields);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadPI);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.txtProcInstanceId);
            this.Name = "Home";
            this.Text = "Process Instance Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatafields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFieldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcInstanceId;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Button btnLoadPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatafields;
        private System.Windows.Forms.BindingSource dataFieldBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProcessFullName;
        private System.Windows.Forms.ComboBox ddlActivities;
        private System.Windows.Forms.CheckBox chkChangeFolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
    }
}


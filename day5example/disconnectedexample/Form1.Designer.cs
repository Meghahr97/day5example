namespace disconnectedexample
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
            this.components = new System.ComponentModel.Container();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnxml = new System.Windows.Forms.Button();
            this.dgselect = new System.Windows.Forms.DataGridView();
            this.lbxml = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btncallsp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainingDBDataSet = new disconnectedexample.TrainingDBDataSet();
            this.registerShippingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerShippingTableAdapter = new disconnectedexample.TrainingDBDataSetTableAdapters.RegisterShippingTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingPreferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShippingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(65, 43);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(187, 43);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnxml
            // 
            this.btnxml.Location = new System.Drawing.Point(301, 43);
            this.btnxml.Name = "btnxml";
            this.btnxml.Size = new System.Drawing.Size(75, 23);
            this.btnxml.TabIndex = 2;
            this.btnxml.Text = "showXml";
            this.btnxml.UseVisualStyleBackColor = true;
            this.btnxml.Click += new System.EventHandler(this.btnxml_Click);
            // 
            // dgselect
            // 
            this.dgselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgselect.Location = new System.Drawing.Point(56, 111);
            this.dgselect.Name = "dgselect";
            this.dgselect.Size = new System.Drawing.Size(240, 150);
            this.dgselect.TabIndex = 3;
            // 
            // lbxml
            // 
            this.lbxml.FormattingEnabled = true;
            this.lbxml.Location = new System.Drawing.Point(404, 111);
            this.lbxml.Name = "lbxml";
            this.lbxml.Size = new System.Drawing.Size(120, 95);
            this.lbxml.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "enter id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(495, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(84, 20);
            this.txtid.TabIndex = 6;
            // 
            // btncallsp
            // 
            this.btncallsp.Location = new System.Drawing.Point(561, 111);
            this.btncallsp.Name = "btncallsp";
            this.btncallsp.Size = new System.Drawing.Size(79, 40);
            this.btncallsp.TabIndex = 7;
            this.btncallsp.Text = "call sp";
            this.btncallsp.UseVisualStyleBackColor = true;
            this.btncallsp.Click += new System.EventHandler(this.btncallsp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.membershipDataGridViewTextBoxColumn,
            this.shoppingPreferenceDataGridViewTextBoxColumn,
            this.cODDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registerShippingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(229, 105);
            this.dataGridView1.TabIndex = 8;
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerShippingBindingSource
            // 
            this.registerShippingBindingSource.DataMember = "RegisterShipping";
            this.registerShippingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // registerShippingTableAdapter
            // 
            this.registerShippingTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // membershipDataGridViewTextBoxColumn
            // 
            this.membershipDataGridViewTextBoxColumn.DataPropertyName = "Membership";
            this.membershipDataGridViewTextBoxColumn.HeaderText = "Membership";
            this.membershipDataGridViewTextBoxColumn.Name = "membershipDataGridViewTextBoxColumn";
            // 
            // shoppingPreferenceDataGridViewTextBoxColumn
            // 
            this.shoppingPreferenceDataGridViewTextBoxColumn.DataPropertyName = "ShoppingPreference";
            this.shoppingPreferenceDataGridViewTextBoxColumn.HeaderText = "ShoppingPreference";
            this.shoppingPreferenceDataGridViewTextBoxColumn.Name = "shoppingPreferenceDataGridViewTextBoxColumn";
            // 
            // cODDataGridViewTextBoxColumn
            // 
            this.cODDataGridViewTextBoxColumn.DataPropertyName = "COD";
            this.cODDataGridViewTextBoxColumn.HeaderText = "COD";
            this.cODDataGridViewTextBoxColumn.Name = "cODDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncallsp);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxml);
            this.Controls.Add(this.dgselect);
            this.Controls.Add(this.btnxml);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShippingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnxml;
        private System.Windows.Forms.DataGridView dgselect;
        private System.Windows.Forms.ListBox lbxml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btncallsp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShippingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShippingTableAdapter registerShippingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingPreferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}


﻿namespace UchPractics
{
    partial class Tc_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCENKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTOGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jornBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBDDataSet1 = new UchPractics.StudentsBDDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.jornTableAdapter1 = new UchPractics.StudentsBDDataSet1TableAdapters.JornTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jornBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBDDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stFIODataGridViewTextBoxColumn,
            this.tCFIODataGridViewTextBoxColumn,
            this.pREDDataGridViewTextBoxColumn,
            this.oCENKADataGridViewTextBoxColumn,
            this.iTOGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jornBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // stFIODataGridViewTextBoxColumn
            // 
            this.stFIODataGridViewTextBoxColumn.DataPropertyName = "StFIO";
            this.stFIODataGridViewTextBoxColumn.HeaderText = "StFIO";
            this.stFIODataGridViewTextBoxColumn.Name = "stFIODataGridViewTextBoxColumn";
            // 
            // tCFIODataGridViewTextBoxColumn
            // 
            this.tCFIODataGridViewTextBoxColumn.DataPropertyName = "TCFIO";
            this.tCFIODataGridViewTextBoxColumn.HeaderText = "TCFIO";
            this.tCFIODataGridViewTextBoxColumn.Name = "tCFIODataGridViewTextBoxColumn";
            // 
            // pREDDataGridViewTextBoxColumn
            // 
            this.pREDDataGridViewTextBoxColumn.DataPropertyName = "PRED";
            this.pREDDataGridViewTextBoxColumn.HeaderText = "PRED";
            this.pREDDataGridViewTextBoxColumn.Name = "pREDDataGridViewTextBoxColumn";
            // 
            // oCENKADataGridViewTextBoxColumn
            // 
            this.oCENKADataGridViewTextBoxColumn.DataPropertyName = "OCENKA";
            this.oCENKADataGridViewTextBoxColumn.HeaderText = "OCENKA";
            this.oCENKADataGridViewTextBoxColumn.Name = "oCENKADataGridViewTextBoxColumn";
            // 
            // iTOGDataGridViewTextBoxColumn
            // 
            this.iTOGDataGridViewTextBoxColumn.DataPropertyName = "ITOG";
            this.iTOGDataGridViewTextBoxColumn.HeaderText = "ITOG";
            this.iTOGDataGridViewTextBoxColumn.Name = "iTOGDataGridViewTextBoxColumn";
            // 
            // jornBindingSource1
            // 
            this.jornBindingSource1.DataMember = "Jorn";
            this.jornBindingSource1.DataSource = this.studentsBDDataSet1;
            // 
            // studentsBDDataSet1
            // 
            this.studentsBDDataSet1.DataSetName = "StudentsBDDataSet1";
            this.studentsBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Принять изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jornTableAdapter1
            // 
            this.jornTableAdapter1.ClearBeforeFill = true;
            // 
            // Tc_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tc_form";
            this.Text = "Tc_form";
            this.Load += new System.EventHandler(this.Tc_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jornBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBDDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oCENKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTOGDataGridViewTextBoxColumn;
        private StudentsBDDataSet1 studentsBDDataSet1;
        private System.Windows.Forms.BindingSource jornBindingSource1;
        private StudentsBDDataSet1TableAdapters.JornTableAdapter jornTableAdapter1;
    }
}
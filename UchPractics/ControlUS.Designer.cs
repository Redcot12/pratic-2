namespace UchPractics
{
    partial class ControlUS
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronicGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwordgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDgrid,
            this.NameGrid,
            this.SurnameGrid,
            this.PatronicGrid,
            this.LoginGrid,
            this.Passwordgrid,
            this.RoleGrid});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 231);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Принять изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить пользователя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ID Пользователя которого хотите удалить";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // IDgrid
            // 
            this.IDgrid.HeaderText = "Номер";
            this.IDgrid.Name = "IDgrid";
            // 
            // NameGrid
            // 
            this.NameGrid.HeaderText = "Имя";
            this.NameGrid.Name = "NameGrid";
            // 
            // SurnameGrid
            // 
            this.SurnameGrid.HeaderText = "Фамилия";
            this.SurnameGrid.Name = "SurnameGrid";
            // 
            // PatronicGrid
            // 
            this.PatronicGrid.HeaderText = "Отчество";
            this.PatronicGrid.Name = "PatronicGrid";
            // 
            // LoginGrid
            // 
            this.LoginGrid.HeaderText = "Логин";
            this.LoginGrid.Name = "LoginGrid";
            // 
            // Passwordgrid
            // 
            this.Passwordgrid.HeaderText = "Пароль";
            this.Passwordgrid.Name = "Passwordgrid";
            // 
            // RoleGrid
            // 
            this.RoleGrid.HeaderText = "Роль";
            this.RoleGrid.Name = "RoleGrid";
            // 
            // ControlUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ControlUS";
            this.Text = "ControlUS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronicGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwordgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGrid;
    }
}
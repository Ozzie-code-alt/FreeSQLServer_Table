namespace SANTOS_ProfileDB
{
    partial class frmHome
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabProfiles = new System.Windows.Forms.TabPage();
            this.dataSTudents = new System.Windows.Forms.DataGridView();
            this.studMname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageStudents = new System.Windows.Forms.TabControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtstudID = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnstudADD = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCLear = new System.Windows.Forms.Button();
            this.tabProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSTudents)).BeginInit();
            this.tabPageStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabProfiles
            // 
            this.tabProfiles.Controls.Add(this.btnCLear);
            this.tabProfiles.Controls.Add(this.btnUpdate);
            this.tabProfiles.Controls.Add(this.btnstudADD);
            this.tabProfiles.Controls.Add(this.label5);
            this.tabProfiles.Controls.Add(this.label4);
            this.tabProfiles.Controls.Add(this.label3);
            this.tabProfiles.Controls.Add(this.label2);
            this.tabProfiles.Controls.Add(this.label1);
            this.tabProfiles.Controls.Add(this.txtFname);
            this.tabProfiles.Controls.Add(this.txtLname);
            this.tabProfiles.Controls.Add(this.txtstudID);
            this.tabProfiles.Controls.Add(this.txtMname);
            this.tabProfiles.Controls.Add(this.txtID);
            this.tabProfiles.Controls.Add(this.dataSTudents);
            this.tabProfiles.Location = new System.Drawing.Point(4, 25);
            this.tabProfiles.Name = "tabProfiles";
            this.tabProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfiles.Size = new System.Drawing.Size(768, 397);
            this.tabProfiles.TabIndex = 0;
            this.tabProfiles.Text = "STUDENT";
            this.tabProfiles.UseVisualStyleBackColor = true;
            // 
            // dataSTudents
            // 
            this.dataSTudents.AllowUserToAddRows = false;
            this.dataSTudents.AllowUserToDeleteRows = false;
            this.dataSTudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSTudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.studID,
            this.studLname,
            this.studFname,
            this.studMname});
            this.dataSTudents.Location = new System.Drawing.Point(184, 24);
            this.dataSTudents.Name = "dataSTudents";
            this.dataSTudents.ReadOnly = true;
            this.dataSTudents.RowHeadersWidth = 51;
            this.dataSTudents.RowTemplate.Height = 24;
            this.dataSTudents.Size = new System.Drawing.Size(548, 352);
            this.dataSTudents.TabIndex = 0;
            this.dataSTudents.SelectionChanged += new System.EventHandler(this.dataSTudents_SelectionChanged);
            // 
            // studMname
            // 
            this.studMname.HeaderText = "Middle Name";
            this.studMname.MinimumWidth = 6;
            this.studMname.Name = "studMname";
            this.studMname.ReadOnly = true;
            this.studMname.Width = 125;
            // 
            // studFname
            // 
            this.studFname.HeaderText = "First Name";
            this.studFname.MinimumWidth = 6;
            this.studFname.Name = "studFname";
            this.studFname.ReadOnly = true;
            this.studFname.Width = 125;
            // 
            // studLname
            // 
            this.studLname.HeaderText = "Last Name";
            this.studLname.MinimumWidth = 6;
            this.studLname.Name = "studLname";
            this.studLname.ReadOnly = true;
            this.studLname.Width = 125;
            // 
            // studID
            // 
            this.studID.HeaderText = "STUD ID";
            this.studID.MinimumWidth = 6;
            this.studID.Name = "studID";
            this.studID.ReadOnly = true;
            this.studID.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.tabProfiles);
            this.tabPageStudents.Controls.Add(this.tabPage2);
            this.tabPageStudents.Location = new System.Drawing.Point(12, 12);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.SelectedIndex = 0;
            this.tabPageStudents.Size = new System.Drawing.Size(776, 426);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(9, 64);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(9, 333);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(100, 22);
            this.txtMname.TabIndex = 3;
            // 
            // txtstudID
            // 
            this.txtstudID.Location = new System.Drawing.Point(9, 132);
            this.txtstudID.Name = "txtstudID";
            this.txtstudID.Size = new System.Drawing.Size(100, 22);
            this.txtstudID.TabIndex = 4;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(9, 200);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 22);
            this.txtLname.TabIndex = 5;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(9, 261);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 22);
            this.txtFname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "MIddle Name";
            // 
            // btnstudADD
            // 
            this.btnstudADD.Location = new System.Drawing.Point(82, 368);
            this.btnstudADD.Name = "btnstudADD";
            this.btnstudADD.Size = new System.Drawing.Size(75, 23);
            this.btnstudADD.TabIndex = 12;
            this.btnstudADD.Text = "ADD";
            this.btnstudADD.UseVisualStyleBackColor = true;
            this.btnstudADD.Click += new System.EventHandler(this.btnstudADD_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCLear
            // 
            this.btnCLear.Location = new System.Drawing.Point(103, 289);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(75, 23);
            this.btnCLear.TabIndex = 14;
            this.btnCLear.Text = "Clear Lmao";
            this.btnCLear.UseVisualStyleBackColor = true;
            this.btnCLear.Click += new System.EventHandler(this.btnCLear_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPageStudents);
            this.Name = "frmHome";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tabProfiles.ResumeLayout(false);
            this.tabProfiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSTudents)).EndInit();
            this.tabPageStudents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabProfiles;
        private System.Windows.Forms.DataGridView dataSTudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn studFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn studMname;
        private System.Windows.Forms.TabControl tabPageStudents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtstudID;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnstudADD;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCLear;
    }
}


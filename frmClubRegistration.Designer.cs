namespace ClubRegistration {
    partial class frmClubRegistration {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbxMiddleName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbxStudentID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtbxAge);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbProgram);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtbxMiddleName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtbxFirstName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtbxLastName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtbxStudentID);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 319);
            this.panel1.TabIndex = 14;
            // 
            // cbGender
            // 
            this.cbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(349, 245);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(222, 40);
            this.cbGender.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Gender:";
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(23, 245);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(125, 39);
            this.txtbxAge.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "Age:";
            // 
            // cbProgram
            // 
            this.cbProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BSIT",
            "BSHM",
            "BSCPE",
            "BSBA"});
            this.cbProgram.Location = new System.Drawing.Point(677, 54);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(295, 40);
            this.cbProgram.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "Program:";
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Location = new System.Drawing.Point(673, 148);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(299, 39);
            this.txtbxMiddleName.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(667, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Middle Name:";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(349, 148);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(299, 39);
            this.txtbxFirstName.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "First Name:";
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(23, 148);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(299, 39);
            this.txtbxLastName.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 32);
            this.label13.TabIndex = 16;
            this.label13.Text = "Last Name:";
            // 
            // txtbxStudentID
            // 
            this.txtbxStudentID.Location = new System.Drawing.Point(23, 54);
            this.txtbxStudentID.Name = "txtbxStudentID";
            this.txtbxStudentID.Size = new System.Drawing.Size(299, 39);
            this.txtbxStudentID.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 32);
            this.label14.TabIndex = 14;
            this.label14.Text = "Student ID:";
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Location = new System.Drawing.Point(1052, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(226, 52);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(1052, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(226, 52);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Location = new System.Drawing.Point(12, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 371);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 56);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(986, 291);
            this.dataGridView.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "List of Club Members";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(1039, 56);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(196, 52);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1290, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmClubRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClubRegistration";
            this.Load += new System.EventHandler(this.frmClubRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbxMiddleName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbxStudentID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGender;
    }
}


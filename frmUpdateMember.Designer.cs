namespace ClubRegistration {
    partial class frmUpdateMember {
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
            this.label14 = new System.Windows.Forms.Label();
            this.cbStudentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 32);
            this.label14.TabIndex = 15;
            this.label14.Text = "Student ID:";
            // 
            // cbStudentID
            // 
            this.cbStudentID.FormattingEnabled = true;
            this.cbStudentID.Location = new System.Drawing.Point(28, 54);
            this.cbStudentID.Name = "cbStudentID";
            this.cbStudentID.Size = new System.Drawing.Size(415, 40);
            this.cbStudentID.TabIndex = 16;
            this.cbStudentID.SelectedIndexChanged += new System.EventHandler(this.cbStudentID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Last Name:";
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(28, 142);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(415, 39);
            this.txtbxLastName.TabIndex = 18;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(28, 229);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(415, 39);
            this.txtbxFirstName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name:";
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Location = new System.Drawing.Point(28, 319);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(415, 39);
            this.txtbxMiddleName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Middle Name:";
            // 
            // txtbxAge
            // 
            this.txtbxAge.Location = new System.Drawing.Point(31, 406);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(156, 39);
            this.txtbxAge.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Age:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(202, 406);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(241, 40);
            this.cbGender.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Gender:";
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BSIT",
            "BSHM",
            "BSCPE",
            "BSBA"});
            this.cbProgram.Location = new System.Drawing.Point(31, 501);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(415, 40);
            this.cbProgram.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Program";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Location = new System.Drawing.Point(121, 580);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(226, 52);
            this.btnConfirm.TabIndex = 29;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(469, 678);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxMiddleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStudentID);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateMember";
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirm;
    }
}
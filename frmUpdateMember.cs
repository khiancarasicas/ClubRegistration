using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistration {
    public partial class frmUpdateMember : Form {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int Age;
        private long StudentId;
        private string FirstName, MiddleName, LastName, Gender, Program;


        public frmUpdateMember() {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            try {
                FirstName = toTitleCase(txtbxFirstName.Text.ToLower());
                if (string.IsNullOrWhiteSpace(FirstName) || FirstName.Length < 2 || FirstName.Length > 50) {
                    throw new ArgumentException("First name must be between 2 and 50 characters.");
                }

                MiddleName = toTitleCase(txtbxMiddleName.Text.ToLower());
                if (string.IsNullOrWhiteSpace(MiddleName) || MiddleName.Length < 2 || MiddleName.Length > 50) {
                    throw new ArgumentException("Middle name must be between 2 and 50 characters.");
                }

                LastName = toTitleCase(txtbxLastName.Text.ToLower());
                if (string.IsNullOrWhiteSpace(LastName) || LastName.Length < 2 || LastName.Length > 50) {
                    throw new ArgumentException("Last name must be between 2 and 50 characters.");
                }

                string ageText = txtbxAge.Text;
                if (string.IsNullOrWhiteSpace(ageText) || !int.TryParse(ageText, out Age) || Age < 18 || Age > 100) {
                    throw new ArgumentException("Age must be a valid number between 18 and 100.");
                }

                Gender = cbGender.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(Gender) || cbGender.SelectedIndex == -1) {
                    throw new ArgumentException("Gender must be selected from the list.");
                }

                Program = cbProgram.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(Program) || cbProgram.SelectedIndex == -1) {
                    throw new ArgumentException("Program must be selected from the list.");
                }

                if (clubRegistrationQuery.UpdateStudent(StudentId, FirstName, MiddleName, LastName, Age, Gender, Program)) {
                    MessageBox.Show("Student information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                    RefreshClubMembers();
                }

            } catch (ArgumentException ex) {
                MessageBox.Show("Error updating student data: " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (SqlException ex) {
                MessageBox.Show("Error updating student data: " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error updating student data: " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUpdateMember_Load(object sender, EventArgs e) {
            clubRegistrationQuery = new ClubRegistrationQuery();
            LoadStudentIDs();
        }

        private void LoadStudentIDs() {
            try {
                string[] studentIDs = clubRegistrationQuery.GetStudentIDs(); 
                cbStudentID.Items.Clear(); 

                if (studentIDs.Length > 0) {
                    cbStudentID.Items.AddRange(studentIDs); 
                } else {
                    MessageBox.Show("No students found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                MessageBox.Show("LoadStudentIDs()\nError loading student IDs : " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbStudentID.SelectedIndex != -1) {
                StudentId = Convert.ToInt64(cbStudentID.Text);
                LoadStudentData(StudentId); 
            }
            
        }

        private void LoadStudentData(long studentId) {
            try {
                DataRow studentData = clubRegistrationQuery.GetStudentDataByID(studentId);

                if (studentData != null) {
                    txtbxFirstName.Text = studentData["FirstName"].ToString();
                    txtbxMiddleName.Text = studentData["MiddleName"].ToString();
                    txtbxLastName.Text = studentData["LastName"].ToString();
                    txtbxAge.Text = studentData["Age"].ToString();
                    cbGender.SelectedItem = studentData["Gender"].ToString();
                    cbProgram.SelectedItem = studentData["Program"].ToString();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error loading student data: " + ex.Message);
            }
        }

        private void RefreshClubMembers() {
            frmClubRegistration mainForm = (frmClubRegistration)Application.OpenForms["frmClubRegistration"];
            if (mainForm != null) {
                mainForm.RefreshListOfClubMembers();
            }
        }

        private string toTitleCase(string text) {
            return Regex.Replace(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text).Trim(), @"\s+", " ");
        }

    }
}

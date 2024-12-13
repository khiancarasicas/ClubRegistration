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
    public partial class frmClubRegistration : Form {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int Age;
        private long StudentId;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void btnRefresh_Click(object sender, EventArgs e) {
            RefreshListOfClubMembers();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            try {
                string studentIdText = txtbxStudentID.Text;
                if (string.IsNullOrWhiteSpace(studentIdText) || studentIdText.Length < 12 || studentIdText.Length > 15 || !long.TryParse(studentIdText, out StudentId)) {
                    throw new ArgumentException("Student ID must be a number with 12 to 15 digits.");
                }

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

                if(clubRegistrationQuery.RegisterStudent(StudentId, FirstName, MiddleName, LastName, Age, Gender, Program)) {
                    MessageBox.Show("Student successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    RefreshListOfClubMembers();
                }

            } catch (ArgumentException ex) {
                MessageBox.Show("Error registering student: " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (SqlException ex) {
                if (ex.Number == 2627 || ex.Number == 2601) {
                    MessageBox.Show("Error registering student: Cannot insert because a duplicate value occurred.", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Error registering student: " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error registering student: " + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClubRegistration_Load(object sender, EventArgs e) {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            frmUpdateMember updateForm = new frmUpdateMember();
            updateForm.ShowDialog(); 
        }

        public frmClubRegistration() {
            InitializeComponent();
        }

        private string toTitleCase(string text) {
            return Regex.Replace(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text).Trim(), @"\s+", " ");
        }

        public void RefreshListOfClubMembers() {
            clubRegistrationQuery.DisplayList();
            dataGridView.DataSource = clubRegistrationQuery.bindingSource;
        }

        private void clearFields() {
            txtbxAge.Clear();
            txtbxFirstName.Clear();
            txtbxLastName.Clear();
            txtbxMiddleName.Clear();
            txtbxStudentID.Clear();
            cbGender.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }
    }
}

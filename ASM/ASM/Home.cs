using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class Home : Form
    {
        public SqlConnection Con;
        public Home()
        {
            InitializeComponent();
            Con = new SqlConnection("Server =TRẦN-CÔNG-HOÀNG;Database=Student_Management ;Integrated Security = true;");
        }
        public Home(string username)
        {
            InitializeComponent();
            Con = new SqlConnection("Server =TRẦN-CÔNG-HOÀNG;Database=Student_Management ;Integrated Security = true;");
            lbUsername.Text = "User: " + username;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            // lấy dữ liệu từ CSDL hiển thị ra combobox
            string query = "select ClassId,ClassName from Class";
            DataTable table = new DataTable();
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            adapter.Fill(table);
            cbbClassId.DataSource = table;
            cbbClassId.DisplayMember = "ClassId";
            cbbClassId.ValueMember = "ClassName";
            Con.Close();
            FillData();
        }
        public void FillData()
        {
            // Lấy dữ liệu từ bảng hiện thị lên DatagirdView
            string query = "Select * from Student ";
            string queryTeacher = " Select * from Teacher ";
            DataTable tableStudent = new DataTable();
            DataTable tableTeacher = new DataTable();
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlDataAdapter adapterteacher = new SqlDataAdapter(queryTeacher, Con);
            adapter.Fill(tableStudent);
            adapterteacher.Fill(tableTeacher);
            dgvStudentInfor.DataSource = tableStudent;
            dgvViewTeacher.DataSource = tableTeacher;
            Con.Close();

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            //biến error để đếm lỗi
            int error = 0;
            string Sid = txtSid.Text;
            //kiểm tra xem ID có để trống không, nếu để trống thì báo lỗi
            if (Sid.Equals(""))
            {
                error = error + 1;
                lbSid.Text = "ID can't be blank";
            }
            else
            {
                //tiếp tục kiểm tra xem ID có bị trùng không
                string query = "select * from Student where StudentId = @id";
                Con.Open();
                SqlCommand cmdcheck = new SqlCommand(query, Con);
                //thêm parameter, khai báo kiểu dl
                cmdcheck.Parameters.Add("@id", SqlDbType.VarChar);
                //gán giá trị cho parameter
                cmdcheck.Parameters["@id"].Value = Sid;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbSid.Text = "This ID is existing";
                }
                else
                {
                    lbSid.Text = "";
                }
                Con.Close();
            }

            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            // Kiểm tra Phone có bị trống không
            string Phone = txtPhone.Text;
            if (Phone.Equals(""))
            {
                error = error + 1;
                lbPhone.Text = "Phone can't be blank";
            }
            else
            {
                //tiếp tục kiểm tra xem Phone có bị trùng không
                string query = "select * from Student where S_Phone = @Phone";
                Con.Open();
                SqlCommand cmdcheck = new SqlCommand(query, Con);
                //thêm parameter, khai báo kiểu dl
                cmdcheck.Parameters.Add("@Phone", SqlDbType.VarChar);
                //gán giá trị cho parameter
                cmdcheck.Parameters["@Phone"].Value = Phone;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbPhone.Text = "This Phone is existing";
                }
                else
                {
                    lbPhone.Text = "";
                }
                Con.Close();
            }
            string Email = txtEmail.Text;
            if (Email.Equals(""))
            {
                error = error + 1;
                lbEmail.Text = "Email can't be blank";
            }
            else
            {
                //tiếp tục kiểm tra xem Email có bị trùng không
                string query = "select * from Student where S_Email = @Email";
                Con.Open();
                SqlCommand cmdcheck = new SqlCommand(query, Con);
                //thêm parameter, khai báo kiểu dl
                cmdcheck.Parameters.Add("@Email", SqlDbType.VarChar);
                //gán giá trị cho parameter
                cmdcheck.Parameters["@Email"].Value = Email;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbEmail.Text = "This Email is existing";
                }
                else
                {
                    lbEmail.Text = "";
                }
                Con.Close();
            }
            string DateOfBirth = txtDoB.Text;
            string ClassId = cbbClassId.Text;
            //kiểm tra lỗi CladdId để trống
            if (ClassId.Equals(""))
            {
                error = error + 1;
                lbClassId.Text = "Class ID can't be blank";
            }
            else
            {
                lbClassId.Text = "";
            }
            //Nếu không có lỗi nhập liệu thì cho phép lưu dữ liệu vào csdl
            string Address = txtAddress.Text;
            if (error == 0)
            {
                string insert = "insert into Student values (@StudentId,@S_FirstName,@S_LastName,@S_Phone,@S_Email,@S_DoB,@S_Address,@ClassId)";
                Con.Open();
                SqlCommand cmd = new SqlCommand(insert, Con);
                //lần lượt khai báo và gán giá trị cho các para
                cmd.Parameters.Add("@StudentId", SqlDbType.VarChar);
                cmd.Parameters["@StudentId"].Value = Sid;

                cmd.Parameters.Add("@S_FirstName", SqlDbType.VarChar);
                cmd.Parameters["@S_FirstName"].Value = FirstName;

                cmd.Parameters.Add("@S_LastName", SqlDbType.VarChar);
                cmd.Parameters["@S_LastName"].Value = LastName;

                cmd.Parameters.Add("@S_Phone", SqlDbType.VarChar);
                cmd.Parameters["@S_Phone"].Value = Phone;

                cmd.Parameters.Add("@S_Email", SqlDbType.VarChar);
                cmd.Parameters["@S_Email"].Value = Email;

                cmd.Parameters.Add("@S_DoB", SqlDbType.Date);
                cmd.Parameters["@S_DoB"].Value = DateOfBirth;

                cmd.Parameters.Add("@S_Address", SqlDbType.VarChar);
                cmd.Parameters["@S_Address"].Value = Address;

                cmd.Parameters.Add("@ClassId", SqlDbType.VarChar);
                cmd.Parameters["@ClassId"].Value = ClassId;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
                Con.Close();
                //refresh lại dữ liệu
                FillData();
            }
            else
                MessageBox.Show("Cannot insert the record to Database");
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string update = "update Student set  S_FirstName = @FirstName, S_LastName = @LastName, S_Phone=@Phone, S_Email = @Email, S_DoB = @DoB, S_Address = @Address, ClassId = @ClassId where StudentId = @StudentId";
            Con.Open();
            SqlCommand cmd = new SqlCommand(update, Con);

            cmd.Parameters.Add("@StudentId", SqlDbType.VarChar);
            cmd.Parameters["@StudentId"].Value = txtSid.Text;

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar);
            cmd.Parameters["@FirstName"].Value = txtFirstName.Text;

            cmd.Parameters.Add("@LastName", SqlDbType.VarChar);
            cmd.Parameters["@LastName"].Value = txtLastName.Text;

            cmd.Parameters.Add("@Phone", SqlDbType.VarChar);
            cmd.Parameters["@Phone"].Value = txtPhone.Text;

            cmd.Parameters.Add("@Email", SqlDbType.VarChar);
            cmd.Parameters["@Email"].Value = txtEmail.Text;

            cmd.Parameters.Add("@DoB", SqlDbType.Date);
            cmd.Parameters["@DoB"].Value = txtDoB.Text;

            cmd.Parameters.Add("@Address", SqlDbType.VarChar);
            cmd.Parameters["@Address"].Value = txtAddress.Text;


            cmd.Parameters.Add("@ClassId", SqlDbType.VarChar);
            cmd.Parameters["@ClassId"].Value = cbbClassId.Text;

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Updated");
            }
            Con.Close();
            FillData();
        }

        private void btRefesh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Student", Con);
            DataSet dataSetds = new DataSet();
            adapter.Fill(dataSetds, "Student");
            dgvStudentInfor.DataSource = dataSetds.Tables["Student"].DefaultView;
            MessageBox.Show("Data has been successfully updated!");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string Id = txtSid.Text;
                Con.Open();
                string query2 = "Delete from Student where StudentId = '" + Id + "'";
                SqlCommand cmd2 = new SqlCommand(query2, Con);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Succussfully Delete");
                Con.Close();
                FillData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadsearch();
        }
        public void loadsearch()
        {
            string ClassId = cbbClassId.Text;
            string query = "SELECT * FROM Student WHERE ClassId = '" + ClassId + "'";
            //Create a table
            DataTable table = new DataTable();
            //Open connection to database
            Con.Open();
            //SqlDataAdapter acts as a bridge between DataSet and data source (SQL Server Database) to retrieve data
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            //The data in the adapter will be filled into the table
            adapter.Fill(table);
            //Data from table will be dumped into datagridview
            dgvStudentInfor.DataSource = table;
            //Close connection to database
            Con.Close();
        }

        private void dgvStudentInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudentInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                //lấy ra cột hiện hành
                DataGridViewRow row = this.dgvStudentInfor.Rows[e.RowIndex];
                txtSid.Text = row.Cells["StudentId"].Value.ToString();
                cbbClassId.SelectedValue = row.Cells["ClassId"].Value.ToString();
                txtFirstName.Text = row.Cells["S_FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["S_LastName"].Value.ToString();
                txtPhone.Text = row.Cells["S_Phone"].Value.ToString();
                txtEmail.Text = row.Cells["S_Email"].Value.ToString();
                txtDoB.Text = row.Cells["S_DoB"].Value.ToString();
                txtAddress.Text = row.Cells["S_Address"].Value.ToString();
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Login l = new Login();
                l.ShowDialog();
                this.Dispose();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            Schedules schedule = new Schedules();
            schedule.Show();
            this.Hide();
        }

        private void btnViewFaculty_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            faculty.Show();
            this.Hide();
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Show();
            this.Hide();
        }

        private void btnViewSubjects_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            subjects.Show();
            this.Hide();
        }

        private void btnViewClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManaClass classs = new ManaClass();
            classs.Show();
            this.Dispose();
        }

        private void btnInsertTeacher_Click(object sender, EventArgs e)
        {
            //biến error để đếm lỗi
            int error = 0;
            string TeacherId = txtTeacherId.Text;
            //kiểm tra xem ID có để trống không, nếu để trống thì báo lỗi
            string FirstName = txtTeacherFirstName.Text;
            string LastName = txtTeacherLastName.Text;
            // Kiểm tra Phone có bị trống không, nếu để trống thì báo lỗi
            string Phone = txtTeacherPhone.Text;
            if (Phone.Equals(""))
            {
                error = error + 1;
                lbTPhoneError.Text = "Phone can't be blank";
            }
            else
            {
                //tiếp tục kiểm tra xem Phone có bị trùng không
                string query = "select * from Teacher where T_Phone = @Phone";
                Con.Open();
                SqlCommand cmdcheck = new SqlCommand(query, Con);
                //thêm parameter, khai báo kiểu dl
                cmdcheck.Parameters.Add("@Phone", SqlDbType.VarChar);
                //gán giá trị cho parameter
                cmdcheck.Parameters["@Phone"].Value = Phone;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbTPhoneError.Text = "This Phone is existing, please choose another";
                }
                else
                {
                    lbTPhoneError.Text = "";
                }
                Con.Close();
            }
            string Email = txtTeacherEmail.Text;
            if (Email.Equals(""))
            {
                error = error + 1;
                lbTEmailError.Text = "Email can't be blank";
            }
            else
            {
                //tiếp tục kiểm tra xem ID có bị trùng không
                string query = "select * from Teacher where T_Email = @Email";
                Con.Open();
                SqlCommand cmdcheck = new SqlCommand(query, Con);
                //thêm parameter, khai báo kiểu dl
                cmdcheck.Parameters.Add("@Email", SqlDbType.VarChar);
                //gán giá trị cho parameter
                cmdcheck.Parameters["@Email"].Value = Email;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbTEmailError.Text = "This Email is existing, please choose another";
                }
                else
                {
                    lbTEmailError.Text = "";
                }
                Con.Close();
            }
            string DateOfBirth = txtTeacherDoB.Text;
            //Nếu không có lỗi nhập liệu thì cho phép lưu dữ liệu vào csdl
            string Address = txtTeacherAddress.Text;
            if (error == 0)
            {
                string insert = "insert into Teacher values (@T_FirstName,@T_LastName,@T_Phone,@T_Email,@T_DoB,@T_Address)";
                Con.Open();
                SqlCommand cmd = new SqlCommand(insert, Con);
                //lần lượt khai báo và gán giá trị cho các para

                cmd.Parameters.Add("@T_FirstName", SqlDbType.VarChar);
                cmd.Parameters["@T_FirstName"].Value = FirstName;

                cmd.Parameters.Add("@T_LastName", SqlDbType.VarChar);
                cmd.Parameters["@T_LastName"].Value = LastName;

                cmd.Parameters.Add("@T_Phone", SqlDbType.VarChar);
                cmd.Parameters["@T_Phone"].Value = Phone;

                cmd.Parameters.Add("@T_Email", SqlDbType.VarChar);
                cmd.Parameters["@T_Email"].Value = Email;

                cmd.Parameters.Add("@T_DoB", SqlDbType.Date);
                cmd.Parameters["@T_DoB"].Value = DateOfBirth;

                cmd.Parameters.Add("@T_Address", SqlDbType.VarChar);
                cmd.Parameters["@T_Address"].Value = Address;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
                Con.Close();
                //refresh lại dữ liệu
                FillData();
            }
            else
                MessageBox.Show("Cannot insert the record to Database");
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            string update = "update Teacher set T_FirstName = @FirstName,T_LastName = @LastName, T_Phone = @Phone, T_Email = @Email, T_DoB = @DoB, T_Address = @Address where TeacherId = @TeacherId";
            Con.Open();
            SqlCommand cmd = new SqlCommand(update, Con);
            cmd.Parameters.Add("@TeacherId", SqlDbType.VarChar);
            cmd.Parameters["@TeacherId"].Value = txtTeacherId.Text;

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar);
            cmd.Parameters["@FirstName"].Value = txtTeacherFirstName.Text;

            cmd.Parameters.Add("@LastName", SqlDbType.VarChar);
            cmd.Parameters["@LastName"].Value = txtTeacherLastName.Text;

            cmd.Parameters.Add("@Phone", SqlDbType.VarChar);
            cmd.Parameters["@Phone"].Value = txtTeacherPhone.Text;

            cmd.Parameters.Add("@Email", SqlDbType.VarChar);
            cmd.Parameters["@Email"].Value = txtTeacherEmail.Text;

            cmd.Parameters.Add("@DoB", SqlDbType.Date);
            cmd.Parameters["@DoB"].Value = txtTeacherDoB.Text;

            cmd.Parameters.Add("@Address", SqlDbType.VarChar);
            cmd.Parameters["@Address"].Value = txtTeacherAddress.Text;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Updated");
            }
            Con.Close();
            FillData();
        }

        private void btnRefeshTeacher_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Teacher", Con);
            DataSet dataSetds = new DataSet();
            adapter.Fill(dataSetds, "Teacher");
            dgvViewTeacher.DataSource = dataSetds.Tables["Teacher"].DefaultView;
            FillData();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            string TeacherId = txtTeacherId.Text;
            Con.Open();
            string query = "Delete from Teacher where TeacherId = '" + TeacherId + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succussfully Delete");
            Con.Close();
            FillData();
        }

        private void dgvViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                //lấy ra cột hiện hành
                DataGridViewRow row = this.dgvViewTeacher.Rows[e.RowIndex];
                txtTeacherId.Text = row.Cells["TeacherId"].Value.ToString();
                txtTeacherFirstName.Text = row.Cells["T_FirstName"].Value.ToString();
                txtTeacherLastName.Text = row.Cells["T_LastName"].Value.ToString();
                txtTeacherPhone.Text = row.Cells["T_Phone"].Value.ToString();
                txtTeacherEmail.Text = row.Cells["T_Email"].Value.ToString();
                txtTeacherDoB.Text = row.Cells["T_DoB"].Value.ToString();
                txtTeacherAddress.Text = row.Cells["T_Address"].Value.ToString();

            }
        }
    }
}

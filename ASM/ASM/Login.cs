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
    public partial class Login : Form
    {
        public SqlConnection Con;
        public Login()
        {
            InitializeComponent();
            Con = new SqlConnection("Server =TRẦN-CÔNG-HOÀNG;Database=Student_Management ;Integrated Security = true;");

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            txtPassword.PasswordChar = '*';
            string query = " Select * from account where UserName = '" + username + "' and A_Password = '" + password + "'";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            //nếu có kết quả trả về => username và pass hợp lệ
            //   => neu la admin va teacher được phép đăng nhập vào ht (hiển thị form StudentManagement)
            if (reader.Read())
            {
                // nếu role là admin thì hiển thị form StudentManagement
                string role = reader["A_Role"].ToString();
                if (role.Equals("Teacher"))
                {
                    MessageBox.Show("Login uccessful with account Teacher!");
                    this.Hide();
                    Home sms = new Home(username);
                    sms.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("Staff"))
                {
                    MessageBox.Show("Login successful with account Staff!");
                    this.Hide();
                    Home sms = new Home(username);
                    sms.ShowDialog();
                    this.Dispose();
                }
                //nếu role là user thì chỉ hiển thị form ViewProduct
                else if (role.Equals("Student"))
                {
                    MessageBox.Show("Login successful with account Student!");
                    this.Hide();
                    ViewSchedule VC = new ViewSchedule();
                    VC.ShowDialog();
                    this.Dispose();
                }

                //nếu ko có quyền xem thì báo lỗi
                else
                {

                    lbError.Text = "You are not allowed to access";
                }
            }
            else
            {
                MessageBox.Show("Login failed!");
                lbError.Text = "Wrong username or password";
            }
            Con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the login?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

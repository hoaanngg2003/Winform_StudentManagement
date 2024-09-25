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
    public partial class ManaClass : Form
    {
        public SqlConnection Con;
        public ManaClass()
        {
            InitializeComponent();
            Con = new SqlConnection("Server =TRẦN-CÔNG-HOÀNG;Database=Student_Management ;Integrated Security = true;");

        }
        public void FillData()
        {
            // Lấy dữ liệu từ bảng hiện thị lên DatagirdView
            string query = "Select * from Class ";
            DataTable tableClass = new DataTable();
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            adapter.Fill(tableClass);
            dgvClass.DataSource = tableClass;
            Con.Close();
        }
        private void ManaClass_Load(object sender, EventArgs e)
        {
            // lấy dữ liệu từ CSDL hiển thị ra combobox
            string query = "select TeacherId,T_Lastname from Teacher";
            string query2 = "select SubjectsId,SubjectsName from Subjects";
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            adapter.Fill(table);
            cbbTeacherId.DataSource = table;
            cbbTeacherId.DisplayMember = "TeacherId";
            cbbTeacherId.ValueMember = "T_Lastname";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, Con);
            adapter2.Fill(table2);
            cbbSubjectId.DataSource = table2;
            cbbSubjectId.DisplayMember = "SubjectsId";
            cbbSubjectId.ValueMember = "SubjectsName";
            Con.Close();
            FillData();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            int error = 0;
            string ClassId = txtClassId.Text;
            if (ClassId.Equals(""))
            {
                error = error + 1;
                lbClassId.Text = "ID can't be blank";
            }
            else
            {
                //tiếp tục kiểm tra xem ID có bị trùng không
                string query = "select * from Class where ClassId = @id";
                Con.Open();
                SqlCommand cmdcheck = new SqlCommand(query, Con);
                //thêm parameter, khai báo kiểu dl
                cmdcheck.Parameters.Add("@id", SqlDbType.VarChar);
                //gán giá trị cho parameter
                cmdcheck.Parameters["@id"].Value = ClassId;
                SqlDataReader reader = cmdcheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbClassId.Text = "This ID is existing";
                }
                else
                {
                    lbClassId.Text = "";
                }
                Con.Close();
            }
            string ClassName = txtClassName.Text;
            if (ClassName.Equals(""))
            {
                error = error + 1;
                lbClassname.Text = "ID can't be blank";
            }
            else
            {
                lbClassname.Text = "";
            }
            string TeacherId = cbbTeacherId.Text;
            if (TeacherId.Equals(""))
            {
                error = error + 1;
                lbTeacherId.Text = "ID can't be blank";
            }
            else
            {
                lbTeacherId.Text = "";
            }

            string SubjectsId = cbbSubjectId.Text;
            if (error == 0)
            {
                string insert = "insert into Class values ($ClassId,$TeacherId,@SubjectsId)";
                Con.Open();
                SqlCommand cmd = new SqlCommand(insert, Con);
                //lần lượt khai báo và gán giá trị cho các para

                cmd.Parameters.Add("$ClassId", SqlDbType.VarChar);
                cmd.Parameters["$ClassId"].Value = ClassId;

                cmd.Parameters.Add("$ClassName", SqlDbType.VarChar);
                cmd.Parameters["$ClassName"].Value = ClassName;

                cmd.Parameters.Add("$TeadherId", SqlDbType.Int);
                cmd.Parameters["$TeacherId"].Value = TeacherId;

                cmd.Parameters.Add("@SubjectsId", SqlDbType.VarChar);
                cmd.Parameters["@SubjectsId"].Value = SubjectsId;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
                Con.Close();
                //refresh lại dữ liệu
                FillData();
            }
            else
                MessageBox.Show("Cannot insert the record to Database");
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();

        }


        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace ns_Huan
{
    public partial class fStudent : MetroFramework.Forms.MetroForm
    {
        //EntityState objState = EntityState.Unchanged;
        public fStudent()
        {
            InitializeComponent();
        }

        //private void BtnBrowse_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
        //    {
        //        if (ofd.ShowDialog() == DialogResult.OK)
        //        {
        //            pic.Image = Image.FromFile(ofd.FileName);
        //            Student obj = studentBindingSource.Current as Student;
        //            if (obj != null)
        //                obj.ImageUrl = ofd.FileName;
        //        }
        //    }
        //}
        void ClearInput()
        {
            txtStudentCode.Text = null;
            txtStudentName.Text = null;
            txtBirthday.Text = null;
            chkGender.CheckState = CheckState.Unchecked;
            txtEmail.Text = null;
            txtAddress.Text = null;
            txtClassID.Text = null;
            pic.Image = null;
            txtEnrolledScore = null;
        }

        // Load data to metroGrid
        public void LoadDataToGrid()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (sqlConnection.State == ConnectionState.Closed)
                        sqlConnection.Open();
                    String strSql = String.Format(@"select Students.StudentID as 'Mã ID', Students.StudentCode as 'Mã học sinh', Students.StudentName as 'Tên học sinh', Students.Birthday as 'Ngày sinh', Students.Gender as 'Giới tính', Students.StudentAddress as 'Địa chỉ', Students.EnrolledScore as 'Điểm đầu vào', Classes.ClassDesc as 'Tên lớp' from Students left join Classes on Students.ClassID=Classes.ClassID");
                    //String strSql = String.Format(@"select * from Students left join Classes on Students.ClassID=Classes.ClassID");
                    //String strSql = String.Format(@"select * from Students;");
                    //SqlCommand sqlCommand = new SqlCommand();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSql, sqlConnection);
                    DataTable dataTable = new DataTable();
                    dataTable.Clear();
                    sqlDataAdapter.Fill(dataTable);
                    metroGrid.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MetroFramework.MetroMessageBox.Show(this, errorMessages.ToString());
            }
        }

        //        private void Form1_Load(object sender, EventArgs e)
        //        {
        //            try
        //            {
        //                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
        //                {
        //                    if (db.State == ConnectionState.Closed)
        //                        db.Open();
        //                    String strSql = String.Format(@"lect Students.StudentCode, Students.StudentCode, Students.StudentName, Students.Birthday, Students.Gender, Students.StudentAddress, Students.ImageUrl, Students.EnrolledScore, Classes.ClassDesc from Students left join Classes on Students.ClassID=Classes.ClassID
        //");
        //                    studentBindingSource.DataSource = db.Query<Student>(strSql, commandType: CommandType.Text);

        //                    //Load classes'name to combobox cboClass
        //                    classBindingSource.DataSource = db.Query<Class>("select * from Classes", commandType: CommandType.Text);

        //                    pContainer.Enabled = false;
        //                    //pContainer.Enabled = true;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        //private void BtnAdd_Click(object sender, EventArgs e)
        //{
        //    objState = EntityState.Added;
        //    pic.Image = null;
        //    pContainer.Enabled = true;
        //    studentBindingSource.Add(new Student());
        //    studentBindingSource.MoveLast();
        //    txtStudentCode.Focus();
        //}

        //private void BtnCancel_Click(object sender, EventArgs e)
        //{
        //    pContainer.Enabled = false;
        //    studentBindingSource.ResetBindings(false);
        //    ClearInput();
        //}

        //private void BtnEdit_Click(object sender, EventArgs e)
        //{
        //    objState = EntityState.Changed;
        //    pContainer.Enabled = true;
        //    txtStudentCode.Focus();
        //}

        //private void MetroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        Student obj = studentBindingSource.Current as Student;
        //        if (obj != null)
        //        {
        //            if (!string.IsNullOrEmpty(obj.ImageUrl))
        //                pic.Image = Image.FromFile(obj.ImageUrl);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        //private void BtnDelete_Click(object sender, EventArgs e)
        //{
        //    objState = EntityState.Deleted;
        //    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that  you want to delete it?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            Student obj = studentBindingSource.Current as Student;
        //            if (obj != null)
        //            {
        //                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
        //                {
        //                    if (db.State == ConnectionState.Closed)
        //                        db.Open();
        //                    //int result = db.Execute("delete from Students where StudentID = @StudentID", new { StudentID = obj.StudentID }, commandType: CommandType.Text);
        //                    int result = db.Execute("sp_Students_Delete", new { StudentID = obj.StudentID }, commandType: CommandType.StoredProcedure);
        //                    if (result != 0)
        //                    {
        //                        studentBindingSource.RemoveCurrent();
        //                        pContainer.Enabled = false;
        //                        pic.Image = null;
        //                        objState = EntityState.Unchanged;
        //                    }

        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //private void BtnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        studentBindingSource.EndEdit();
        //        Student obj = studentBindingSource.Current as Student;
        //        if (obj != null)
        //        {
        //            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
        //            {
        //                if (db.State == ConnectionState.Closed)
        //                    db.Open();
        //                if (objState == EntityState.Added)
        //                {
        //                    DynamicParameters p = new DynamicParameters();
        //                    p.Add("@StudentID", dbType: DbType.Int32, direction: ParameterDirection.Output);
        //                    p.AddDynamicParams(new { StudentCode = obj.StudentCode, StudentName = obj.StudentName, Birthday = obj.Birthday, Gender = obj.Gender, Email = obj.Email, Address = obj.StudentAddress, ImageUrl = obj.ImageUrl, ClassID = obj.ClassID, EnrolledScore = obj.EnrolledScore });
        //                    db.Execute("sp_Students_Insert", p, commandType: CommandType.StoredProcedure);
        //                    obj.StudentID = p.Get<int>("@StudentID");
        //                }
        //                else if (objState == EntityState.Changed)
        //                {
        //                    db.Execute("sp_Students_Update", new { StudentID = obj.StudentID, StudentCode = obj.StudentCode, StudentName = obj.StudentName, Birthday = obj.Birthday, Gender = obj.Gender, Email = obj.Email, Address = obj.StudentAddress, ImageUrl = obj.ImageUrl, ClassID = obj.ClassID, EnrolledScore = obj.EnrolledScore }, commandType: CommandType.StoredProcedure);
        //                }
        //                metroGrid.Refresh();
        //                pContainer.Enabled = false;
        //                objState = EntityState.Unchanged;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            metroGrid.Refresh();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FStudent_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }
    }
}

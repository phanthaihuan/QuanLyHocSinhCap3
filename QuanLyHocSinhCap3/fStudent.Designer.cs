namespace QuanLyHocSinhCap3
{
    partial class fStudent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pContainer = new MetroFramework.Controls.MetroPanel();
            this.cboClass = new MetroFramework.Controls.MetroComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkGender = new MetroFramework.Controls.MetroCheckBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtEnrolledScore = new MetroFramework.Controls.MetroTextBox();
            this.txtClassID = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtBirthday = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentName = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentCode = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel6 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel8 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel7 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.ID = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolledScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentCodeDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.enrolledScoreDataGridViewTextBoxColumn,
            this.ClassID});
            this.metroGrid.DataSource = this.studentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(29, 75);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(710, 412);
            this.metroGrid.TabIndex = 0;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid_CellClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(QuanLyHocSinhCap3.Student);
            // 
            // pContainer
            // 
            this.pContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pContainer.Controls.Add(this.cboClass);
            this.pContainer.Controls.Add(this.chkGender);
            this.pContainer.Controls.Add(this.txtAddress);
            this.pContainer.Controls.Add(this.txtEnrolledScore);
            this.pContainer.Controls.Add(this.txtClassID);
            this.pContainer.Controls.Add(this.txtEmail);
            this.pContainer.Controls.Add(this.txtBirthday);
            this.pContainer.Controls.Add(this.txtStudentName);
            this.pContainer.Controls.Add(this.txtStudentID);
            this.pContainer.Controls.Add(this.txtStudentCode);
            this.pContainer.Controls.Add(this.htmlLabel6);
            this.pContainer.Controls.Add(this.htmlLabel8);
            this.pContainer.Controls.Add(this.htmlLabel7);
            this.pContainer.Controls.Add(this.htmlLabel5);
            this.pContainer.Controls.Add(this.htmlLabel4);
            this.pContainer.Controls.Add(this.htmlLabel3);
            this.pContainer.Controls.Add(this.htmlLabel2);
            this.pContainer.Controls.Add(this.ID);
            this.pContainer.Controls.Add(this.htmlLabel1);
            this.pContainer.Controls.Add(this.btnBrowse);
            this.pContainer.Controls.Add(this.pic);
            this.pContainer.HorizontalScrollbarBarColor = true;
            this.pContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pContainer.HorizontalScrollbarSize = 10;
            this.pContainer.Location = new System.Drawing.Point(745, 75);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(515, 412);
            this.pContainer.TabIndex = 1;
            this.pContainer.VerticalScrollbarBarColor = true;
            this.pContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pContainer.VerticalScrollbarSize = 10;
            // 
            // cboClass
            // 
            this.cboClass.DataSource = this.classBindingSource;
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.FormattingEnabled = true;
            this.cboClass.ItemHeight = 23;
            this.cboClass.Location = new System.Drawing.Point(314, 191);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(181, 29);
            this.cboClass.TabIndex = 7;
            this.cboClass.UseSelectable = true;
            this.cboClass.ValueMember = "ClassID";
            // 
            // chkGender
            // 
            this.chkGender.AutoSize = true;
            this.chkGender.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.studentBindingSource, "Gender", true));
            this.chkGender.Location = new System.Drawing.Point(314, 137);
            this.chkGender.Name = "chkGender";
            this.chkGender.Size = new System.Drawing.Size(38, 15);
            this.chkGender.TabIndex = 6;
            this.chkGender.Text = "???";
            this.chkGender.UseSelectable = true;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(101, 101);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Address", true));
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(314, 263);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(181, 103);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEnrolledScore
            // 
            // 
            // 
            // 
            this.txtEnrolledScore.CustomButton.Image = null;
            this.txtEnrolledScore.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtEnrolledScore.CustomButton.Name = "";
            this.txtEnrolledScore.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnrolledScore.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnrolledScore.CustomButton.TabIndex = 1;
            this.txtEnrolledScore.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnrolledScore.CustomButton.UseSelectable = true;
            this.txtEnrolledScore.CustomButton.Visible = false;
            this.txtEnrolledScore.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "EnrolledScore", true));
            this.txtEnrolledScore.Lines = new string[0];
            this.txtEnrolledScore.Location = new System.Drawing.Point(314, 230);
            this.txtEnrolledScore.MaxLength = 32767;
            this.txtEnrolledScore.Name = "txtEnrolledScore";
            this.txtEnrolledScore.PasswordChar = '\0';
            this.txtEnrolledScore.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnrolledScore.SelectedText = "";
            this.txtEnrolledScore.SelectionLength = 0;
            this.txtEnrolledScore.SelectionStart = 0;
            this.txtEnrolledScore.ShortcutsEnabled = true;
            this.txtEnrolledScore.Size = new System.Drawing.Size(181, 23);
            this.txtEnrolledScore.TabIndex = 5;
            this.txtEnrolledScore.UseSelectable = true;
            this.txtEnrolledScore.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnrolledScore.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClassID
            // 
            // 
            // 
            // 
            this.txtClassID.CustomButton.Image = null;
            this.txtClassID.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtClassID.CustomButton.Name = "";
            this.txtClassID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClassID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClassID.CustomButton.TabIndex = 1;
            this.txtClassID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClassID.CustomButton.UseSelectable = true;
            this.txtClassID.CustomButton.Visible = false;
            this.txtClassID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ClassID", true));
            this.txtClassID.Lines = new string[0];
            this.txtClassID.Location = new System.Drawing.Point(59, 339);
            this.txtClassID.MaxLength = 32767;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.PasswordChar = '\0';
            this.txtClassID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClassID.SelectedText = "";
            this.txtClassID.SelectionLength = 0;
            this.txtClassID.SelectionStart = 0;
            this.txtClassID.ShortcutsEnabled = true;
            this.txtClassID.Size = new System.Drawing.Size(181, 23);
            this.txtClassID.TabIndex = 5;
            this.txtClassID.UseSelectable = true;
            this.txtClassID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClassID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Email", true));
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(314, 162);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(181, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBirthday
            // 
            // 
            // 
            // 
            this.txtBirthday.CustomButton.Image = null;
            this.txtBirthday.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtBirthday.CustomButton.Name = "";
            this.txtBirthday.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBirthday.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBirthday.CustomButton.TabIndex = 1;
            this.txtBirthday.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBirthday.CustomButton.UseSelectable = true;
            this.txtBirthday.CustomButton.Visible = false;
            this.txtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Birthday", true));
            this.txtBirthday.Lines = new string[0];
            this.txtBirthday.Location = new System.Drawing.Point(314, 104);
            this.txtBirthday.MaxLength = 32767;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.PasswordChar = '\0';
            this.txtBirthday.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirthday.SelectedText = "";
            this.txtBirthday.SelectionLength = 0;
            this.txtBirthday.SelectionStart = 0;
            this.txtBirthday.ShortcutsEnabled = true;
            this.txtBirthday.Size = new System.Drawing.Size(181, 23);
            this.txtBirthday.TabIndex = 5;
            this.txtBirthday.UseSelectable = true;
            this.txtBirthday.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBirthday.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentName
            // 
            // 
            // 
            // 
            this.txtStudentName.CustomButton.Image = null;
            this.txtStudentName.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtStudentName.CustomButton.Name = "";
            this.txtStudentName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentName.CustomButton.TabIndex = 1;
            this.txtStudentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentName.CustomButton.UseSelectable = true;
            this.txtStudentName.CustomButton.Visible = false;
            this.txtStudentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentName", true));
            this.txtStudentName.Lines = new string[0];
            this.txtStudentName.Location = new System.Drawing.Point(314, 75);
            this.txtStudentName.MaxLength = 32767;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.SelectionLength = 0;
            this.txtStudentName.SelectionStart = 0;
            this.txtStudentName.ShortcutsEnabled = true;
            this.txtStudentName.Size = new System.Drawing.Size(181, 23);
            this.txtStudentName.TabIndex = 5;
            this.txtStudentName.UseSelectable = true;
            this.txtStudentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentID
            // 
            // 
            // 
            // 
            this.txtStudentID.CustomButton.Image = null;
            this.txtStudentID.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtStudentID.CustomButton.Name = "";
            this.txtStudentID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentID.CustomButton.TabIndex = 1;
            this.txtStudentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentID.CustomButton.UseSelectable = true;
            this.txtStudentID.CustomButton.Visible = false;
            this.txtStudentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentID", true));
            this.txtStudentID.Lines = new string[0];
            this.txtStudentID.Location = new System.Drawing.Point(314, 17);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.SelectionLength = 0;
            this.txtStudentID.SelectionStart = 0;
            this.txtStudentID.ShortcutsEnabled = true;
            this.txtStudentID.Size = new System.Drawing.Size(181, 23);
            this.txtStudentID.TabIndex = 5;
            this.txtStudentID.UseSelectable = true;
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentCode
            // 
            // 
            // 
            // 
            this.txtStudentCode.CustomButton.Image = null;
            this.txtStudentCode.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtStudentCode.CustomButton.Name = "";
            this.txtStudentCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentCode.CustomButton.TabIndex = 1;
            this.txtStudentCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentCode.CustomButton.UseSelectable = true;
            this.txtStudentCode.CustomButton.Visible = false;
            this.txtStudentCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentCode", true));
            this.txtStudentCode.Lines = new string[0];
            this.txtStudentCode.Location = new System.Drawing.Point(314, 46);
            this.txtStudentCode.MaxLength = 32767;
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.PasswordChar = '\0';
            this.txtStudentCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentCode.SelectedText = "";
            this.txtStudentCode.SelectionLength = 0;
            this.txtStudentCode.SelectionStart = 0;
            this.txtStudentCode.ShortcutsEnabled = true;
            this.txtStudentCode.Size = new System.Drawing.Size(181, 23);
            this.txtStudentCode.TabIndex = 5;
            this.txtStudentCode.UseSelectable = true;
            this.txtStudentCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel6
            // 
            this.htmlLabel6.AutoScroll = true;
            this.htmlLabel6.AutoScrollMinSize = new System.Drawing.Size(45, 23);
            this.htmlLabel6.AutoSize = false;
            this.htmlLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel6.Location = new System.Drawing.Point(216, 263);
            this.htmlLabel6.Name = "htmlLabel6";
            this.htmlLabel6.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel6.TabIndex = 4;
            this.htmlLabel6.Text = "Địa chỉ";
            // 
            // htmlLabel8
            // 
            this.htmlLabel8.AutoScroll = true;
            this.htmlLabel8.AutoScrollMinSize = new System.Drawing.Size(51, 23);
            this.htmlLabel8.AutoSize = false;
            this.htmlLabel8.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel8.Location = new System.Drawing.Point(216, 230);
            this.htmlLabel8.Name = "htmlLabel8";
            this.htmlLabel8.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel8.TabIndex = 4;
            this.htmlLabel8.Text = "Điểm thi";
            // 
            // htmlLabel7
            // 
            this.htmlLabel7.AutoScroll = true;
            this.htmlLabel7.AutoScrollMinSize = new System.Drawing.Size(75, 23);
            this.htmlLabel7.AutoSize = false;
            this.htmlLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel7.Location = new System.Drawing.Point(216, 191);
            this.htmlLabel7.Name = "htmlLabel7";
            this.htmlLabel7.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel7.TabIndex = 4;
            this.htmlLabel7.Text = "Đang học lớp";
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(38, 23);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Location = new System.Drawing.Point(216, 162);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel5.TabIndex = 4;
            this.htmlLabel5.Text = "Email";
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(51, 23);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(216, 133);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel4.TabIndex = 4;
            this.htmlLabel4.Text = "Giới tính";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(60, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(216, 104);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel3.TabIndex = 4;
            this.htmlLabel3.Text = "Ngày sinh";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(74, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(216, 75);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel2.TabIndex = 4;
            this.htmlLabel2.Text = "Tên học sinh";
            // 
            // ID
            // 
            this.ID.AutoScroll = true;
            this.ID.AutoScrollMinSize = new System.Drawing.Size(21, 23);
            this.ID.AutoSize = false;
            this.ID.BackColor = System.Drawing.SystemColors.Window;
            this.ID.Location = new System.Drawing.Point(216, 17);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(75, 23);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(70, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(216, 46);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 4;
            this.htmlLabel1.Text = "Mã học sinh";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(59, 231);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(102, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Thêm hình ảnh";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(10, 17);
            this.pic.MaximumSize = new System.Drawing.Size(200, 200);
            this.pic.MinimumSize = new System.Drawing.Size(200, 200);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(200, 200);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1195, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1105, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1015, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(925, 493);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(835, 493);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(745, 493);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm tươi";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(656, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Frozen = true;
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // studentCodeDataGridViewTextBoxColumn
            // 
            this.studentCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.studentCodeDataGridViewTextBoxColumn.DataPropertyName = "StudentCode";
            this.studentCodeDataGridViewTextBoxColumn.Frozen = true;
            this.studentCodeDataGridViewTextBoxColumn.HeaderText = "Mã học sinh";
            this.studentCodeDataGridViewTextBoxColumn.Name = "studentCodeDataGridViewTextBoxColumn";
            this.studentCodeDataGridViewTextBoxColumn.Width = 20;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Frozen = true;
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Tên học sinh";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 20;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Frozen = true;
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 20;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.Frozen = true;
            this.genderDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genderDataGridViewTextBoxColumn.Width = 10;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.Frozen = true;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 20;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // enrolledScoreDataGridViewTextBoxColumn
            // 
            this.enrolledScoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.enrolledScoreDataGridViewTextBoxColumn.DataPropertyName = "EnrolledScore";
            this.enrolledScoreDataGridViewTextBoxColumn.HeaderText = "Điểm trúng tuyển";
            this.enrolledScoreDataGridViewTextBoxColumn.Name = "enrolledScoreDataGridViewTextBoxColumn";
            this.enrolledScoreDataGridViewTextBoxColumn.Width = 20;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "ClassID";
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            // 
            // fStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1283, 557);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "fStudents";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "THÔNG TIN HỌC SINH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroPanel pContainer;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtEnrolledScore;
        private MetroFramework.Controls.MetroTextBox txtClassID;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtBirthday;
        private MetroFramework.Controls.MetroTextBox txtStudentName;
        private MetroFramework.Controls.MetroTextBox txtStudentCode;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel6;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel8;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel7;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox pic;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Drawing.Html.HtmlLabel ID;
        private MetroFramework.Controls.MetroCheckBox chkGender;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroComboBox cboClass;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrolledScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
    }
}


namespace CourseEnrolmentSystem
{
    partial class Form1
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
            this.clearButton = new System.Windows.Forms.Button();
            this.subject1 = new System.Windows.Forms.ComboBox();
            this.subject4 = new System.Windows.Forms.ComboBox();
            this.subject3 = new System.Windows.Forms.ComboBox();
            this.subject2 = new System.Windows.Forms.ComboBox();
            this.gradeSubject1 = new System.Windows.Forms.ComboBox();
            this.gradeSubject5 = new System.Windows.Forms.ComboBox();
            this.gradeSubject4 = new System.Windows.Forms.ComboBox();
            this.gradeSubject3 = new System.Windows.Forms.ComboBox();
            this.gradeSubject2 = new System.Windows.Forms.ComboBox();
            this.subject5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availableCourse = new System.Windows.Forms.Label();
            this.GetCourseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1078, 578);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(121, 36);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // subject1
            // 
            this.subject1.FormattingEnabled = true;
            this.subject1.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.subject1.Location = new System.Drawing.Point(121, 144);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(197, 28);
            this.subject1.TabIndex = 2;
            // 
            // subject4
            // 
            this.subject4.FormattingEnabled = true;
            this.subject4.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.subject4.Location = new System.Drawing.Point(121, 321);
            this.subject4.Name = "subject4";
            this.subject4.Size = new System.Drawing.Size(197, 28);
            this.subject4.TabIndex = 4;
            // 
            // subject3
            // 
            this.subject3.FormattingEnabled = true;
            this.subject3.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.subject3.Location = new System.Drawing.Point(121, 259);
            this.subject3.Name = "subject3";
            this.subject3.Size = new System.Drawing.Size(197, 28);
            this.subject3.TabIndex = 5;
            // 
            // subject2
            // 
            this.subject2.FormattingEnabled = true;
            this.subject2.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.subject2.Location = new System.Drawing.Point(121, 202);
            this.subject2.Name = "subject2";
            this.subject2.Size = new System.Drawing.Size(197, 28);
            this.subject2.TabIndex = 6;
            // 
            // gradeSubject1
            // 
            this.gradeSubject1.FormattingEnabled = true;
            this.gradeSubject1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.gradeSubject1.Location = new System.Drawing.Point(368, 144);
            this.gradeSubject1.Name = "gradeSubject1";
            this.gradeSubject1.Size = new System.Drawing.Size(99, 28);
            this.gradeSubject1.TabIndex = 7;
            // 
            // gradeSubject5
            // 
            this.gradeSubject5.FormattingEnabled = true;
            this.gradeSubject5.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.gradeSubject5.Location = new System.Drawing.Point(368, 389);
            this.gradeSubject5.Name = "gradeSubject5";
            this.gradeSubject5.Size = new System.Drawing.Size(99, 28);
            this.gradeSubject5.TabIndex = 8;
            // 
            // gradeSubject4
            // 
            this.gradeSubject4.FormattingEnabled = true;
            this.gradeSubject4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.gradeSubject4.Location = new System.Drawing.Point(368, 321);
            this.gradeSubject4.Name = "gradeSubject4";
            this.gradeSubject4.Size = new System.Drawing.Size(99, 28);
            this.gradeSubject4.TabIndex = 9;
            // 
            // gradeSubject3
            // 
            this.gradeSubject3.FormattingEnabled = true;
            this.gradeSubject3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.gradeSubject3.Location = new System.Drawing.Point(368, 259);
            this.gradeSubject3.Name = "gradeSubject3";
            this.gradeSubject3.Size = new System.Drawing.Size(99, 28);
            this.gradeSubject3.TabIndex = 10;
            // 
            // gradeSubject2
            // 
            this.gradeSubject2.FormattingEnabled = true;
            this.gradeSubject2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.gradeSubject2.Location = new System.Drawing.Point(368, 202);
            this.gradeSubject2.Name = "gradeSubject2";
            this.gradeSubject2.Size = new System.Drawing.Size(99, 28);
            this.gradeSubject2.TabIndex = 11;
            // 
            // subject5
            // 
            this.subject5.FormattingEnabled = true;
            this.subject5.Items.AddRange(new object[] {
            "Computer Science",
            "Maths",
            "English",
            "French",
            "Accounts",
            "Physics"});
            this.subject5.Location = new System.Drawing.Point(121, 389);
            this.subject5.Name = "subject5";
            this.subject5.Size = new System.Drawing.Size(197, 28);
            this.subject5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Subjects";
            // 
            // availableCourse
            // 
            this.availableCourse.AutoSize = true;
            this.availableCourse.Location = new System.Drawing.Point(1036, 90);
            this.availableCourse.Name = "availableCourse";
            this.availableCourse.Size = new System.Drawing.Size(127, 20);
            this.availableCourse.TabIndex = 15;
            this.availableCourse.Text = "Available Course";
            // 
            // GetCourseButton
            // 
            this.GetCourseButton.Location = new System.Drawing.Point(902, 578);
            this.GetCourseButton.Name = "GetCourseButton";
            this.GetCourseButton.Size = new System.Drawing.Size(116, 36);
            this.GetCourseButton.TabIndex = 16;
            this.GetCourseButton.Text = "Get Course";
            this.GetCourseButton.UseVisualStyleBackColor = true;
            this.GetCourseButton.Click += new System.EventHandler(this.GetCourseButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(873, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 290);
            this.tableLayoutPanel1.TabIndex = 17;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 877);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GetCourseButton);
            this.Controls.Add(this.availableCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subject5);
            this.Controls.Add(this.gradeSubject2);
            this.Controls.Add(this.gradeSubject3);
            this.Controls.Add(this.gradeSubject4);
            this.Controls.Add(this.gradeSubject5);
            this.Controls.Add(this.gradeSubject1);
            this.Controls.Add(this.subject2);
            this.Controls.Add(this.subject3);
            this.Controls.Add(this.subject4);
            this.Controls.Add(this.subject1);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Course Enrolment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox subject1;
        private System.Windows.Forms.ComboBox subject4;
        private System.Windows.Forms.ComboBox subject3;
        private System.Windows.Forms.ComboBox subject2;
        private System.Windows.Forms.ComboBox gradeSubject1;
        private System.Windows.Forms.ComboBox gradeSubject5;
        private System.Windows.Forms.ComboBox gradeSubject4;
        private System.Windows.Forms.ComboBox gradeSubject3;
        private System.Windows.Forms.ComboBox gradeSubject2;
        private System.Windows.Forms.ComboBox subject5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label availableCourse;
        private System.Windows.Forms.Button GetCourseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}


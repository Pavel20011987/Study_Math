namespace Обучающе_тестирующая_программа__Математика_
{
    partial class Student_grades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_grades));
            this.mS_Student = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебнаяПрограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dGV_Grades = new System.Windows.Forms.DataGridView();
            this.themenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathDBDataSet = new Обучающе_тестирующая_программа__Математика_.MathDBDataSet();
            this.fillForStudentToolStrip = new System.Windows.Forms.ToolStrip();
            this.userIdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userIdToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillForStudentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.view_GradesTableAdapter = new Обучающе_тестирующая_программа__Математика_.MathDBDataSetTableAdapters.View_GradesTableAdapter();
            this.mS_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Grades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathDBDataSet)).BeginInit();
            this.fillForStudentToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS_Student
            // 
            this.mS_Student.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mS_Student.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.личнаяИнформацияToolStripMenuItem,
            this.учебнаяПрограммаToolStripMenuItem,
            this.оценкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mS_Student.Location = new System.Drawing.Point(0, 0);
            this.mS_Student.Name = "mS_Student";
            this.mS_Student.Size = new System.Drawing.Size(808, 28);
            this.mS_Student.TabIndex = 8;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // личнаяИнформацияToolStripMenuItem
            // 
            this.личнаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem});
            this.личнаяИнформацияToolStripMenuItem.Name = "личнаяИнформацияToolStripMenuItem";
            this.личнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.личнаяИнформацияToolStripMenuItem.Text = "Личная информация";
            this.личнаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.личнаяИнформацияToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // учебнаяПрограммаToolStripMenuItem
            // 
            this.учебнаяПрограммаToolStripMenuItem.Name = "учебнаяПрограммаToolStripMenuItem";
            this.учебнаяПрограммаToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.учебнаяПрограммаToolStripMenuItem.Text = "Учебная программа";
            this.учебнаяПрограммаToolStripMenuItem.Click += new System.EventHandler(this.учебнаяПрограммаToolStripMenuItem_Click);
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.Enabled = false;
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.оценкиToolStripMenuItem.Text = "Оценки";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // dGV_Grades
            // 
            this.dGV_Grades.AllowUserToAddRows = false;
            this.dGV_Grades.AllowUserToDeleteRows = false;
            this.dGV_Grades.AutoGenerateColumns = false;
            this.dGV_Grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Grades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.themenameDataGridViewTextBoxColumn,
            this.testnameDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn});
            this.dGV_Grades.DataSource = this.viewGradesBindingSource;
            this.dGV_Grades.Location = new System.Drawing.Point(12, 31);
            this.dGV_Grades.Name = "dGV_Grades";
            this.dGV_Grades.ReadOnly = true;
            this.dGV_Grades.RowHeadersVisible = false;
            this.dGV_Grades.RowHeadersWidth = 51;
            this.dGV_Grades.RowTemplate.Height = 24;
            this.dGV_Grades.Size = new System.Drawing.Size(776, 407);
            this.dGV_Grades.TabIndex = 9;
            // 
            // themenameDataGridViewTextBoxColumn
            // 
            this.themenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.themenameDataGridViewTextBoxColumn.DataPropertyName = "theme_name";
            this.themenameDataGridViewTextBoxColumn.HeaderText = "Тема:";
            this.themenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.themenameDataGridViewTextBoxColumn.Name = "themenameDataGridViewTextBoxColumn";
            this.themenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testnameDataGridViewTextBoxColumn
            // 
            this.testnameDataGridViewTextBoxColumn.DataPropertyName = "test_name";
            this.testnameDataGridViewTextBoxColumn.HeaderText = "Тест:";
            this.testnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testnameDataGridViewTextBoxColumn.Name = "testnameDataGridViewTextBoxColumn";
            this.testnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.testnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Оценка:";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeDataGridViewTextBoxColumn.Width = 125;
            // 
            // viewGradesBindingSource
            // 
            this.viewGradesBindingSource.DataMember = "View_Grades";
            this.viewGradesBindingSource.DataSource = this.mathDBDataSet;
            // 
            // mathDBDataSet
            // 
            this.mathDBDataSet.DataSetName = "MathDBDataSet";
            this.mathDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillForStudentToolStrip
            // 
            this.fillForStudentToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillForStudentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIdToolStripLabel,
            this.userIdToolStripTextBox,
            this.fillForStudentToolStripButton,
            this.toolStripDropDownButton1});
            this.fillForStudentToolStrip.Location = new System.Drawing.Point(0, 30);
            this.fillForStudentToolStrip.Name = "fillForStudentToolStrip";
            this.fillForStudentToolStrip.Size = new System.Drawing.Size(808, 31);
            this.fillForStudentToolStrip.TabIndex = 10;
            this.fillForStudentToolStrip.Text = "fillForStudentToolStrip";
            this.fillForStudentToolStrip.Visible = false;
            // 
            // userIdToolStripLabel
            // 
            this.userIdToolStripLabel.Name = "userIdToolStripLabel";
            this.userIdToolStripLabel.Size = new System.Drawing.Size(54, 28);
            this.userIdToolStripLabel.Text = "UserId:";
            // 
            // userIdToolStripTextBox
            // 
            this.userIdToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userIdToolStripTextBox.Name = "userIdToolStripTextBox";
            this.userIdToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // fillForStudentToolStripButton
            // 
            this.fillForStudentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillForStudentToolStripButton.Name = "fillForStudentToolStripButton";
            this.fillForStudentToolStripButton.Size = new System.Drawing.Size(104, 28);
            this.fillForStudentToolStripButton.Text = "FillForStudent";
            this.fillForStudentToolStripButton.Click += new System.EventHandler(this.fillForStudentToolStripButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // view_GradesTableAdapter
            // 
            this.view_GradesTableAdapter.ClearBeforeFill = true;
            // 
            // Student_grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.fillForStudentToolStrip);
            this.Controls.Add(this.dGV_Grades);
            this.Controls.Add(this.mS_Student);
            this.Name = "Student_grades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценки";
            this.Load += new System.EventHandler(this.Student_grades_Load);
            this.mS_Student.ResumeLayout(false);
            this.mS_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Grades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathDBDataSet)).EndInit();
            this.fillForStudentToolStrip.ResumeLayout(false);
            this.fillForStudentToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mS_Student;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебнаяПрограммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dGV_Grades;
        private MathDBDataSet mathDBDataSet;
        private System.Windows.Forms.BindingSource viewGradesBindingSource;
        private MathDBDataSetTableAdapters.View_GradesTableAdapter view_GradesTableAdapter;
        private System.Windows.Forms.ToolStrip fillForStudentToolStrip;
        private System.Windows.Forms.ToolStripLabel userIdToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userIdToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillForStudentToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn themenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
    }
}
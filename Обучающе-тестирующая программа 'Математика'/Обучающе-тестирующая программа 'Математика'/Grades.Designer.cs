namespace Обучающе_тестирующая_программа__Математика_
{
    partial class Grades
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mS_Teacher = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебнаяПрограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_group = new System.Windows.Forms.ComboBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.MathDBDataSet2 = new Обучающе_тестирующая_программа__Математика_.MathDBDataSet2();
            this.View_GradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_GradesTableAdapter = new Обучающе_тестирующая_программа__Математика_.MathDBDataSet2TableAdapters.View_GradesTableAdapter();
            this.reportViewerGrades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mS_Teacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MathDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_GradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mS_Teacher
            // 
            this.mS_Teacher.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mS_Teacher.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.личнаяИнформацияToolStripMenuItem,
            this.учебнаяПрограммаToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.оценкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mS_Teacher.Location = new System.Drawing.Point(0, 0);
            this.mS_Teacher.Name = "mS_Teacher";
            this.mS_Teacher.Size = new System.Drawing.Size(800, 28);
            this.mS_Teacher.TabIndex = 6;
            this.mS_Teacher.Text = "menuStrip1";
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
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
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
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Группа:";
            // 
            // cB_group
            // 
            this.cB_group.FormattingEnabled = true;
            this.cB_group.Location = new System.Drawing.Point(77, 59);
            this.cB_group.Name = "cB_group";
            this.cB_group.Size = new System.Drawing.Size(121, 24);
            this.cB_group.TabIndex = 9;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(218, 54);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(103, 33);
            this.btn_view.TabIndex = 10;
            this.btn_view.Text = "Посмотреть";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // MathDBDataSet2
            // 
            this.MathDBDataSet2.DataSetName = "MathDBDataSet2";
            this.MathDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_GradesBindingSource
            // 
            this.View_GradesBindingSource.DataMember = "View_Grades";
            this.View_GradesBindingSource.DataSource = this.MathDBDataSet2;
            // 
            // View_GradesTableAdapter
            // 
            this.View_GradesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerGrades
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_GradesBindingSource;
            this.reportViewerGrades.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerGrades.LocalReport.ReportEmbeddedResource = "Обучающе_тестирующая_программа__Математика_.Report.rdlc";
            this.reportViewerGrades.Location = new System.Drawing.Point(0, 103);
            this.reportViewerGrades.Name = "reportViewerGrades";
            this.reportViewerGrades.ServerReport.BearerToken = null;
            this.reportViewerGrades.Size = new System.Drawing.Size(800, 347);
            this.reportViewerGrades.TabIndex = 11;
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerGrades);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.cB_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mS_Teacher);
            this.Name = "Grades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценки";
            this.Load += new System.EventHandler(this.Grades1_Load);
            this.mS_Teacher.ResumeLayout(false);
            this.mS_Teacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MathDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_GradesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mS_Teacher;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебнаяПрограммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_group;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.BindingSource View_GradesBindingSource;
        private MathDBDataSet2 MathDBDataSet2;
        private MathDBDataSet2TableAdapters.View_GradesTableAdapter View_GradesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGrades;
    }
}
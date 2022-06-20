namespace Обучающе_тестирующая_программа__Математика_
{
    partial class Student_curriculum
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
            this.tV_Curriculum = new System.Windows.Forms.TreeView();
            this.mS_Student = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебнаяПрограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMS_rule = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMS_test = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.пройтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMS_theme = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mS_Student.SuspendLayout();
            this.cMS_rule.SuspendLayout();
            this.cMS_test.SuspendLayout();
            this.SuspendLayout();
            // 
            // tV_Curriculum
            // 
            this.tV_Curriculum.ItemHeight = 22;
            this.tV_Curriculum.Location = new System.Drawing.Point(22, 57);
            this.tV_Curriculum.Name = "tV_Curriculum";
            this.tV_Curriculum.Size = new System.Drawing.Size(719, 352);
            this.tV_Curriculum.TabIndex = 6;
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
            this.mS_Student.Size = new System.Drawing.Size(768, 28);
            this.mS_Student.TabIndex = 7;
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
            this.учебнаяПрограммаToolStripMenuItem.Enabled = false;
            this.учебнаяПрограммаToolStripMenuItem.Name = "учебнаяПрограммаToolStripMenuItem";
            this.учебнаяПрограммаToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.учебнаяПрограммаToolStripMenuItem.Text = "Учебная программа";
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.оценкиToolStripMenuItem.Text = "Оценки";
            this.оценкиToolStripMenuItem.Click += new System.EventHandler(this.оценкиToolStripMenuItem_Click);
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
            // cMS_rule
            // 
            this.cMS_rule.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMS_rule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.cMS_rule.Name = "cMS_rule";
            this.cMS_rule.Size = new System.Drawing.Size(137, 28);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // cMS_test
            // 
            this.cMS_test.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMS_test.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пройтиToolStripMenuItem});
            this.cMS_test.Name = "cMS_test";
            this.cMS_test.Size = new System.Drawing.Size(132, 28);
            // 
            // пройтиToolStripMenuItem
            // 
            this.пройтиToolStripMenuItem.Name = "пройтиToolStripMenuItem";
            this.пройтиToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.пройтиToolStripMenuItem.Text = "Пройти";
            this.пройтиToolStripMenuItem.Click += new System.EventHandler(this.пройтиToolStripMenuItem_Click);
            // 
            // cMS_theme
            // 
            this.cMS_theme.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMS_theme.Name = "cMS_theme";
            this.cMS_theme.Size = new System.Drawing.Size(61, 4);
            // 
            // Student_curriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 438);
            this.Controls.Add(this.tV_Curriculum);
            this.Controls.Add(this.mS_Student);
            this.MainMenuStrip = this.mS_Student;
            this.Name = "Student_curriculum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебная программа";
            this.Load += new System.EventHandler(this.Student_curriculum_Load);
            this.mS_Student.ResumeLayout(false);
            this.mS_Student.PerformLayout();
            this.cMS_rule.ResumeLayout(false);
            this.cMS_test.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tV_Curriculum;
        private System.Windows.Forms.MenuStrip mS_Student;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учебнаяПрограммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMS_rule;
        private System.Windows.Forms.ContextMenuStrip cMS_test;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пройтиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMS_theme;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
    }
}
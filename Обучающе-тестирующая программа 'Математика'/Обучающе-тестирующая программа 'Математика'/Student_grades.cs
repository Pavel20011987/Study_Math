using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Обучающе_тестирующая_программа__Математика_
{
    public partial class Student_grades : Form
    {
        public Student_grades()
        {
            InitializeComponent();
        }

        private void Student_grades_Load(object sender, EventArgs e)
        {
            userIdToolStripTextBox.Text = Data.userId.ToString();
            fillForStudentToolStripButton_Click(sender, e);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mathDBDataSet.View_Grades". При необходимости она может быть перемещена или удалена.
            this.view_GradesTableAdapter.Fill(this.mathDBDataSet.View_Grades);

        }

        private void fillForStudentToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_GradesTableAdapter.FillForStudent(this.mathDBDataSet.View_Grades, ((int)(System.Convert.ChangeType(userIdToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Обучающе-тестирующая программа 'Математика'", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void личнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Student_data(Data.userId).Show();
        }

        private void учебнаяПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Student_curriculum().Show();
            this.Close();
        }
    }
}

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
    public partial class Teacher_data : Form
    {
        private int teacherId;

        public Teacher_data()
        {
            InitializeComponent();
        }

        public Teacher_data(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
        }

        private void Teacher_data_Load(object sender, EventArgs e)
        {
            string[] teacherInfo = WorkWithBD.showTeacherInfo(teacherId);
            tB_name.Text = teacherInfo[0];
            tB_login.Text = teacherInfo[1];
            tB_password.Text = teacherInfo[2];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            WorkWithBD.changeTeacher(teacherId, tB_name.Text, tB_login.Text, tB_password.Text);
            this.Close();
        }
    }
}

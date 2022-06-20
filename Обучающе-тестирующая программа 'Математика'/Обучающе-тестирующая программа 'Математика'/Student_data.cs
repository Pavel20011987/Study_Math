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
    public partial class Student_data : Form
    {
        private int studentId;

        public Student_data()
        {
            InitializeComponent();
        }

        public Student_data(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void Student_data_Load(object sender, EventArgs e)
        {
            string[] studentInfo = WorkWithBD.showStudentInfo(studentId);
            tB_name.Text = studentInfo[0];
            lbl_group.Text = studentInfo[1];
            tB_login.Text = studentInfo[2];
            tB_password.Text = studentInfo[3];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            WorkWithBD.changeStudent(studentId, tB_name.Text, lbl_group.Text, tB_login.Text, tB_password.Text);
            this.Close();
        }
    }
}

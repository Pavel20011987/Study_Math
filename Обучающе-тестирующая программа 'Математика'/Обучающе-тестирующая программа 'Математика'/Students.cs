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
    public partial class Students : Form
    {
        private int studentId = 0;

        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            studentId = 0;

            //clear tB
            tB_groupName.Clear();

            tB_studentName.Clear();
            tB_login.Clear();
            tB_password.Clear();

            cB_group.Visible = true;
            tB_group.Visible = false;
            ll_add.Visible = true;
            ll_cancel.Visible = false;

            //enable tB

            gB_group.Enabled = false;
            gB_student.Enabled = false;

            // load tV 

            studentsLoad();
            cB_group.Items.Clear();
            cB_group.Items.AddRange(WorkWithBD.getGroupNameList().ToArray());
            cB_group.Items.Insert(0, "--");
            cB_group.SelectedIndex = 0;
        }

        private void studentsLoad()
        {
            tV_Students.Nodes.Clear();

            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.group);
            imageList.Images.Add(Properties.Resources.student);

            tV_Students.ImageList = imageList;

            WorkWithBD.getGroups(tV_Students, cMS_Group, cMS_Student);

            tV_Students.ExpandAll();
            tV_Students.HideSelection = true;
        }

        private void учебнаяПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Curriculum().Show();
            this.Close();
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Grades().Show();
            this.Close();
        }

        private void btn_showStudent_Click(object sender, EventArgs e){}

        private void btn_showGroupe_Click(object sender, EventArgs e){}

        private void btn_deleteGroup_Click(object sender, EventArgs e){}

        private void btn_addGroup_Click(object sender, EventArgs e){}

        private void добавитьНовогоСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentId = 0;

            gB_group.Enabled = false;
            gB_student.Enabled = true;

            tB_studentName.Clear();
            tB_login.Clear();
            tB_password.Clear();

            cB_group.Visible = true;
            tB_group.Visible = false;
            ll_add.Visible = true;
            ll_cancel.Visible = false;

            cB_group.SelectedIndex = 0;
        }

        private void btn_saveGroup_Click(object sender, EventArgs e)
        {
            string groupNameOld = tV_Students.SelectedNode.Text;
            string groupNameNew = tB_groupName.Text;

            WorkWithBD.changeGroup(groupNameNew, groupNameOld);

            tB_groupName.Clear();
            gB_group.Enabled = false;
            Students_Load(sender, e);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_studentName.Clear();
            tB_login.Clear();
            tB_password.Clear();

            cB_group.Visible = true;
            tB_group.Visible = false;
            ll_add.Visible = true;
            ll_cancel.Visible = false;

            cB_group.SelectedIndex = 0;


            gB_student.Enabled = false;
            gB_group.Enabled = true;

            tB_groupName.Text = tV_Students.SelectedNode.Text;
        }

        private void btn_saveStudent_Click(object sender, EventArgs e)
        {
            //hard code

            string studentName = tB_studentName.Text;
            string login = tB_login.Text;
            string password = tB_password.Text;
            string group;

            if (tB_group.Visible)
            {
                group = tB_group.Text;
            }
            else
            {
                group = cB_group.SelectedItem.ToString();
            }

            if(studentId == 0)
            {
                WorkWithBD.addStudent(studentName, group, login, password);
            }
            else
            {
                WorkWithBD.changeStudent(studentId, studentName, group, login, password);
            }
            Students_Load(sender, e);

            tB_studentName.Clear();
            tB_login.Clear();
            tB_password.Clear();

            cB_group.Visible = true;
            tB_group.Visible = false;
            ll_add.Visible = true;
            ll_cancel.Visible = false;

            cB_group.SelectedIndex = 0;

            gB_student.Enabled = false;
            Students_Load(sender, e);
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tB_groupName.Clear();

            studentId = Convert.ToInt32(tV_Students.SelectedNode.Tag.ToString());

            string[] studentInfo = WorkWithBD.showStudentInfo(studentId);
            tB_studentName.Text = studentInfo[0];
            cB_group.SelectedItem = studentInfo[1];
            tB_login.Text = studentInfo[2];
            tB_password.Text = studentInfo[3];

            gB_group.Enabled = false;
            gB_student.Enabled = true;
        }

        private void ll_add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cB_group.Visible = false;
            tB_group.Visible = true;
            ll_add.Visible = false;
            ll_cancel.Visible = true;
        }

        private void ll_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cB_group.Visible = true;
            tB_group.Visible = false;
            ll_add.Visible = true;
            ll_cancel.Visible = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Обучающе-тестирующая программа 'Математика'", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Teacher_data(Data.userId).Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string group = tV_Students.SelectedNode.Text;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить группу '" + group + "'?\nВнимание! При удалении группы будут удалены также все студенты в ней!", "Удаление группы", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                WorkWithBD.deleteGroup(group);
            }

            Students_Load(sender, e);
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить студента '" + tV_Students.SelectedNode.Text + "'?!", "Удаление студента", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                WorkWithBD.deleteStudent(Convert.ToInt32(tV_Students.SelectedNode.Tag));
            }

            Students_Load(sender, e);
        }

        private void личнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

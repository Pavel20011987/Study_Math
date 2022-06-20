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
    public partial class Curriculum : Form
    {
        public Curriculum()
        {
            InitializeComponent();
        }

        private void Curriculum_Load(object sender, EventArgs e)
        {
            curriculumLoad();

        }

        private void curriculumLoad()
        {
            tV_Curriculum.Nodes.Clear();

            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.folder);
            imageList.Images.Add(Properties.Resources.book);
            imageList.Images.Add(Properties.Resources.pen);

            tV_Curriculum.ImageList = imageList;

            WorkWithBD.getCurriculum(tV_Curriculum, cMS_theme, cMS_rule, cMS_test);

            tV_Curriculum.ExpandAll();
            tV_Curriculum.HideSelection = true;
        }

        private void изменитьНазваниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int themeId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);
            string themeName = Convert.ToString(tV_Curriculum.SelectedNode.Text);

            new Change_theme_name(this, themeId, themeName).Show();
        }

        private void добавитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int themeId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);
            new Test_creating(themeId).Show();
            this.Close();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int themeId = Convert.ToInt32(tV_Curriculum.SelectedNode.Parent.Tag);
            int testId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);
            string testName = tV_Curriculum.SelectedNode.Text;
            new Test_creating(themeId, testName, testId).Show();
            this.Close();
        }

        private void btn_addTheme_Click(object sender, EventArgs e)
        {
            new Add_theme(this).Show();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить тест '" + tV_Curriculum.SelectedNode.Text + "'?\nВнимание! При удалении теста будут удалены также все оценки полученные за него!", "Удаление теста", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int testId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);
                WorkWithBD.deleteTest(testId);
                curriculumLoad();
            }
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить тему '" + tV_Curriculum.SelectedNode.Text + "'?\nВнимание! При удалении темы будут удалены также все тесты и правила в ней!", "Удаление темы", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int themeId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);
                WorkWithBD.deleteTheme(themeId);
                curriculumLoad();
            }
        }

        private void добавитьТемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int themeId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);

            new Add_rule(themeId).Show();
            this.Close();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить правило '" + tV_Curriculum.SelectedNode.Text + "'?", "Удаление правила", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int ruleId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag); 

                WorkWithBD.deleteRule(ruleId);
                curriculumLoad();
            }
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e){}

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Обучающе-тестирующая программа 'Математика'", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Grades().Show();
            this.Close();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Students().Show();
            this.Close();
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int themeId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);
            int ruleId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);

            new Add_rule(themeId, ruleId).Show();
            this.Close();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Teacher_data(Data.userId).Show();
        }
    }
}

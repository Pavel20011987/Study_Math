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
    public partial class Test : Form
    {
        private int testId;
        private int currantQuestion = 1;
        private int qwNumber;
        private List<string[]> questions;

        public Test()
        {
            InitializeComponent();
        }

        public Test(int testId)
        {
            InitializeComponent();
            this.testId = testId;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            questions = WorkWithBD.getQuestionsInArray(testId);
            qwNumber = Convert.ToInt32(questions.Last()[0]);
            questions.RemoveAt(questions.Count - 1);

            lbl_allQstNumber.Text = qwNumber.ToString();

            //first question
            showQuestion();
        }

        private void showQuestion()
        {
            lbl_qstNumber.Text = currantQuestion.ToString();
            lbl_qst.Text = questions[currantQuestion - 1][0];
            lbl_point.Text = questions[currantQuestion - 1][3];

            cLB_answ.Items.Clear();
            tB_answ.Clear();

            string answType = questions[currantQuestion - 1][1];
            if (answType == "Выбор вариантов")
            {
                tB_answ.Visible = false;
                cLB_answ.Visible = true;
                cLB_answ.Items.AddRange(questions[currantQuestion - 1][2].TrimEnd('\n').Split('\n'));
            }
            if (answType == "Свободный ввод")
            {
                cLB_answ.Visible = false;
                tB_answ.Visible = true;
            }

            string studentAnsw = questions[currantQuestion - 1][5];

            if (studentAnsw != "")
            {
                if (answType == "Выбор вариантов")
                {
                    string[] answers = studentAnsw.Split('\n');
                    foreach (string answer in answers)
                    {
                        for (int j = 0; j < cLB_answ.Items.Count; j++)
                        {
                            if (cLB_answ.Items[j].ToString().Equals(answer.TrimEnd('\n')))
                            {
                                cLB_answ.SetItemChecked(cLB_answ.Items.IndexOf(cLB_answ.Items[j]), true);
                            }
                        }
                    }
                }
                if (answType == "Свободный ввод")
                {
                    tB_answ.Text = studentAnsw;
                }
            }
        }

        private void saveQuestion()
        {
            string studentAnsw = "";
            if (cLB_answ.Visible)
            {
                foreach (int indexChecked in cLB_answ.CheckedIndices)
                {
                    string itemCheked = cLB_answ.Items[indexChecked].ToString();
                    studentAnsw += itemCheked + "\n";
                }
                studentAnsw = studentAnsw.TrimEnd('\n');
            }

            if (tB_answ.Visible)
            {
                studentAnsw = tB_answ.Text.TrimStart().TrimEnd();
            }

            questions[currantQuestion - 1][5] = studentAnsw;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            saveQuestion();

            if (qwNumber > currantQuestion)
            {
                currantQuestion = ++currantQuestion;
                showQuestion();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            saveQuestion();

            if (currantQuestion > 1)
            {
                currantQuestion = --currantQuestion;
                showQuestion();
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            saveQuestion();

            //COUT RESULTS!!!
            int maxPoints = 0;
            for (int i= 0; i < questions.Count; i++)
            {
                maxPoints += Convert.ToInt32(questions[i][3]);
            }

            int studentsPoints = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i][4].ToLower().TrimStart().TrimEnd().Equals(questions[i][5].ToLower().TrimStart().TrimEnd()))
                {
                    studentsPoints += Convert.ToInt32(questions[i][3]);
                }
            }

            decimal counting = ((decimal) 10 * studentsPoints) / maxPoints;
            int grade =(int) Math.Round(counting, MidpointRounding.AwayFromZero);

            WorkWithBD.saveGrade(testId, grade);
            MessageBox.Show("Тест завершен! Ваша оценка: " + grade.ToString());

            new Student_curriculum().Show();
            this.Close();
        }
    }
}

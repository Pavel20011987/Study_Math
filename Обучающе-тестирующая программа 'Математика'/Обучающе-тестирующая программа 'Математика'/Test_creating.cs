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
    public partial class Test_creating : Form
    {
        private int themeId = 0;
        private int testId = 0;
        private int questionId = 0;

        public Test_creating()
        {
            InitializeComponent();
        }

        public Test_creating(int themeId)
        {
            InitializeComponent();
            this.themeId = themeId;
        }

        public Test_creating(int themeId, string testName, int testId)
        {
            InitializeComponent();
            this.themeId = themeId;
            this.testId = testId;

            tB_testName.Text = testName;

            btn_saveTestInfo.Enabled = false;
            btn_changeTestInfo.Enabled = true;

            WorkWithBD.showQuestions(testId, dGV_test);
        }

        private void Test_creating_Load(object sender, EventArgs e)
        {
            cB_answerType.Items.AddRange(Data.answerType);
            cB_answerType.SelectedIndex = 0;
        }

        private void btn_saveTestInfo_Click(object sender, EventArgs e)
        {
            string testName = tB_testName.Text;
            
            if (!string.IsNullOrEmpty(testName) && !string.IsNullOrWhiteSpace(testName))
            {
                testId = WorkWithBD.addTest(testName, themeId);

                btn_saveTestInfo.Enabled = false;
                btn_changeTestInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Укажите название теста!");
            }
        }

        private void btn_saveQuestion_Click(object sender, EventArgs e)
        {
            if (testId!=0)
            {
                string question = tB_question.Text;
                string answerType = cB_answerType.SelectedItem.ToString();
                string answerVariant = tB_answerVariant.Text;
                string answerRight = tB_answerRight.Text;
                int point = Convert.ToInt32(nUD_point.Value);

                if (!string.IsNullOrEmpty(question) && !string.IsNullOrWhiteSpace(question) &&           //....
                    !string.IsNullOrEmpty(answerRight) && !string.IsNullOrWhiteSpace(answerRight))
                {
                    if (!(point <= 0))                                                                   //общие
                    {

                        if (answerType == "Выбор вариантов" && 
                            (string.IsNullOrEmpty(answerVariant) && string.IsNullOrWhiteSpace(answerVariant)))
                        {
                            MessageBox.Show("При выборе типа ответа 'Выбор вариантов' необходимо указать варианты ответа!");
                        }
                        else
                        {
                            if (answerType == "Свободный ввод" &&
                                    (!string.IsNullOrEmpty(answerVariant) && !string.IsNullOrWhiteSpace(answerVariant)))
                            {
                                MessageBox.Show("При выборе типа ответа 'Свободный ввод' нельзя указывать варианты ответа!");
                            }
                            else
                            {
                                if (questionId == 0) //добовляем новый вопрос
                                {
                                    WorkWithBD.addQuestion(question, answerType, answerVariant, answerRight, point, testId);
                                    WorkWithBD.showQuestions(testId, dGV_test);

                                    tB_question.Clear();
                                    cB_answerType.SelectedIndex = 0;
                                    tB_answerVariant.Clear();
                                    tB_answerRight.Clear();
                                    nUD_point.Value = 0;
                                }
                                else //изменяем вопрос
                                {
                                    WorkWithBD.changeQuestion(question, answerType, answerVariant, answerRight, point, questionId);
                                    WorkWithBD.showQuestions(testId, dGV_test);

                                    tB_question.Clear();
                                    cB_answerType.SelectedIndex = 0;
                                    tB_answerVariant.Clear();
                                    tB_answerRight.Clear();
                                    nUD_point.Value = 0;

                                    questionId = 0;
                                }
                            }   
                        }
                    }
                    else
                    {
                        MessageBox.Show("Укажите количество баллов за вопрос!");
                    }
                }
                else
                {
                    MessageBox.Show("Поля 'Текст вопроса' и 'Правильные ответы' не могут быть пустыми!");
                }
            }
            else
            {
                MessageBox.Show("Перед созданием вопроса создайте название теста!");
            }

        }

        private void btn_changeTestInfo_Click(object sender, EventArgs e)
        {
            string testName = tB_testName.Text;
            
            if (!string.IsNullOrEmpty(testName) && !string.IsNullOrWhiteSpace(testName))
            {
                WorkWithBD.changeTest(testId, testName);
            }
            else
            {
                MessageBox.Show("Укажите название теста!");
            }
        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {
            tB_question.Clear();
            cB_answerType.SelectedIndex = 0;
            tB_answerVariant.Clear();
            tB_answerRight.Clear();
            nUD_point.Value = 0;
        }

        private void btn_changeQuestion_Click(object sender, EventArgs e)
        {
            if (dGV_test.SelectedCells.Count > 0)
            {
                int rowindex = dGV_test.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dGV_test.Rows[rowindex];

                questionId = Convert.ToInt32(selectedRow.Cells["Column_id"].Value);

                tB_question.Text = Convert.ToString(selectedRow.Cells["Column_question"].Value);
                cB_answerType.SelectedItem = Convert.ToString(selectedRow.Cells["Column_type"].Value);
                tB_answerVariant.Text = Convert.ToString(selectedRow.Cells["Column_answer"].Value);
                nUD_point.Value = Convert.ToDecimal(Convert.ToString(selectedRow.Cells["Column_point"].Value));
                tB_answerRight.Text = Convert.ToString(selectedRow.Cells["Column_right"].Value);
            }
        }

        private void btn_deleteQuestion_Click(object sender, EventArgs e)
        {
            if (dGV_test.SelectedCells.Count > 0)
            {
                int rowindex = dGV_test.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dGV_test.Rows[rowindex];

                questionId = Convert.ToInt32(selectedRow.Cells["Column_id"].Value);

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить вопрос '" + Convert.ToString(selectedRow.Cells["Column_question"].Value) + "'?", "Удаление вопроса", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    WorkWithBD.deleteQuestion(questionId);
                    WorkWithBD.showQuestions(testId, dGV_test);
                }
            }
        }

        private void btn_saveTestAndExcit_Click(object sender, EventArgs e)
        {
            if (btn_changeTestInfo.Enabled)
            {
                btn_changeTestInfo_Click(sender, e);
            }
            else
            {
                btn_saveTestInfo_Click(sender, e);
            }
            


            new Curriculum().Show();
            this.Close();
        }

        private void tSB_back_Click(object sender, EventArgs e)
        {
            new Curriculum().Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Обучающе_тестирующая_программа__Математика_
{
    class WorkWithBD
    {
        //Authorisation
        
        public static void AuthoriseAsTeacher(Form currForm, string login, string passw)
        {
            login = login.Trim();
            passw = passw.Trim();

            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string logQuery = "SELECT [teacher_id] FROM [Teacher] WHERE [teacher_login]=@Login AND [teacher_password]=@Password";

            SqlCommand command = new SqlCommand(logQuery, sqlConnection);
            command.Parameters.AddWithValue("Login", login);
            command.Parameters.AddWithValue("Password", passw);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                if (sqlReader.Read())
                {
                    Data.userId = Convert.ToInt32(sqlReader["teacher_id"]);

                    new Curriculum().Show();
                    currForm.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильно введен логин или пароль!");
                }
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
        }

        public static void AuthoriseAsStudent(Form currForm, string login, string passw)
        {
            login = login.Trim();
            passw = passw.Trim();

            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string logQuery = "SELECT [student_id] FROM [Student] WHERE [student_login]=@Login AND [student_password]=@Password";

            SqlCommand command = new SqlCommand(logQuery, sqlConnection);
            command.Parameters.AddWithValue("Login", login);
            command.Parameters.AddWithValue("Password", passw);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                if (sqlReader.Read())
                {
                    Data.userId = Convert.ToInt32(sqlReader["student_id"]);
                    new Student_curriculum().Show();
                    currForm.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильно введен логин или пароль!");
                }
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
        }


        //Curriculum Tree View

        public static void getCurriculum(TreeView tV_Curriculum, ContextMenuStrip cMS_theme, ContextMenuStrip cMS_rule, ContextMenuStrip cMS_test)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string getCurriculumQuery = "SELECT [theme_id], " +
                                         "[theme_name] " +
                                    "FROM [Theme]";

            SqlCommand command = new SqlCommand(getCurriculumQuery, sqlConnection);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    int themeId = Convert.ToInt32(sqlReader["theme_id"]);
                    TreeNode themeNode = new TreeNode
                    {
                        Text = Convert.ToString(sqlReader["theme_name"]),
                        ImageIndex = 0,
                        SelectedImageIndex = 0,
                        Tag = themeId,
                        ContextMenuStrip = cMS_theme
                    };
                    tV_Curriculum.Nodes.Add(themeNode);
                    getRule(themeId, themeNode, cMS_rule);
                    getTest(themeId, themeNode, cMS_test);

                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
        }

        public static void getRule(int themeId, TreeNode themeNode, ContextMenuStrip cMS_rule)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string getRuleQuery = "SELECT [rule_id], " +
                                         "[rule_name] " +
                                    "FROM [Rule] WHERE [theme_id]=@ThemeId";


            SqlCommand command = new SqlCommand(getRuleQuery, sqlConnection);
            command.Parameters.AddWithValue("ThemeId", themeId);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    themeNode.Nodes.Add(new TreeNode
                    {
                        Text = Convert.ToString(sqlReader["rule_name"]),
                        ImageIndex = 1,
                        SelectedImageIndex = 1,
                        Tag = Convert.ToString(sqlReader["rule_id"]),
                        ContextMenuStrip = cMS_rule
                    });
                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
        }

        public static void getTest(int themeId, TreeNode themeNode, ContextMenuStrip cMS_test)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string getTestQuery = "SELECT [test_id], " +
                                         "[test_name] " +
                                    "FROM [Test] WHERE [theme_id]=@ThemeId";


            SqlCommand command = new SqlCommand(getTestQuery, sqlConnection);
            command.Parameters.AddWithValue("ThemeId", themeId);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    themeNode.Nodes.Add(new TreeNode
                    {
                        Text = Convert.ToString(sqlReader["test_name"]),
                        ImageIndex = 2,
                        SelectedImageIndex = 2,
                        Tag = Convert.ToString(sqlReader["test_id"]),
                        ContextMenuStrip = cMS_test
                    });

                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
        }


        //Students Tree View

        public static void getGroups(TreeView tV_Students, ContextMenuStrip cMS_group, ContextMenuStrip cMS_student)
        {
            List<string> groups = getGroupNameList();

            foreach (string group in groups)
            {
                TreeNode groupNode = new TreeNode
                {
                    Text = Convert.ToString(group),
                    ImageIndex = 0,
                    SelectedImageIndex = 0,
                    Tag = "0",
                    ContextMenuStrip = cMS_group
                };
                tV_Students.Nodes.Add(groupNode);
                getStudents(group, groupNode, cMS_student);
            }
        }

        public static void getStudents(string group, TreeNode groupNode, ContextMenuStrip cMS_student)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string getRuleQuery = "SELECT [student_id], " +
                                         "[student_name] " +
                                    "FROM [Student] WHERE [group_name]=@Group";


            SqlCommand command = new SqlCommand(getRuleQuery, sqlConnection);
            command.Parameters.AddWithValue("Group", group);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    groupNode.Nodes.Add(new TreeNode
                    {
                        Text = Convert.ToString(sqlReader["student_name"]),
                        ImageIndex = 1,
                        SelectedImageIndex = 1,
                        Tag = Convert.ToString(sqlReader["student_id"]),
                        ContextMenuStrip = cMS_student
                    });
                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
        }


        //Theme

        public static void addTheme(string themeName)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addThemeQuery = "INSERT INTO [Theme] (theme_name) VALUES(@Name)";

            SqlCommand command = new SqlCommand(addThemeQuery, sqlConnection);
            command.Parameters.AddWithValue("Name", themeName);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void changeTheme(int themeId, string themeName)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string changeTestQuery = "UPDATE [Theme] SET [theme_name]=@Name WHERE [theme_id]=@ThemeId";

            SqlCommand command = new SqlCommand(changeTestQuery, sqlConnection);
            command.Parameters.AddWithValue("Name", themeName);
            command.Parameters.AddWithValue("ThemeId", themeId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void deleteTheme(int themeId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string deleteThemeQuery = "DELETE FROM [Theme] WHERE [theme_id]=@ThemeId";

            SqlCommand command = new SqlCommand(deleteThemeQuery, sqlConnection);
            command.Parameters.AddWithValue("ThemeId", themeId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }

        }


        //Test

        public static int addTest(string testName, int themeId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addTestQuery = "INSERT INTO [Test] (test_name, theme_id) " +
                                               "OUTPUT INSERTED.test_id " +
                                               "VALUES(@Name, @ThemeId)";

            SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
            command.Parameters.AddWithValue("Name", testName);
            command.Parameters.AddWithValue("ThemeId", themeId);

            int testId = new int();
            try
            {
                testId = (int)command.ExecuteScalar();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }

            return testId;
        }

        public static void changeTest(int testId, string testName)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string changeTestQuery = "UPDATE [Test] SET [test_name]=@Name WHERE [test_id]=@TestId";

            SqlCommand command = new SqlCommand(changeTestQuery, sqlConnection);
            command.Parameters.AddWithValue("Name", testName);
            command.Parameters.AddWithValue("TestId", testId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void deleteTest(int testId)  
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string deleteTestQuery = "DELETE FROM [Test] WHERE [test_id]=@TestId";

            SqlCommand command = new SqlCommand(deleteTestQuery, sqlConnection);
            command.Parameters.AddWithValue("TestId", testId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        //Rule
        public static void addRule(string ruleName, string ruleText, int themeId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addRuleQuery = "INSERT INTO [Rule] (rule_name, rule_text, theme_id) VALUES(@Name, @Text, @ThemeId)";

            SqlCommand command = new SqlCommand(addRuleQuery, sqlConnection);
            command.Parameters.AddWithValue("Name", ruleName);
            command.Parameters.AddWithValue("Text", ruleText);
            command.Parameters.AddWithValue("ThemeId", themeId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void changeRule(string ruleName, string ruleText, int themeId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addRuleQuery = "UPDATE [Rule] SET [rule_name]=@Name," +
                                                    "[rule_text]=@Text  WHERE [theme_id]=@ThemeId";

            SqlCommand command = new SqlCommand(addRuleQuery, sqlConnection);
            command.Parameters.AddWithValue("Name", ruleName);
            command.Parameters.AddWithValue("Text", ruleText);
            command.Parameters.AddWithValue("ThemeId", themeId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void deleteRule(int ruleId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string deleteRuleQuery = "DELETE FROM [Rule] WHERE [rule_id]=@RuleId";

            SqlCommand command = new SqlCommand(deleteRuleQuery, sqlConnection);
            command.Parameters.AddWithValue("RuleId", ruleId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //Rule Representation

        public static string[] showRule(int ruleId)
        {
            string[] ruleInfo = new string[2];

            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string deliveryLoadQuery = "SELECT [rule_name], " +
                                              "[rule_text] " +
                                         "FROM [Rule] WHERE [rule_id]=@RuleId";


            SqlCommand command = new SqlCommand(deliveryLoadQuery, sqlConnection);
            command.Parameters.AddWithValue("RuleId", ruleId);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    ruleInfo[0] = Convert.ToString(sqlReader["rule_name"]);
                    ruleInfo[1] = Convert.ToString(sqlReader["rule_text"]);
                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
            return ruleInfo;
        }


        //Question 

        public static void addQuestion(string questionText, string answerType, string answerVariant, string answerRight, int questionPoint, int testId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addTestQuery = "INSERT INTO [Question] (question_text, answer_type, answer_variant, answer_right, question_point, test_id) " +
                                                   "VALUES(@QText, @Type, @Variant, @Right, @Point, @TestId)";

            SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
            command.Parameters.AddWithValue("QText", questionText);
            command.Parameters.AddWithValue("Type", answerType);
            command.Parameters.AddWithValue("Variant", answerVariant);
            command.Parameters.AddWithValue("Right", answerRight);
            command.Parameters.AddWithValue("Point", questionPoint);
            command.Parameters.AddWithValue("TestId", testId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void changeQuestion(string questionText, string answerType, string answerVariant, string answerRight, int questionPoint, int questionId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addTestQuery = "UPDATE [Question] SET [question_text]=@QText, " +
                                                        "[answer_type]=@Type, " +
                                                        "[answer_variant]=@Variant, " +
                                                        "[answer_right]=@Right, " +
                                                        "[question_point]=@Point " +
                                                  "WHERE [question_id]=@QuestionId";

            SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
            command.Parameters.AddWithValue("QText", questionText);
            command.Parameters.AddWithValue("Type", answerType);
            command.Parameters.AddWithValue("Variant", answerVariant);
            command.Parameters.AddWithValue("Right", answerRight);
            command.Parameters.AddWithValue("Point", questionPoint);
            command.Parameters.AddWithValue("QuestionId", questionId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void deleteQuestion(int questionId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addTestQuery = "DELETE FROM [Question] WHERE [question_id]=@QuestionId";

            SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
            command.Parameters.AddWithValue("QuestionId", questionId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        //Question Representation

        public static void showQuestions(int testId, DataGridView dGV_test)
        {


            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string deliveryLoadQuery = "SELECT [question_id], " +
                                              "[question_text], " +
                                              "[answer_type], " +
                                              "[answer_variant], " +
                                              "[answer_right], " +
                                              "[question_point] " +
                                         "FROM [Question] WHERE [test_id]=@TestId";


            SqlCommand command = new SqlCommand(deliveryLoadQuery, sqlConnection);
            command.Parameters.AddWithValue("TestId", testId);
            SqlDataReader sqlReader = null;

            dGV_test.Rows.Clear();

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {

                    int questionId = Convert.ToInt32(sqlReader["question_id"]);
                    string question = Convert.ToString(sqlReader["question_text"]);
                    string questionType = Convert.ToString(sqlReader["answer_type"]);
                    string answerVariant = Convert.ToString(sqlReader["answer_variant"]);
                    string answerRight = Convert.ToString(sqlReader["answer_right"]);
                    int point = Convert.ToInt32(sqlReader["question_point"]);

                    dGV_test.Rows.Add(questionId, question, questionType, answerVariant, point, answerRight);

                    //MessageBox.Show(Convert.ToString(sqlReader["answer_variant"]).Split('\n')[0]);
                    /*dataGridView_history.Rows.Add(Convert.ToString(sqlReader["delivery_id"]),
                                                   Convert.ToString(sqlReader["delivery_date"]).Split()[0],
                                                   Convert.ToString(sqlReader["eqpm_id"]) + " " + Convert.ToString(sqlReader["eqpm_name"]),
                                                   Convert.ToString(sqlReader["provider_name"]),
                                                   Convert.ToString(sqlReader["price"]));*/
                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
            /*
            List<RadioButton> listBtn = new List<RadioButton>();
            List<string> answerVariantList = new List<string>(answerVariant.Split('\n'));
            RadioButton btn;
            foreach (string variant in answerVariantList)
            {
                btn = new RadioButton();
                btn.Text = variant;
                listBtn.Add(btn);
            }
            */
            
            dGV_test.ClearSelection();
        }

        public static List<string[]> getQuestionsInArray(int testId)
        {
            List<string[]> questions = new List<string[]>();

            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string deliveryLoadQuery = "SELECT [question_text], " +
                                              "[answer_type], " +
                                              "[answer_variant], " +
                                              "[answer_right], " +
                                              "[question_point] " +
                                         "FROM [Question] WHERE [test_id]=@TestId";


            SqlCommand command = new SqlCommand(deliveryLoadQuery, sqlConnection);
            command.Parameters.AddWithValue("TestId", testId);
            SqlDataReader sqlReader = null;

            int qwNumber = 0;
            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {

                    string question = Convert.ToString(sqlReader["question_text"]);
                    string questionType = Convert.ToString(sqlReader["answer_type"]);
                    string answerVariant = Convert.ToString(sqlReader["answer_variant"]);
                    string answerRight = Convert.ToString(sqlReader["answer_right"]);
                    string point = Convert.ToString(sqlReader["question_point"]);

                    questions.Add( new string[] { question, questionType, answerVariant, point, answerRight, ""});
                    qwNumber++;
                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }

            questions.Add(new string[] {qwNumber.ToString()});
            return questions;
        }

       
        //Grade

        public static void saveGrade(int testId, int grade)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string saveGradeQuery = "INSERT INTO [Grade] (student_id, test_id, grade) VALUES(@StudentId, @TestId, @Grade)";

            SqlCommand command = new SqlCommand(saveGradeQuery, sqlConnection);
            command.Parameters.AddWithValue("StudentId", Data.userId);
            command.Parameters.AddWithValue("TestId", testId);
            command.Parameters.AddWithValue("Grade", grade);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static Boolean checkThereIsGrade(int testId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string getRuleQuery = "SELECT [grade] " +
                                    "FROM [Grade] WHERE [student_id]=@StudentId AND [test_id]=@TestId";


            SqlCommand command = new SqlCommand(getRuleQuery, sqlConnection);
            command.Parameters.AddWithValue("StudentId", Data.userId);
            command.Parameters.AddWithValue("TestId", testId);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    return true;
                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }

            return false;
        }


        //Group

        public static void changeGroup(string groupNameNew, string groupNameOld)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addRuleQuery = "UPDATE [Student] SET [group_name]=@GroupNameNew WHERE [group_name]=@GroupNameOld";

            SqlCommand command = new SqlCommand(addRuleQuery, sqlConnection);
            command.Parameters.AddWithValue("GroupNameNew", groupNameNew);
            command.Parameters.AddWithValue("GroupNameOld", groupNameOld);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static List<string> getGroupNameList()
        {
            List<string> groupNameList = new List<string>();

            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string getCurriculumQuery = "SELECT DISTINCT [group_name] FROM [Student]";

            SqlCommand command = new SqlCommand(getCurriculumQuery, sqlConnection);
            SqlDataReader sqlReader = null;
            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    groupNameList.Add(Convert.ToString(sqlReader["group_name"]));

                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
            return groupNameList;
        }

        public static void deleteGroup(string group)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addTestQuery = "DELETE FROM [Student] WHERE [group_name]=@Group";

            SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
            command.Parameters.AddWithValue("Group", group);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        //Student

        public static void addStudent(string studentName, string group, string login, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addTestQuery = "INSERT INTO [Student] (student_name, group_name, student_login, student_password) " +
                                                   "VALUES(@Name, @Group, @Login, @Password)";

            SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
            command.Parameters.AddWithValue("Name", studentName);
            command.Parameters.AddWithValue("Group", group);
            command.Parameters.AddWithValue("Login", login);
            command.Parameters.AddWithValue("Password", password);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string instractions = "Введены неверные данные!";
                //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                //   "Допустимое количество символов для поля 'Пароль': до 20.";

                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        
        public static void changeStudent(int studentId, string studentName, string group, string login, string password)
        {
            if (!string.IsNullOrEmpty(studentName) && !string.IsNullOrWhiteSpace(studentName) &&
               !string.IsNullOrEmpty(login) && !string.IsNullOrWhiteSpace(login) &&
               !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password) &&
               !string.IsNullOrEmpty(group) && !string.IsNullOrWhiteSpace(group) &&
               !group.Equals("--"))
            {
                SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
                sqlConnection.Open();

                string addTestQuery = "UPDATE [Student] SET [student_name]=@Name, " +
                                                            "[group_name]=@Group, " +
                                                            "[student_login]=@Login, " +
                                                            "[student_password]=@Password " +
                                                      "WHERE [student_id]=@StudentId";

                SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
                command.Parameters.AddWithValue("Name", studentName);
                command.Parameters.AddWithValue("Group", group);
                command.Parameters.AddWithValue("Login", login);
                command.Parameters.AddWithValue("Password", password);
                command.Parameters.AddWithValue("StudentId", studentId);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    string instractions = "Введены неверные данные!";
                    //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                    //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                    //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                    //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                    //   "Допустимое количество символов для поля 'Пароль': до 20.";

                    MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }

        }

        public static string[] showStudentInfo(int studentId)
        {
            string[] studentInfo = new string[4];

            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string deliveryLoadQuery = "SELECT [student_name], " +
                                              "[group_name], " +
                                              "[student_login], " +
                                              "[student_password] " +
                                         "FROM [Student] WHERE [student_id]=@StudentId";


            SqlCommand command = new SqlCommand(deliveryLoadQuery, sqlConnection);
            command.Parameters.AddWithValue("StudentId", studentId);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    studentInfo[0] = Convert.ToString(sqlReader["student_name"]);
                    studentInfo[1] = Convert.ToString(sqlReader["group_name"]);
                    studentInfo[2] = Convert.ToString(sqlReader["student_login"]);
                    studentInfo[3] = Convert.ToString(sqlReader["student_password"]);
                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
            return studentInfo;
        }

        public static void deleteStudent(int studentId)
        {
            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string addTestQuery = "DELETE FROM [Student] WHERE [student_id]=@StudentId";

            SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
            command.Parameters.AddWithValue("StudentId", studentId);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        //Teacher

        public static void changeTeacher(int teacherId, string teacherName, string login, string password)
        {
            if (!string.IsNullOrEmpty(teacherName) && !string.IsNullOrWhiteSpace(teacherName) &&
               !string.IsNullOrEmpty(login) && !string.IsNullOrWhiteSpace(login) &&
               !string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            {
                SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
                sqlConnection.Open();

                string addTestQuery = "UPDATE [Teacher] SET [teacher_name]=@Name, " +
                                                            "[teacher_login]=@Login, " +
                                                            "[teacher_password]=@Password " +
                                                      "WHERE [teacher_id]=@TeacherId";

                SqlCommand command = new SqlCommand(addTestQuery, sqlConnection);
                command.Parameters.AddWithValue("Name", teacherName);
                command.Parameters.AddWithValue("Login", login);
                command.Parameters.AddWithValue("Password", password);
                command.Parameters.AddWithValue("TeacherId", teacherId);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    string instractions = "Введены неверные данные!";
                    //   "Допустимое количество символов для поля 'ФИО': до 50.\n" +
                    //   "Допустимое количество символов для поля 'Телефон': до 20.\n" +
                    //   "Допустимое количество символов для поля 'E-mail': до 50.\n" +
                    //   "Допустимое количество символов для поля 'Логин': до 20. Поле должно быть уникальным!\n" +
                    //   "Допустимое количество символов для поля 'Пароль': до 20.";

                    MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }

        }

        public static string[] showTeacherInfo(int teacherId)
        {
            string[] teacherInfo = new string[4];

            SqlConnection sqlConnection = new SqlConnection(Data.connectionString);
            sqlConnection.Open();

            string deliveryLoadQuery = "SELECT [teacher_name], " +
                                              "[teacher_login], " +
                                              "[teacher_password] " +
                                         "FROM [Teacher] WHERE [teacher_id]=@TeacherId";


            SqlCommand command = new SqlCommand(deliveryLoadQuery, sqlConnection);
            command.Parameters.AddWithValue("TeacherId", teacherId);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    teacherInfo[0] = Convert.ToString(sqlReader["teacher_name"]);
                    teacherInfo[1] = Convert.ToString(sqlReader["teacher_login"]);
                    teacherInfo[2] = Convert.ToString(sqlReader["teacher_password"]);
                };
            }
            catch (Exception exp1)
            {
                MessageBox.Show(exp1.Message.ToString(), exp1.Source.ToString(), MessageBoxButtons.OK);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                sqlConnection.Close();
            }
            return teacherInfo;
        }
    }

}

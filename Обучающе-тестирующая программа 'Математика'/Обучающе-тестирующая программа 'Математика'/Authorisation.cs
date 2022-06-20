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
    public partial class Authorisation : Form
    {
        public Authorisation()
        {
            InitializeComponent();
        }

        private void Authorisation_Load(object sender, EventArgs e)
        {
            cB_role.Items.AddRange(Data.userRole);
            cB_role.SelectedIndex = 0;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string login = tB_login.Text;
            string password = tB_password.Text;

            if (cB_role.SelectedItem.ToString() == "Преподаватель")
            {
                WorkWithBD.AuthoriseAsTeacher(this, login, password);
            }

            if (cB_role.SelectedItem.ToString() == "Студент")
            {
                WorkWithBD.AuthoriseAsStudent(this, login, password);
            }
        }
    }
}

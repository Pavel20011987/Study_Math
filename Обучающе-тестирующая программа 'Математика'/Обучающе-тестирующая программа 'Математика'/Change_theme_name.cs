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
    public partial class Change_theme_name : Form
    {
        private int themeId;
        private Form prevForm;

        public Change_theme_name()
        {
            InitializeComponent();
        }

        public Change_theme_name(Form prevForm, int themeId, string themeName)
        {
            InitializeComponent();
            this.themeId = themeId;
            this.prevForm = prevForm;

            tB_themeName.Text = themeName;
        }

        private void Change_theme_name_Load(object sender, EventArgs e)
        {
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            string themeName = tB_themeName.Text;

            if (!string.IsNullOrEmpty(themeName) && !string.IsNullOrWhiteSpace(themeName))
            {
                WorkWithBD.changeTheme(themeId, themeName);

                prevForm.Close();
                new Curriculum().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }
    }
}

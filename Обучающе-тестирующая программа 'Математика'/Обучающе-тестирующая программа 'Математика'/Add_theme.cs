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
    public partial class Add_theme : Form
    {
        private Form prevForm;

        public Add_theme()
        {
            InitializeComponent();
        }

        public Add_theme(Form prevForm)
        {
            InitializeComponent();
            this.prevForm = prevForm;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string themeName = tB_themeName.Text;

            if (!string.IsNullOrEmpty(themeName) && !string.IsNullOrWhiteSpace(themeName))
            {
                WorkWithBD.addTheme(themeName);

                prevForm.Close();
                new Curriculum().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым!");
            }
        }

        private void tB_themeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обучающе_тестирующая_программа__Математика_
{
    class Data
    {

        public static string connectionString = @"Data Source=DC01\SQLEXPRESS;Initial Catalog=MathDB;Integrated Security=True";

        public static int userId;

        public static string[] userRole = new string[]
        {
            "Преподаватель",
            "Студент"
        };

        public static string[] answerType = new string[]
        {
            //"Выбор одного варианта из нескольких",
            "Выбор вариантов",
            "Свободный ввод"
        };

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Биохимический_анализ_крови
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            label2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Update();
            label2.Text = "Об авторе:  " +
                "\n Маньковский Михаил Андреевич " +
                "\n студент 3-го курса" +
                "\n группа А01ИСТ2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "О программе:  " +
                "\n Данная тестовая программа была написана с целью улучшения навыков владения С#." +
                "\n Предметная область программы Биохимический Анализ Крови. ";
        }
    }
}

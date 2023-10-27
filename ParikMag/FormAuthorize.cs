using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParikMag
{
    public partial class FormAuthorize : Form
    {
        public FormAuthorize()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                bindingSource1.Filter = "[Логин] = '" + textBoxLogin.Text + "' and [Пароль] = '" + textBoxPassword.Text + "'";
                if (bindingSource1.Count > 0)
                {
                    this.Hide();
                    if (((DataRowView)bindingSource1.Current).Row["Тип_пользователя"].ToString() == "Администратор")
                    {
                        FormAdminTovar formAdmin = new FormAdminTovar();
                        formAdmin.ShowDialog();
                    }
                    else
                    {
                        FormGlavnaya form2 = new FormGlavnaya();
                        form2.txt = textBoxLogin.Text;
                        MessageBox.Show("Добро пожаловать");
                        form2.ShowDialog();
                    }
                    this.Show();
                }
                else
                    MessageBox.Show("Неверный логин или пароль");
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Авторизация". При необходимости она может быть перемещена или удалена.
                this.авторизацияTableAdapter.Fill(this.parikmakeDataSet.Авторизация);
            }
            catch
            {
                MessageBox.Show("Отсутствует соединение с базой данных");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRegistration formreg = new FormRegistration();
            this.Hide();
            formreg.ShowDialog();
            this.Show();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGlavnaya formglavnaya = new FormGlavnaya();
            this.Hide();
            formglavnaya.ShowDialog();
            this.Show();
        }
    }
}

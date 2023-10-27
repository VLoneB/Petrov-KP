using ParikMag.ParikmakeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParikMag
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAuthorize form1 = new FormAuthorize();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLogin.Text != (bindingSource1.Filter = "[Логин] = '"))
                {
                    if (textBoxLogin.Text != "" && textBoxPassword1.Text != "" && textBoxPassword2.Text != "")
                    {
                        if (textBoxPassword1.Text != textBoxPassword2.Text)
                        {
                            MessageBox.Show("Пароли должны совпадать");
                        }
                        else
                        {
                            this.авторизацияTableAdapter.Insert(textBoxLogin.Text, textBoxPassword2.Text, "Пользователь");
                            MessageBox.Show("Вы успешно зарегистрировались");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                }
            }
            catch
            {
                MessageBox.Show("Отсутствует соединение с базой данных");
            }
            
        }

        private void FormRegistration_Load(object sender, EventArgs e)
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
    }
}

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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void FormAdmin2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Авторизация". При необходимости она может быть перемещена или удалена.
            this.авторизацияTableAdapter.Fill(this.parikmakeDataSet.Авторизация);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAuthorize form1 = new FormAuthorize();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminTovar formadmin = new FormAdminTovar();
            this.Hide();
            formadmin.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxAddLogin.Text != "" && textBoxAddPassword.Text != "")
            {
                авторизацияTableAdapter.Insert(textBoxAddLogin.Text, textBoxAddPassword.Text, comboBoxAddType.Text);
                this.авторизацияTableAdapter.Fill(this.parikmakeDataSet.Авторизация);
                int idAuth = Convert.ToInt32(авторизацияTableAdapter.GetData().Rows[авторизацияBindingSource.Count - 1][0]);
            }
            else
            {
                MessageBox.Show("Должны быть заполнены все поля");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            авторизацияBindingSource.RemoveCurrent();
            this.Validate();
            this.авторизацияBindingSource.EndEdit();
            this.авторизацияTableAdapter.Update(this.parikmakeDataSet.Авторизация);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAdminZakaz formadmin3 = new FormAdminZakaz();
            this.Hide();
            formadmin3.ShowDialog();
            this.Show();
        }
    }
}

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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParikMag
{
    public partial class FormAdminTovar : Form
    {
        public FormAdminTovar()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.parikmakeDataSet.Категория);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.parikmakeDataSet.Товар);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxAddBrand.Text != "" && textBoxAddModel.Text != "" && this.textBoxAddPrice.Text != "" && 
                textBoxAddPhoto.Text != "" && richTextBoxOpisanie.Text != "")
            {
                товарTableAdapter.Insert(textBoxAddBrand.Text, textBoxAddModel.Text, Convert.ToInt32(this.textBoxAddPrice.Text), textBoxAddPhoto.Text, richTextBoxOpisanie.Text, (int)comboBoxAddCategory.SelectedValue);
                this.товарTableAdapter.Fill(this.parikmakeDataSet.Товар);
                int idClient = Convert.ToInt32(товарTableAdapter.GetData().Rows[товарBindingSource.Count - 1][0]);
                MessageBox.Show("Товар добавлен в список");
            }
            else
            {
                MessageBox.Show("Должны быть заполнены все поля");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            товарBindingSource.RemoveCurrent();
            this.Validate();
            this.товарBindingSource.EndEdit();
            this.товарTableAdapter.Update(this.parikmakeDataSet.Товар);
            MessageBox.Show("Выбранный товар удалён");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            товарBindingSource.EndEdit();
            товарTableAdapter.Update(this.parikmakeDataSet);
            this.товарTableAdapter.Fill(this.parikmakeDataSet.Товар);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG(*.JPG)|*.jpg|PNG(*.PNG)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxAddPhoto.Text = @"..\..\Source\Товары\" + openFileDialog1.SafeFileName;
                if (!File.Exists(textBoxAddPhoto.Text))
                {
                    File.Copy(openFileDialog1.FileName, textBoxAddPhoto.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminLogin formadmin2 = new FormAdminLogin();
            this.Hide();
            formadmin2.ShowDialog();
            this.Show();
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

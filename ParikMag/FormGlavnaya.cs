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
using System.Data.SqlClient;

namespace ParikMag
{
    public partial class FormGlavnaya : Form
    {
        public FormGlavnaya()
        {
            InitializeComponent();
        }

        string idUser;
        public string txt
        {
            get { return idUser; }
            set { idUser = value; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAuthorize formAuthorize = new FormAuthorize();
            this.Hide();
            formAuthorize.ShowDialog();
            this.Show();
        }

        private void FormGlavnaya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet1.Корзина". При необходимости она может быть перемещена или удалена.
            this.корзинаTableAdapter.Fill(this.parikmakeDataSet1.Корзина);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet1.Категория". При необходимости она может быть перемещена или удалена.
            this.категорияTableAdapter.Fill(this.parikmakeDataSet1.Категория);
            try
            {
                this.товарTableAdapter.Fill(this.parikmakeDataSet1.Товар);
            }
            catch
            {
                MessageBox.Show("Отсутствует соединение с базой данных");
            }
            if (idUser == null)
            {
                buttonAddToOrder.Visible = false;
                numericUpDown1.Visible = false;
                buttonKorzina.Visible = false;
                labelCount.Visible = false;
            }
        }

              private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)товарBindingSource1.Current;
            richTextBox1.Text = dataRowView.Row["Описание"].ToString();
            textBoxBrand.Text = dataRowView.Row["Бренд"].ToString();
            textBoxModel.Text = dataRowView.Row["Модель"].ToString();
            textBoxPrice.Text = dataRowView.Row["Цена"] + "₽";
            try
            {
                pictureBox1.Image = Image.FromFile(@dataRowView.Row["Ссылка_на_изображение"].ToString());
            }
            catch (Exception)
            { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            товарBindingSource1.Filter = "Код_категории =" + comboBox1.SelectedValue;
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ParikmakeConnectionString);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select Код_пользователя from Авторизация where (Логин = '" + idUser+"')";
            int result = Convert.ToInt32(comm.ExecuteScalar());
            корзинаTableAdapter.Insert(result, Convert.ToInt32(listBox1.SelectedValue), Convert.ToString(((DataRowView)товарBindingSource1.Current).Row["Бренд"]), numericUpDown1.Value.ToString());
            MessageBox.Show("Товар добавлен в корзину");

        }

        private void buttonKorzina_Click(object sender, EventArgs e)
        {
            FormKorzina formKorzina = new FormKorzina();
            formKorzina.txt = idUser;
            this.Hide();
            formKorzina.ShowDialog();
            this.Show();
        }
    }
}

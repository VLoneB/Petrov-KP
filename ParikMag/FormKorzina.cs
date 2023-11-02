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

namespace ParikMag
{
    public partial class FormKorzina : Form
    {
        public FormKorzina()
        {
            InitializeComponent();
        }

        string idUserKorzina;
        public string txt
        {
            get { return idUserKorzina; }
            set { idUserKorzina = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGlavnaya formglavnaya = new FormGlavnaya();
            this.Hide();
            formglavnaya.ShowDialog();
            this.Show();
        }

        private void FormKorzina_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.parikmakeDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.parikmakeDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Авторизация". При необходимости она может быть перемещена или удалена.
            this.авторизацияTableAdapter.Fill(this.parikmakeDataSet.Авторизация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Корзина". При необходимости она может быть перемещена или удалена.
            this.корзинаTableAdapter.Fill(this.parikmakeDataSet.Корзина);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ParikmakeConnectionString);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select Код_пользователя from Авторизация where (Логин = '" + idUserKorzina + "')";
            int result = Convert.ToInt32(comm.ExecuteScalar());
            корзинаBindingSource.Filter = "Код_пользователя = " + result;
            comm.CommandText = "select sum(Цена) from Товар join Корзина on Товар.Код_товара = Корзина.Код_товара where Корзина.Код_пользователя = @id";
            comm.Parameters.AddWithValue("@id", result);
            textBoxSum.Text = comm.ExecuteScalar().ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCount.Text = ((DataRowView)корзинаBindingSource.Current).Row["Количество_товара"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ParikmakeConnectionString);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select Код_пользователя from Авторизация where (Логин = '" + idUserKorzina + "')";
            int result = Convert.ToInt32(comm.ExecuteScalar());
            клиентTableAdapter.Insert(textBoxName.Text, textBoxSurname.Text, textBoxPhone.Text, result);
            comm.CommandText = "select Код_клиента from Клиент";
            int result2 = Convert.ToInt32(comm.ExecuteScalar());
            заказTableAdapter.Insert(result2, Convert.ToInt32(((DataRowView)корзинаBindingSource.Current).Row["Код_корзины"]), "Ожидает", DateTime.Now);
            MessageBox.Show("Заказ добавлен");
        }
    }
}

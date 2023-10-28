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
    public partial class FormAdminZakaz : Form
    {
        public FormAdminZakaz()
        {
            InitializeComponent();
        }

        private void FormAdmin3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.parikmakeDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Корзина". При необходимости она может быть перемещена или удалена.
            this.корзинаTableAdapter.Fill(this.parikmakeDataSet.Корзина);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parikmakeDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.parikmakeDataSet.Заказ);
            //SqlConnection conn = new SqlConnection(@"Server=DESKTOP-5QAL5CH\SQLEXPRESS03;Database=Parikmake;Trusted_Connection=true");
            //conn.Open();
            //SqlCommand comm = conn.CreateCommand();
            //int result = Convert.ToInt32(comm.ExecuteScalar());
            //заказBindingSource.Filter = "Код_пользователя = " + result;
            //comm.CommandText = "select sum(Цена) from Товар join Корзина on Товар.Код_товара = Корзина.Код_товара where Корзина.Код_пользователя = @id";
            //comm.Parameters.AddWithValue("@id", result);
            //textBoxSum.Text = comm.ExecuteScalar().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAuthorize form1 = new FormAuthorize();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAdminLogin formAdmin2 = new FormAdminLogin();
            this.Hide();
            formAdmin2.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminTovar formAdmin = new FormAdminTovar();
            this.Hide();
            formAdmin.ShowDialog();
            this.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            заказBindingSource.RemoveCurrent();
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.заказTableAdapter.Update(this.parikmakeDataSet.Заказ);
            MessageBox.Show("Заказ удалён");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            заказBindingSource.EndEdit();
            заказTableAdapter.Update(this.parikmakeDataSet);
            this.заказTableAdapter.Fill(this.parikmakeDataSet.Заказ);
            MessageBox.Show("Информация о заказе сохранена");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

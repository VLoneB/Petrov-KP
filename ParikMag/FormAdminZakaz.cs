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
			//SqlConnection conn = new SqlConnection(Properties.Settings.Default.ParikmakeConnectionString);
			//conn.Open();
			//SqlCommand comm = conn.CreateCommand();
			//int result = Convert.ToInt32(comm.ExecuteScalar());
			//заказBindingSource.Filter = "Код_пользователя = " + result;
			//comm.CommandText = "select sum(Цена) from Товар join Корзина on Товар.Код_товара = Корзина.Код_товара where Корзина.Код_пользователя = @id";
			//comm.Parameters.AddWithValue("@id", result);
			//textBoxSum.Text = comm.ExecuteScalar().ToString();
			корзинаBindingSource.Filter = "Код_пользователя = 0";


		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
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
			this.Close();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Удалить выбранную запить?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				заказBindingSource.RemoveCurrent();
				this.Validate();
				this.заказBindingSource.EndEdit();
				this.заказTableAdapter.Update(this.parikmakeDataSet.Заказ);
				MessageBox.Show("Заказ удалён");
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Properties.Settings.Default.ParikmakeConnectionString);
			conn.Open();
			SqlCommand Comm = conn.CreateCommand();
			Comm.CommandText = "update Заказ set Статус_заказа = @state where Код_заказа = @idOrd";
			Comm.Parameters.AddWithValue("@state", comboBox1.SelectedItem);
			Comm.Parameters.AddWithValue("@idOrd", listBox1.SelectedValue);
			Comm.ExecuteNonQuery();
			int curId = listBox1.SelectedIndex;
			this.заказTableAdapter.Fill(this.parikmakeDataSet.Заказ);
			listBox1.SelectedIndex = curId;
            MessageBox.Show("Статус заказа успешно изменён!");
        }

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(Properties.Settings.Default.ParikmakeConnectionString);
			conn.Open();
			SqlCommand Comm = conn.CreateCommand();
			Comm.CommandText = "SELECT Заказ.Код_заказа, Статус_заказа, Имя, Фамилия, Телефон from Клиент " +
				"join Заказ on Заказ.Код_клиента = Клиент.Код_клиента where Заказ.Код_заказа = @id";
			Comm.Parameters.AddWithValue("@id", listBox1.SelectedValue);
			SqlDataReader reader = Comm.ExecuteReader();
			reader.Read();
			textBox1.Text = reader[2].ToString();
			textBox2.Text = reader[3].ToString();
			textBox3.Text = reader[4].ToString();
			comboBox1.SelectedItem = reader[1].ToString();
			int idOrd = (int)reader[0];
			reader.Close();

			Comm.CommandText = "select sum(Цена) from Товар " +
				"join Корзина on Товар.Код_товара = Корзина.Код_товара join " +
				"Заказ on Заказ.Код_корзины = Корзина.Код_корзины " +
				"where Заказ.Код_заказа = @id";
			textBoxSum.Text = Comm.ExecuteScalar().ToString();

			Comm.CommandText = "select Код_Пользователя from Клиент join " +
				"Заказ on Заказ.Код_клиента = Клиент.Код_клиента " +
				"where Код_заказа = @id";
			корзинаBindingSource.Filter = "Код_пользователя = " + Comm.ExecuteScalar();
			conn.Close();
		}
	}
}

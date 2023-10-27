namespace ParikMag
{
    partial class FormKorzina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.корзинаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parikmakeDataSet = new ParikMag.ParikmakeDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.корзинаTableAdapter = new ParikMag.ParikmakeDataSetTableAdapters.КорзинаTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.авторизацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авторизацияTableAdapter = new ParikMag.ParikmakeDataSetTableAdapters.АвторизацияTableAdapter();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new ParikMag.ParikmakeDataSetTableAdapters.КлиентTableAdapter();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new ParikMag.ParikmakeDataSetTableAdapters.ЗаказTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parikmakeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(521, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.корзинаBindingSource;
            this.listBox1.DisplayMember = "Бренд";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(22, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 329);
            this.listBox1.TabIndex = 13;
            this.listBox1.ValueMember = "Код_корзины";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // корзинаBindingSource
            // 
            this.корзинаBindingSource.DataMember = "Корзина";
            this.корзинаBindingSource.DataSource = this.parikmakeDataSet;
            // 
            // parikmakeDataSet
            // 
            this.parikmakeDataSet.DataSetName = "ParikmakeDataSet";
            this.parikmakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(423, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Оформить заказ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // корзинаTableAdapter
            // 
            this.корзинаTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(529, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(372, 280);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(151, 20);
            this.textBoxPhone.TabIndex = 41;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(372, 242);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(151, 20);
            this.textBoxSurname.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(529, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(372, 202);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 20);
            this.textBoxName.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(529, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Фамилия";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxCount.Location = new System.Drawing.Point(399, 46);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(69, 38);
            this.textBoxCount.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(474, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Количество";
            // 
            // авторизацияBindingSource
            // 
            this.авторизацияBindingSource.DataMember = "Авторизация";
            this.авторизацияBindingSource.DataSource = this.parikmakeDataSet;
            // 
            // авторизацияTableAdapter
            // 
            this.авторизацияTableAdapter.ClearBeforeFill = true;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.parikmakeDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.parikmakeDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(87, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Товары в корзине";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(474, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Сумма заказа";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxSum.Location = new System.Drawing.Point(399, 123);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(69, 38);
            this.textBoxSum.TabIndex = 47;
            // 
            // FormKorzina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ParikMag.Properties.Resources.фон_основной;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKorzina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Корзина";
            this.Load += new System.EventHandler(this.FormKorzina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.корзинаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parikmakeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private ParikmakeDataSet parikmakeDataSet;
        private System.Windows.Forms.BindingSource корзинаBindingSource;
        private ParikmakeDataSetTableAdapters.КорзинаTableAdapter корзинаTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource авторизацияBindingSource;
        private ParikmakeDataSetTableAdapters.АвторизацияTableAdapter авторизацияTableAdapter;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private ParikmakeDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private ParikmakeDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSum;
    }
}
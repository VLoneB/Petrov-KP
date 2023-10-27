namespace ParikMag
{
    partial class FormAdminTovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminTovar));
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.брендDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ссылканаизображениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодкатегорииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parikmakeDataSet = new ParikMag.ParikmakeDataSet();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBoxAddBrand = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddModel = new System.Windows.Forms.TextBox();
            this.textBoxAddPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddPhoto = new System.Windows.Forms.TextBox();
            this.richTextBoxOpisanie = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAddCategory = new System.Windows.Forms.ComboBox();
            this.категорияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new ParikMag.ParikmakeDataSetTableAdapters.ТоварTableAdapter();
            this.категорияTableAdapter = new ParikMag.ParikmakeDataSetTableAdapters.КатегорияTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parikmakeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(12, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(933, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодтовараDataGridViewTextBoxColumn,
            this.брендDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.ссылканаизображениеDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.кодкатегорииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 273);
            this.dataGridView1.TabIndex = 13;
            // 
            // кодтовараDataGridViewTextBoxColumn
            // 
            this.кодтовараDataGridViewTextBoxColumn.DataPropertyName = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.HeaderText = "Код_товара";
            this.кодтовараDataGridViewTextBoxColumn.Name = "кодтовараDataGridViewTextBoxColumn";
            this.кодтовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // брендDataGridViewTextBoxColumn
            // 
            this.брендDataGridViewTextBoxColumn.DataPropertyName = "Бренд";
            this.брендDataGridViewTextBoxColumn.HeaderText = "Бренд";
            this.брендDataGridViewTextBoxColumn.Name = "брендDataGridViewTextBoxColumn";
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // ссылканаизображениеDataGridViewTextBoxColumn
            // 
            this.ссылканаизображениеDataGridViewTextBoxColumn.DataPropertyName = "Ссылка_на_изображение";
            this.ссылканаизображениеDataGridViewTextBoxColumn.HeaderText = "Ссылка_на_изображение";
            this.ссылканаизображениеDataGridViewTextBoxColumn.Name = "ссылканаизображениеDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // кодкатегорииDataGridViewTextBoxColumn
            // 
            this.кодкатегорииDataGridViewTextBoxColumn.DataPropertyName = "Код_категории";
            this.кодкатегорииDataGridViewTextBoxColumn.HeaderText = "Код_категории";
            this.кодкатегорииDataGridViewTextBoxColumn.Name = "кодкатегорииDataGridViewTextBoxColumn";
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.parikmakeDataSet;
            // 
            // parikmakeDataSet
            // 
            this.parikmakeDataSet.DataSetName = "ParikmakeDataSet";
            this.parikmakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Silver;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDelete.Location = new System.Drawing.Point(12, 307);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(199, 34);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Удалить выбранный товар";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(884, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Модель";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(879, 143);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 20);
            this.button7.TabIndex = 32;
            this.button7.Text = "Выбрать путь к фото";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBoxAddBrand
            // 
            this.textBoxAddBrand.Location = new System.Drawing.Point(750, 37);
            this.textBoxAddBrand.Name = "textBoxAddBrand";
            this.textBoxAddBrand.Size = new System.Drawing.Size(123, 20);
            this.textBoxAddBrand.TabIndex = 22;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Location = new System.Drawing.Point(521, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 34);
            this.button6.TabIndex = 21;
            this.button6.Text = "Добавить товар в список";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(884, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Цена";
            // 
            // textBoxAddModel
            // 
            this.textBoxAddModel.Location = new System.Drawing.Point(750, 71);
            this.textBoxAddModel.Name = "textBoxAddModel";
            this.textBoxAddModel.Size = new System.Drawing.Size(123, 20);
            this.textBoxAddModel.TabIndex = 23;
            // 
            // textBoxAddPrice
            // 
            this.textBoxAddPrice.Location = new System.Drawing.Point(750, 108);
            this.textBoxAddPrice.Name = "textBoxAddPrice";
            this.textBoxAddPrice.Size = new System.Drawing.Size(123, 20);
            this.textBoxAddPrice.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(884, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Бренд";
            // 
            // textBoxAddPhoto
            // 
            this.textBoxAddPhoto.Enabled = false;
            this.textBoxAddPhoto.Location = new System.Drawing.Point(750, 144);
            this.textBoxAddPhoto.Name = "textBoxAddPhoto";
            this.textBoxAddPhoto.ReadOnly = true;
            this.textBoxAddPhoto.Size = new System.Drawing.Size(123, 20);
            this.textBoxAddPhoto.TabIndex = 25;
            // 
            // richTextBoxOpisanie
            // 
            this.richTextBoxOpisanie.Location = new System.Drawing.Point(749, 190);
            this.richTextBoxOpisanie.Name = "richTextBoxOpisanie";
            this.richTextBoxOpisanie.Size = new System.Drawing.Size(270, 111);
            this.richTextBoxOpisanie.TabIndex = 38;
            this.richTextBoxOpisanie.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(851, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Описание";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.товарBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1031, 25);
            this.bindingNavigator1.TabIndex = 40;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(884, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Категория";
            // 
            // comboBoxAddCategory
            // 
            this.comboBoxAddCategory.DataSource = this.категорияBindingSource;
            this.comboBoxAddCategory.DisplayMember = "Категория";
            this.comboBoxAddCategory.FormattingEnabled = true;
            this.comboBoxAddCategory.Location = new System.Drawing.Point(750, 307);
            this.comboBoxAddCategory.Name = "comboBoxAddCategory";
            this.comboBoxAddCategory.Size = new System.Drawing.Size(128, 21);
            this.comboBoxAddCategory.TabIndex = 43;
            this.comboBoxAddCategory.ValueMember = "Код_категории";
            // 
            // категорияBindingSource
            // 
            this.категорияBindingSource.DataMember = "Категория";
            this.категорияBindingSource.DataSource = this.parikmakeDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // категорияTableAdapter
            // 
            this.категорияTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(306, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 34);
            this.button2.TabIndex = 44;
            this.button2.Text = "К списку пользователей";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(532, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 34);
            this.button4.TabIndex = 45;
            this.button4.Text = "К списку заказов";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormAdminTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1031, 443);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxAddCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBoxAddBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxOpisanie);
            this.Controls.Add(this.textBoxAddModel);
            this.Controls.Add(this.textBoxAddPrice);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxAddPhoto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение списка товаров";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parikmakeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категорияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ParikmakeDataSet parikmakeDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ParikmakeDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBoxAddBrand;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddModel;
        private System.Windows.Forms.TextBox textBoxAddPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxOpisanie;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAddCategory;
        private ParikmakeDataSetTableAdapters.КатегорияTableAdapter категорияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn брендDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ссылканаизображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкатегорииDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource категорияBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}
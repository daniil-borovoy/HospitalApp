namespace HospitalApp.TapeForms
{
    partial class PatientsTapeForm
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label датаОбращенияLabel;
            System.Windows.Forms.Label кодБолезниLabel;
            System.Windows.Forms.Label кодСотрудникаLabel;
            System.Windows.Forms.Label результатЛеченияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsTapeForm));
            this.hospitalDataSet = new HospitalApp.HospitalDataSet();
            this.пациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентыTableAdapter = new HospitalApp.HospitalDataSetTableAdapters.ПациентыTableAdapter();
            this.tableAdapterManager = new HospitalApp.HospitalDataSetTableAdapters.TableAdapterManager();
            this.пациентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.пациентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.датаОбращенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кодБолезниTextBox = new System.Windows.Forms.TextBox();
            this.кодСотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.результатЛеченияTextBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            фИОLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            датаОбращенияLabel = new System.Windows.Forms.Label();
            кодБолезниLabel = new System.Windows.Forms.Label();
            кодСотрудникаLabel = new System.Windows.Forms.Label();
            результатЛеченияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingNavigator)).BeginInit();
            this.пациентыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.ForeColor = System.Drawing.Color.Transparent;
            фИОLabel.Location = new System.Drawing.Point(77, 56);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(69, 27);
            фИОLabel.TabIndex = 1;
            фИОLabel.Text = "ФИО:";
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастLabel.ForeColor = System.Drawing.Color.Transparent;
            возрастLabel.Location = new System.Drawing.Point(77, 84);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(105, 27);
            возрастLabel.TabIndex = 3;
            возрастLabel.Text = "Возраст:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            полLabel.ForeColor = System.Drawing.Color.Transparent;
            полLabel.Location = new System.Drawing.Point(77, 112);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(59, 27);
            полLabel.TabIndex = 5;
            полLabel.Text = "Пол:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.ForeColor = System.Drawing.Color.Transparent;
            адресLabel.Location = new System.Drawing.Point(77, 140);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(86, 27);
            адресLabel.TabIndex = 7;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.ForeColor = System.Drawing.Color.Transparent;
            телефонLabel.Location = new System.Drawing.Point(77, 168);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(112, 27);
            телефонLabel.TabIndex = 9;
            телефонLabel.Text = "Телефон:";
            // 
            // датаОбращенияLabel
            // 
            датаОбращенияLabel.AutoSize = true;
            датаОбращенияLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаОбращенияLabel.ForeColor = System.Drawing.Color.Transparent;
            датаОбращенияLabel.Location = new System.Drawing.Point(77, 197);
            датаОбращенияLabel.Name = "датаОбращенияLabel";
            датаОбращенияLabel.Size = new System.Drawing.Size(204, 27);
            датаОбращенияLabel.TabIndex = 11;
            датаОбращенияLabel.Text = "Дата Обращения:";
            // 
            // кодБолезниLabel
            // 
            кодБолезниLabel.AutoSize = true;
            кодБолезниLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодБолезниLabel.ForeColor = System.Drawing.Color.Transparent;
            кодБолезниLabel.Location = new System.Drawing.Point(77, 224);
            кодБолезниLabel.Name = "кодБолезниLabel";
            кодБолезниLabel.Size = new System.Drawing.Size(157, 27);
            кодБолезниLabel.TabIndex = 13;
            кодБолезниLabel.Text = "Код Болезни:";
            // 
            // кодСотрудникаLabel
            // 
            кодСотрудникаLabel.AutoSize = true;
            кодСотрудникаLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодСотрудникаLabel.ForeColor = System.Drawing.Color.Transparent;
            кодСотрудникаLabel.Location = new System.Drawing.Point(77, 252);
            кодСотрудникаLabel.Name = "кодСотрудникаLabel";
            кодСотрудникаLabel.Size = new System.Drawing.Size(196, 27);
            кодСотрудникаLabel.TabIndex = 15;
            кодСотрудникаLabel.Text = "Код Сотрудника:";
            // 
            // результатЛеченияLabel
            // 
            результатЛеченияLabel.AutoSize = true;
            результатЛеченияLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            результатЛеченияLabel.ForeColor = System.Drawing.Color.Transparent;
            результатЛеченияLabel.Location = new System.Drawing.Point(77, 280);
            результатЛеченияLabel.Name = "результатЛеченияLabel";
            результатЛеченияLabel.Size = new System.Drawing.Size(227, 27);
            результатЛеченияLabel.TabIndex = 17;
            результатЛеченияLabel.Text = "Результат Лечения:";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пациентыBindingSource
            // 
            this.пациентыBindingSource.DataMember = "Пациенты";
            this.пациентыBindingSource.DataSource = this.hospitalDataSet;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = HospitalApp.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БолезниTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЛекарстваTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = this.пациентыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // пациентыBindingNavigator
            // 
            this.пациентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.пациентыBindingNavigator.BindingSource = this.пациентыBindingSource;
            this.пациентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пациентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.пациентыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.пациентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.пациентыBindingNavigatorSaveItem});
            this.пациентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пациентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пациентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пациентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пациентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пациентыBindingNavigator.Name = "пациентыBindingNavigator";
            this.пациентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пациентыBindingNavigator.Size = new System.Drawing.Size(828, 27);
            this.пациентыBindingNavigator.TabIndex = 0;
            this.пациентыBindingNavigator.Text = "bindingNavigator1";
            this.пациентыBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // пациентыBindingNavigatorSaveItem
            // 
            this.пациентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пациентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пациентыBindingNavigatorSaveItem.Image")));
            this.пациентыBindingNavigatorSaveItem.Name = "пациентыBindingNavigatorSaveItem";
            this.пациентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.пациентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пациентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.пациентыBindingNavigatorSaveItem_Click);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(354, 56);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(422, 22);
            this.фИОTextBox.TabIndex = 2;
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Возраст", true));
            this.возрастTextBox.Location = new System.Drawing.Point(354, 84);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(422, 22);
            this.возрастTextBox.TabIndex = 4;
            // 
            // адресTextBox
            // 
            this.адресTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(354, 140);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(422, 22);
            this.адресTextBox.TabIndex = 8;
            // 
            // датаОбращенияDateTimePicker
            // 
            this.датаОбращенияDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.датаОбращенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пациентыBindingSource, "ДатаОбращения", true));
            this.датаОбращенияDateTimePicker.Location = new System.Drawing.Point(354, 196);
            this.датаОбращенияDateTimePicker.Name = "датаОбращенияDateTimePicker";
            this.датаОбращенияDateTimePicker.Size = new System.Drawing.Size(422, 22);
            this.датаОбращенияDateTimePicker.TabIndex = 12;
            // 
            // кодБолезниTextBox
            // 
            this.кодБолезниTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.кодБолезниTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "КодБолезни", true));
            this.кодБолезниTextBox.Location = new System.Drawing.Point(354, 224);
            this.кодБолезниTextBox.Name = "кодБолезниTextBox";
            this.кодБолезниTextBox.Size = new System.Drawing.Size(422, 22);
            this.кодБолезниTextBox.TabIndex = 14;
            // 
            // кодСотрудникаTextBox
            // 
            this.кодСотрудникаTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.кодСотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "КодСотрудника", true));
            this.кодСотрудникаTextBox.Location = new System.Drawing.Point(354, 252);
            this.кодСотрудникаTextBox.Name = "кодСотрудникаTextBox";
            this.кодСотрудникаTextBox.Size = new System.Drawing.Size(422, 22);
            this.кодСотрудникаTextBox.TabIndex = 16;
            // 
            // результатЛеченияTextBox
            // 
            this.результатЛеченияTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.результатЛеченияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "РезультатЛечения", true));
            this.результатЛеченияTextBox.Location = new System.Drawing.Point(354, 280);
            this.результатЛеченияTextBox.Name = "результатЛеченияTextBox";
            this.результатЛеченияTextBox.Size = new System.Drawing.Size(422, 22);
            this.результатЛеченияTextBox.TabIndex = 18;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(626, 333);
            this.button9.MaximumSize = new System.Drawing.Size(150, 100);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 71);
            this.button9.TabIndex = 35;
            this.button9.Text = "Табличная форма";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(490, 372);
            this.button8.MaximumSize = new System.Drawing.Size(130, 100);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 50);
            this.button8.TabIndex = 34;
            this.button8.Text = "Закрыть";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(490, 316);
            this.button7.MaximumSize = new System.Drawing.Size(130, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 50);
            this.button7.TabIndex = 33;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(354, 372);
            this.button6.MaximumSize = new System.Drawing.Size(130, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 50);
            this.button6.TabIndex = 32;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(354, 317);
            this.button5.MaximumSize = new System.Drawing.Size(130, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 50);
            this.button5.TabIndex = 31;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(218, 372);
            this.button4.MaximumSize = new System.Drawing.Size(130, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 50);
            this.button4.TabIndex = 30;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(218, 316);
            this.button3.MaximumSize = new System.Drawing.Size(130, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 50);
            this.button3.TabIndex = 29;
            this.button3.Text = "Первая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(82, 372);
            this.button2.MaximumSize = new System.Drawing.Size(140, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 28;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(82, 317);
            this.button1.MaximumSize = new System.Drawing.Size(130, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(281, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 39);
            this.label1.TabIndex = 36;
            this.label1.Text = "Таблица \"Пациенты\"";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Пол", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.comboBox1.Location = new System.Drawing.Point(354, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(422, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентыBindingSource, "Телефон", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(354, 168);
            this.maskedTextBox1.Mask = "+7 (999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(422, 22);
            this.maskedTextBox1.TabIndex = 38;
            // 
            // PatientsTapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(датаОбращенияLabel);
            this.Controls.Add(this.датаОбращенияDateTimePicker);
            this.Controls.Add(кодБолезниLabel);
            this.Controls.Add(this.кодБолезниTextBox);
            this.Controls.Add(кодСотрудникаLabel);
            this.Controls.Add(this.кодСотрудникаTextBox);
            this.Controls.Add(результатЛеченияLabel);
            this.Controls.Add(this.результатЛеченияTextBox);
            this.Controls.Add(this.пациентыBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientsTapeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациенты | Ленточная форма";
            this.Load += new System.EventHandler(this.PatientsTapeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingNavigator)).EndInit();
            this.пациентыBindingNavigator.ResumeLayout(false);
            this.пациентыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource пациентыBindingSource;
        private HospitalDataSetTableAdapters.ПациентыTableAdapter пациентыTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пациентыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton пациентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker датаОбращенияDateTimePicker;
        private System.Windows.Forms.TextBox кодБолезниTextBox;
        private System.Windows.Forms.TextBox кодСотрудникаTextBox;
        private System.Windows.Forms.TextBox результатЛеченияTextBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
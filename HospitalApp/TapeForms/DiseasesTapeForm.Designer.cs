namespace HospitalApp.TapeForms
{
    partial class DiseasesTapeForm
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
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label симптомыLabel;
            System.Windows.Forms.Label продолжительностьLabel;
            System.Windows.Forms.Label последствияLabel;
            System.Windows.Forms.Label кодЛекартства1Label;
            System.Windows.Forms.Label кодЛекартства2Label;
            System.Windows.Forms.Label кодЛекартства3Label;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseasesTapeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.болезниBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.болезниBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new HospitalApp.HospitalDataSet();
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
            this.болезниBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.симптомыTextBox = new System.Windows.Forms.TextBox();
            this.продолжительностьTextBox = new System.Windows.Forms.TextBox();
            this.последствияTextBox = new System.Windows.Forms.TextBox();
            this.кодЛекартства1TextBox = new System.Windows.Forms.TextBox();
            this.кодЛекартства2TextBox = new System.Windows.Forms.TextBox();
            this.кодЛекартства3TextBox = new System.Windows.Forms.TextBox();
            this.пациентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.болезниTableAdapter = new HospitalApp.HospitalDataSetTableAdapters.БолезниTableAdapter();
            this.tableAdapterManager = new HospitalApp.HospitalDataSetTableAdapters.TableAdapterManager();
            this.пациентыTableAdapter = new HospitalApp.HospitalDataSetTableAdapters.ПациентыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            наименованиеLabel = new System.Windows.Forms.Label();
            симптомыLabel = new System.Windows.Forms.Label();
            продолжительностьLabel = new System.Windows.Forms.Label();
            последствияLabel = new System.Windows.Forms.Label();
            кодЛекартства1Label = new System.Windows.Forms.Label();
            кодЛекартства2Label = new System.Windows.Forms.Label();
            кодЛекартства3Label = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.болезниBindingNavigator)).BeginInit();
            this.болезниBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.болезниBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименованиеLabel.ForeColor = System.Drawing.Color.Transparent;
            наименованиеLabel.Location = new System.Drawing.Point(89, 73);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(166, 25);
            наименованиеLabel.TabIndex = 2;
            наименованиеLabel.Text = "Наименование:";
            // 
            // симптомыLabel
            // 
            симптомыLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            симптомыLabel.AutoSize = true;
            симптомыLabel.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            симптомыLabel.ForeColor = System.Drawing.Color.Transparent;
            симптомыLabel.Location = new System.Drawing.Point(130, 100);
            симптомыLabel.Name = "симптомыLabel";
            симптомыLabel.Size = new System.Drawing.Size(122, 25);
            симптомыLabel.TabIndex = 4;
            симптомыLabel.Text = "Симптомы:";
            // 
            // продолжительностьLabel
            // 
            продолжительностьLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            продолжительностьLabel.AutoSize = true;
            продолжительностьLabel.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            продолжительностьLabel.ForeColor = System.Drawing.Color.Transparent;
            продолжительностьLabel.Location = new System.Drawing.Point(32, 129);
            продолжительностьLabel.Name = "продолжительностьLabel";
            продолжительностьLabel.Size = new System.Drawing.Size(223, 25);
            продолжительностьLabel.TabIndex = 6;
            продолжительностьLabel.Text = "Продолжительность:";
            // 
            // последствияLabel
            // 
            последствияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            последствияLabel.AutoSize = true;
            последствияLabel.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            последствияLabel.ForeColor = System.Drawing.Color.Transparent;
            последствияLabel.Location = new System.Drawing.Point(104, 157);
            последствияLabel.Name = "последствияLabel";
            последствияLabel.Size = new System.Drawing.Size(148, 25);
            последствияLabel.TabIndex = 8;
            последствияLabel.Text = "Последствия:";
            // 
            // кодЛекартства1Label
            // 
            кодЛекартства1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            кодЛекартства1Label.AutoSize = true;
            кодЛекартства1Label.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодЛекартства1Label.ForeColor = System.Drawing.Color.Transparent;
            кодЛекартства1Label.Location = new System.Drawing.Point(75, 184);
            кодЛекартства1Label.Name = "кодЛекартства1Label";
            кодЛекартства1Label.Size = new System.Drawing.Size(180, 25);
            кодЛекартства1Label.TabIndex = 10;
            кодЛекартства1Label.Text = "Код Лекартства1:";
            // 
            // кодЛекартства2Label
            // 
            кодЛекартства2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            кодЛекартства2Label.AutoSize = true;
            кодЛекартства2Label.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодЛекартства2Label.ForeColor = System.Drawing.Color.Transparent;
            кодЛекартства2Label.Location = new System.Drawing.Point(71, 213);
            кодЛекартства2Label.Name = "кодЛекартства2Label";
            кодЛекартства2Label.Size = new System.Drawing.Size(184, 25);
            кодЛекартства2Label.TabIndex = 12;
            кодЛекартства2Label.Text = "Код Лекартства2:";
            // 
            // кодЛекартства3Label
            // 
            кодЛекартства3Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            кодЛекартства3Label.AutoSize = true;
            кодЛекартства3Label.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодЛекартства3Label.ForeColor = System.Drawing.Color.Transparent;
            кодЛекартства3Label.Location = new System.Drawing.Point(71, 240);
            кодЛекартства3Label.Name = "кодЛекартства3Label";
            кодЛекартства3Label.Size = new System.Drawing.Size(184, 25);
            кодЛекартства3Label.TabIndex = 14;
            кодЛекартства3Label.Text = "Код Лекартства3:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(89, 328);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 25);
            label2.TabIndex = 17;
            label2.Text = "Пациенты:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Болезни\"";
            // 
            // болезниBindingNavigator
            // 
            this.болезниBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.болезниBindingNavigator.BindingSource = this.болезниBindingSource;
            this.болезниBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.болезниBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.болезниBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.болезниBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.болезниBindingNavigatorSaveItem});
            this.болезниBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.болезниBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.болезниBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.болезниBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.болезниBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.болезниBindingNavigator.Name = "болезниBindingNavigator";
            this.болезниBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.болезниBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.болезниBindingNavigator.TabIndex = 1;
            this.болезниBindingNavigator.Text = "bindingNavigator1";
            this.болезниBindingNavigator.Visible = false;
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
            // болезниBindingSource
            // 
            this.болезниBindingSource.DataMember = "Болезни";
            this.болезниBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // болезниBindingNavigatorSaveItem
            // 
            this.болезниBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.болезниBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("болезниBindingNavigatorSaveItem.Image")));
            this.болезниBindingNavigatorSaveItem.Name = "болезниBindingNavigatorSaveItem";
            this.болезниBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.болезниBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.болезниBindingNavigatorSaveItem.Click += new System.EventHandler(this.болезниBindingNavigatorSaveItem_Click);
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(276, 76);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(480, 22);
            this.наименованиеTextBox.TabIndex = 3;
            // 
            // симптомыTextBox
            // 
            this.симптомыTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.симптомыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "Симптомы", true));
            this.симптомыTextBox.Location = new System.Drawing.Point(276, 104);
            this.симптомыTextBox.Name = "симптомыTextBox";
            this.симптомыTextBox.Size = new System.Drawing.Size(480, 22);
            this.симптомыTextBox.TabIndex = 5;
            // 
            // продолжительностьTextBox
            // 
            this.продолжительностьTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.продолжительностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "Продолжительность", true));
            this.продолжительностьTextBox.Location = new System.Drawing.Point(276, 132);
            this.продолжительностьTextBox.Name = "продолжительностьTextBox";
            this.продолжительностьTextBox.Size = new System.Drawing.Size(480, 22);
            this.продолжительностьTextBox.TabIndex = 7;
            // 
            // последствияTextBox
            // 
            this.последствияTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.последствияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "Последствия", true));
            this.последствияTextBox.Location = new System.Drawing.Point(276, 160);
            this.последствияTextBox.Name = "последствияTextBox";
            this.последствияTextBox.Size = new System.Drawing.Size(480, 22);
            this.последствияTextBox.TabIndex = 9;
            // 
            // кодЛекартства1TextBox
            // 
            this.кодЛекартства1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.кодЛекартства1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "КодЛекартства1", true));
            this.кодЛекартства1TextBox.Location = new System.Drawing.Point(276, 188);
            this.кодЛекартства1TextBox.Multiline = true;
            this.кодЛекартства1TextBox.Name = "кодЛекартства1TextBox";
            this.кодЛекартства1TextBox.Size = new System.Drawing.Size(480, 22);
            this.кодЛекартства1TextBox.TabIndex = 11;
            // 
            // кодЛекартства2TextBox
            // 
            this.кодЛекартства2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.кодЛекартства2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "КодЛекартства2", true));
            this.кодЛекартства2TextBox.Location = new System.Drawing.Point(276, 216);
            this.кодЛекартства2TextBox.Name = "кодЛекартства2TextBox";
            this.кодЛекартства2TextBox.Size = new System.Drawing.Size(480, 22);
            this.кодЛекартства2TextBox.TabIndex = 13;
            // 
            // кодЛекартства3TextBox
            // 
            this.кодЛекартства3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.кодЛекартства3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.болезниBindingSource, "КодЛекартства3", true));
            this.кодЛекартства3TextBox.Location = new System.Drawing.Point(276, 244);
            this.кодЛекартства3TextBox.Name = "кодЛекартства3TextBox";
            this.кодЛекартства3TextBox.Size = new System.Drawing.Size(480, 22);
            this.кодЛекартства3TextBox.TabIndex = 15;
            // 
            // пациентыBindingSource
            // 
            this.пациентыBindingSource.DataMember = "БолезниПациенты";
            this.пациентыBindingSource.DataSource = this.болезниBindingSource;
            // 
            // пациентыDataGridView
            // 
            this.пациентыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.пациентыDataGridView.AutoGenerateColumns = false;
            this.пациентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пациентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.пациентыDataGridView.DataSource = this.пациентыBindingSource;
            this.пациентыDataGridView.Location = new System.Drawing.Point(276, 272);
            this.пациентыDataGridView.Name = "пациентыDataGridView";
            this.пациентыDataGridView.RowHeadersWidth = 51;
            this.пациентыDataGridView.RowTemplate.Height = 24;
            this.пациентыDataGridView.Size = new System.Drawing.Size(480, 140);
            this.пациентыDataGridView.TabIndex = 16;
            this.пациентыDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.пациентыDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Возраст";
            this.dataGridViewTextBoxColumn2.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ДатаОбращения";
            this.dataGridViewTextBoxColumn6.HeaderText = "ДатаОбращения";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "КодБолезни";
            this.dataGridViewTextBoxColumn7.HeaderText = "КодБолезни";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "КодСотрудника";
            this.dataGridViewTextBoxColumn8.HeaderText = "КодСотрудника";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "РезультатЛечения";
            this.dataGridViewTextBoxColumn9.HeaderText = "РезультатЛечения";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // болезниTableAdapter
            // 
            this.болезниTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = HospitalApp.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БолезниTableAdapter = this.болезниTableAdapter;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЛекарстваTableAdapter = null;
            this.tableAdapterManager.ПациентыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // пациентыTableAdapter
            // 
            this.пациентыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(62, 426);
            this.button1.MaximumSize = new System.Drawing.Size(130, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(62, 481);
            this.button2.MaximumSize = new System.Drawing.Size(140, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(198, 425);
            this.button3.MaximumSize = new System.Drawing.Size(130, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 50);
            this.button3.TabIndex = 20;
            this.button3.Text = "Первая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(198, 481);
            this.button4.MaximumSize = new System.Drawing.Size(130, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 50);
            this.button4.TabIndex = 21;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(334, 426);
            this.button5.MaximumSize = new System.Drawing.Size(130, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 50);
            this.button5.TabIndex = 22;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(334, 481);
            this.button6.MaximumSize = new System.Drawing.Size(130, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 50);
            this.button6.TabIndex = 23;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(470, 425);
            this.button7.MaximumSize = new System.Drawing.Size(130, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 50);
            this.button7.TabIndex = 24;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(470, 481);
            this.button8.MaximumSize = new System.Drawing.Size(130, 100);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 50);
            this.button8.TabIndex = 25;
            this.button8.Text = "Закрыть";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(606, 442);
            this.button9.MaximumSize = new System.Drawing.Size(150, 100);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 71);
            this.button9.TabIndex = 26;
            this.button9.Text = "Табличная форма";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // DiseasesTapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(this.пациентыDataGridView);
            this.Controls.Add(кодЛекартства3Label);
            this.Controls.Add(this.кодЛекартства3TextBox);
            this.Controls.Add(кодЛекартства2Label);
            this.Controls.Add(this.кодЛекартства2TextBox);
            this.Controls.Add(кодЛекартства1Label);
            this.Controls.Add(this.кодЛекартства1TextBox);
            this.Controls.Add(последствияLabel);
            this.Controls.Add(this.последствияTextBox);
            this.Controls.Add(продолжительностьLabel);
            this.Controls.Add(this.продолжительностьTextBox);
            this.Controls.Add(симптомыLabel);
            this.Controls.Add(this.симптомыTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(this.болезниBindingNavigator);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiseasesTapeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Болезни | Ленточная форма";
            this.Load += new System.EventHandler(this.DiseasesTapeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.болезниBindingNavigator)).EndInit();
            this.болезниBindingNavigator.ResumeLayout(false);
            this.болезниBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.болезниBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource болезниBindingSource;
        private HospitalDataSetTableAdapters.БолезниTableAdapter болезниTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator болезниBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton болезниBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox симптомыTextBox;
        private System.Windows.Forms.TextBox продолжительностьTextBox;
        private System.Windows.Forms.TextBox последствияTextBox;
        private System.Windows.Forms.TextBox кодЛекартства1TextBox;
        private System.Windows.Forms.TextBox кодЛекартства2TextBox;
        private System.Windows.Forms.TextBox кодЛекартства3TextBox;
        private System.Windows.Forms.BindingSource пациентыBindingSource;
        private HospitalDataSetTableAdapters.ПациентыTableAdapter пациентыTableAdapter;
        private System.Windows.Forms.DataGridView пациентыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}
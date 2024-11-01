namespace DemoApp.Forms
{
    partial class SotrudnikiForm
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
            dataGridView1 = new DataGridView();
            zarplataTextBox = new TextBox();
            zarplataLabel = new Label();
            obrazovanieTextBox = new TextBox();
            obrazovanieLabel = new Label();
            godRozhdeniyaTextBox = new TextBox();
            godPostupleniyaLabel = new Label();
            godPostupleniyaTextBox = new TextBox();
            godRozhdeniyaLabel = new Label();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            RefreshTableButton = new Button();
            dolzhnostTextBox = new TextBox();
            dolzhnostLabel = new Label();
            bibliotekaIDTextBox = new TextBox();
            bibliotekaIDLabel = new Label();
            FIOTextBox = new TextBox();
            FIOLabel = new Label();
            SearchButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(906, 542);
            dataGridView1.TabIndex = 1;
            // 
            // zarplataTextBox
            // 
            zarplataTextBox.Location = new Point(924, 289);
            zarplataTextBox.Name = "zarplataTextBox";
            zarplataTextBox.Size = new Size(187, 23);
            zarplataTextBox.TabIndex = 80;
            // 
            // zarplataLabel
            // 
            zarplataLabel.AutoSize = true;
            zarplataLabel.Location = new Point(924, 271);
            zarplataLabel.Name = "zarplataLabel";
            zarplataLabel.Size = new Size(58, 15);
            zarplataLabel.TabIndex = 79;
            zarplataLabel.Text = "Зарплата";
            // 
            // obrazovanieTextBox
            // 
            obrazovanieTextBox.Location = new Point(924, 245);
            obrazovanieTextBox.Name = "obrazovanieTextBox";
            obrazovanieTextBox.Size = new Size(187, 23);
            obrazovanieTextBox.TabIndex = 78;
            // 
            // obrazovanieLabel
            // 
            obrazovanieLabel.AutoSize = true;
            obrazovanieLabel.Location = new Point(924, 227);
            obrazovanieLabel.Name = "obrazovanieLabel";
            obrazovanieLabel.Size = new Size(80, 15);
            obrazovanieLabel.TabIndex = 77;
            obrazovanieLabel.Text = "Образование";
            // 
            // godRozhdeniyaTextBox
            // 
            godRozhdeniyaTextBox.Location = new Point(924, 157);
            godRozhdeniyaTextBox.Name = "godRozhdeniyaTextBox";
            godRozhdeniyaTextBox.Size = new Size(187, 23);
            godRozhdeniyaTextBox.TabIndex = 76;
            // 
            // godPostupleniyaLabel
            // 
            godPostupleniyaLabel.AutoSize = true;
            godPostupleniyaLabel.Location = new Point(924, 183);
            godPostupleniyaLabel.Name = "godPostupleniyaLabel";
            godPostupleniyaLabel.Size = new Size(100, 15);
            godPostupleniyaLabel.TabIndex = 75;
            godPostupleniyaLabel.Text = "Год поступления";
            // 
            // godPostupleniyaTextBox
            // 
            godPostupleniyaTextBox.Location = new Point(924, 201);
            godPostupleniyaTextBox.Name = "godPostupleniyaTextBox";
            godPostupleniyaTextBox.Size = new Size(187, 23);
            godPostupleniyaTextBox.TabIndex = 74;
            // 
            // godRozhdeniyaLabel
            // 
            godRozhdeniyaLabel.AutoSize = true;
            godRozhdeniyaLabel.Location = new Point(924, 139);
            godRozhdeniyaLabel.Name = "godRozhdeniyaLabel";
            godRozhdeniyaLabel.Size = new Size(84, 15);
            godRozhdeniyaLabel.TabIndex = 73;
            godRozhdeniyaLabel.Text = "Год рождения";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(924, 420);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(187, 23);
            searchTextBox.TabIndex = 72;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(924, 402);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 15);
            searchLabel.TabIndex = 71;
            searchLabel.Text = "Поиск";
            // 
            // RefreshTableButton
            // 
            RefreshTableButton.Location = new Point(924, 478);
            RefreshTableButton.Name = "RefreshTableButton";
            RefreshTableButton.Size = new Size(187, 23);
            RefreshTableButton.TabIndex = 70;
            RefreshTableButton.Text = "Обновить Таблицу";
            RefreshTableButton.UseVisualStyleBackColor = true;
            RefreshTableButton.Click += RefreshTableButton_Click;
            // 
            // dolzhnostTextBox
            // 
            dolzhnostTextBox.Location = new Point(924, 110);
            dolzhnostTextBox.Name = "dolzhnostTextBox";
            dolzhnostTextBox.Size = new Size(187, 23);
            dolzhnostTextBox.TabIndex = 69;
            // 
            // dolzhnostLabel
            // 
            dolzhnostLabel.AutoSize = true;
            dolzhnostLabel.Location = new Point(924, 92);
            dolzhnostLabel.Name = "dolzhnostLabel";
            dolzhnostLabel.Size = new Size(69, 15);
            dolzhnostLabel.TabIndex = 68;
            dolzhnostLabel.Text = "Должность";
            // 
            // bibliotekaIDTextBox
            // 
            bibliotekaIDTextBox.Location = new Point(924, 66);
            bibliotekaIDTextBox.Name = "bibliotekaIDTextBox";
            bibliotekaIDTextBox.Size = new Size(187, 23);
            bibliotekaIDTextBox.TabIndex = 67;
            // 
            // bibliotekaIDLabel
            // 
            bibliotekaIDLabel.AutoSize = true;
            bibliotekaIDLabel.Location = new Point(924, 48);
            bibliotekaIDLabel.Name = "bibliotekaIDLabel";
            bibliotekaIDLabel.Size = new Size(87, 15);
            bibliotekaIDLabel.TabIndex = 66;
            bibliotekaIDLabel.Text = "ID библиотеки";
            // 
            // FIOTextBox
            // 
            FIOTextBox.Location = new Point(924, 22);
            FIOTextBox.Name = "FIOTextBox";
            FIOTextBox.Size = new Size(187, 23);
            FIOTextBox.TabIndex = 65;
            // 
            // FIOLabel
            // 
            FIOLabel.AutoSize = true;
            FIOLabel.Location = new Point(924, 4);
            FIOLabel.Name = "FIOLabel";
            FIOLabel.Size = new Size(34, 15);
            FIOLabel.TabIndex = 64;
            FIOLabel.Text = "ФИО";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(924, 449);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(187, 23);
            SearchButton.TabIndex = 63;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(924, 376);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(187, 23);
            DeleteButton.TabIndex = 62;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(924, 347);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(187, 23);
            EditButton.TabIndex = 61;
            EditButton.Text = "Обновить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(924, 318);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(187, 23);
            AddButton.TabIndex = 60;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SotrudnikiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1123, 566);
            Controls.Add(zarplataTextBox);
            Controls.Add(zarplataLabel);
            Controls.Add(obrazovanieTextBox);
            Controls.Add(obrazovanieLabel);
            Controls.Add(godRozhdeniyaTextBox);
            Controls.Add(godPostupleniyaLabel);
            Controls.Add(godPostupleniyaTextBox);
            Controls.Add(godRozhdeniyaLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(RefreshTableButton);
            Controls.Add(dolzhnostTextBox);
            Controls.Add(dolzhnostLabel);
            Controls.Add(bibliotekaIDTextBox);
            Controls.Add(bibliotekaIDLabel);
            Controls.Add(FIOTextBox);
            Controls.Add(FIOLabel);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "SotrudnikiForm";
            Text = "SotrudnikiForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox zarplataTextBox;
        private Label zarplataLabel;
        private TextBox obrazovanieTextBox;
        private Label obrazovanieLabel;
        private TextBox godRozhdeniyaTextBox;
        private Label godPostupleniyaLabel;
        private TextBox godPostupleniyaTextBox;
        private Label godRozhdeniyaLabel;
        private TextBox searchTextBox;
        private Label searchLabel;
        private Button RefreshTableButton;
        private TextBox dolzhnostTextBox;
        private Label dolzhnostLabel;
        private TextBox bibliotekaIDTextBox;
        private Label bibliotekaIDLabel;
        private TextBox FIOTextBox;
        private Label FIOLabel;
        private Button SearchButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
    }
}
namespace DemoApp.Forms
{
    partial class TipLiteraturyForm
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
            searchTextBox = new TextBox();
            searchLabel = new Label();
            RefreshTableButton = new Button();
            nazvanieTipaTextBox = new TextBox();
            nazvanieTipaLabel = new Label();
            SearchButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(387, 164);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(187, 23);
            searchTextBox.TabIndex = 23;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(387, 146);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 15);
            searchLabel.TabIndex = 22;
            searchLabel.Text = "Поиск";
            // 
            // RefreshTableButton
            // 
            RefreshTableButton.Location = new Point(387, 222);
            RefreshTableButton.Name = "RefreshTableButton";
            RefreshTableButton.Size = new Size(187, 23);
            RefreshTableButton.TabIndex = 21;
            RefreshTableButton.Text = "Обновить Таблицу";
            RefreshTableButton.UseVisualStyleBackColor = true;
            RefreshTableButton.Click += RefreshTableButton_Click;
            // 
            // nazvanieTipaTextBox
            // 
            nazvanieTipaTextBox.Location = new Point(387, 33);
            nazvanieTipaTextBox.Name = "nazvanieTipaTextBox";
            nazvanieTipaTextBox.Size = new Size(187, 23);
            nazvanieTipaTextBox.TabIndex = 20;
            // 
            // nazvanieTipaLabel
            // 
            nazvanieTipaLabel.AutoSize = true;
            nazvanieTipaLabel.Location = new Point(387, 15);
            nazvanieTipaLabel.Name = "nazvanieTipaLabel";
            nazvanieTipaLabel.Size = new Size(87, 15);
            nazvanieTipaLabel.TabIndex = 19;
            nazvanieTipaLabel.Text = "Название типа";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(387, 193);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(187, 23);
            SearchButton.TabIndex = 18;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(387, 120);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(187, 23);
            DeleteButton.TabIndex = 17;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(387, 91);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(187, 23);
            EditButton.TabIndex = 16;
            EditButton.Text = "Обновить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(387, 62);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(187, 23);
            AddButton.TabIndex = 15;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(369, 458);
            dataGridView1.TabIndex = 14;
            // 
            // TipLiteraturyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 482);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(RefreshTableButton);
            Controls.Add(nazvanieTipaTextBox);
            Controls.Add(nazvanieTipaLabel);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "TipLiteraturyForm";
            Text = "TipLiteraturyForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Label searchLabel;
        private Button RefreshTableButton;
        private TextBox nazvanieTipaTextBox;
        private Label nazvanieTipaLabel;
        private Button SearchButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private DataGridView dataGridView1;
    }
}
namespace DemoApp.Forms
{
    partial class BibliotekaForm
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
            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            SearchButton = new Button();
            nazvanieLabel = new Label();
            nazvanieTextBox = new TextBox();
            adresTextBox = new TextBox();
            adresLabel = new Label();
            gorodTextBox = new TextBox();
            gorodLabel = new Label();
            RefreshTableButton = new Button();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Silver;
            AddButton.Location = new Point(892, 150);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(187, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Silver;
            EditButton.Location = new Point(892, 179);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(187, 23);
            EditButton.TabIndex = 2;
            EditButton.Text = "Обновить";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Silver;
            DeleteButton.Location = new Point(892, 208);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(187, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Silver;
            SearchButton.Location = new Point(892, 281);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(187, 23);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // nazvanieLabel
            // 
            nazvanieLabel.AutoSize = true;
            nazvanieLabel.BackColor = Color.Silver;
            nazvanieLabel.Location = new Point(892, 12);
            nazvanieLabel.Name = "nazvanieLabel";
            nazvanieLabel.Size = new Size(59, 15);
            nazvanieLabel.TabIndex = 5;
            nazvanieLabel.Text = "Название";
            // 
            // nazvanieTextBox
            // 
            nazvanieTextBox.BackColor = Color.Silver;
            nazvanieTextBox.Location = new Point(892, 30);
            nazvanieTextBox.Name = "nazvanieTextBox";
            nazvanieTextBox.Size = new Size(187, 23);
            nazvanieTextBox.TabIndex = 6;
            // 
            // adresTextBox
            // 
            adresTextBox.BackColor = Color.Silver;
            adresTextBox.Location = new Point(892, 74);
            adresTextBox.Name = "adresTextBox";
            adresTextBox.Size = new Size(187, 23);
            adresTextBox.TabIndex = 8;
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.BackColor = Color.Silver;
            adresLabel.Location = new Point(892, 56);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new Size(40, 15);
            adresLabel.TabIndex = 7;
            adresLabel.Text = "Адрес";
            // 
            // gorodTextBox
            // 
            gorodTextBox.BackColor = Color.Silver;
            gorodTextBox.Location = new Point(892, 121);
            gorodTextBox.Name = "gorodTextBox";
            gorodTextBox.Size = new Size(187, 23);
            gorodTextBox.TabIndex = 10;
            // 
            // gorodLabel
            // 
            gorodLabel.AutoSize = true;
            gorodLabel.BackColor = Color.Silver;
            gorodLabel.Location = new Point(892, 103);
            gorodLabel.Name = "gorodLabel";
            gorodLabel.Size = new Size(40, 15);
            gorodLabel.TabIndex = 9;
            gorodLabel.Text = "Город";
            // 
            // RefreshTableButton
            // 
            RefreshTableButton.BackColor = Color.Silver;
            RefreshTableButton.Location = new Point(892, 310);
            RefreshTableButton.Name = "RefreshTableButton";
            RefreshTableButton.Size = new Size(187, 23);
            RefreshTableButton.TabIndex = 11;
            RefreshTableButton.Text = "Обновить Таблицу";
            RefreshTableButton.UseVisualStyleBackColor = false;
            RefreshTableButton.Click += RefreshTableButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.Silver;
            searchTextBox.Location = new Point(892, 252);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(187, 23);
            searchTextBox.TabIndex = 13;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.BackColor = Color.Silver;
            searchLabel.Location = new Point(892, 234);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 15);
            searchLabel.TabIndex = 12;
            searchLabel.Text = "Поиск";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(874, 597);
            dataGridView1.TabIndex = 0;
            // 
            // BibliotekaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1091, 621);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(RefreshTableButton);
            Controls.Add(gorodTextBox);
            Controls.Add(gorodLabel);
            Controls.Add(adresTextBox);
            Controls.Add(adresLabel);
            Controls.Add(nazvanieTextBox);
            Controls.Add(nazvanieLabel);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "BibliotekaForm";
            Text = "BibliotekaForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button SearchButton;
        private Label nazvanieLabel;
        private TextBox nazvanieTextBox;
        private TextBox adresTextBox;
        private Label adresLabel;
        private TextBox gorodTextBox;
        private Label gorodLabel;
        private Button RefreshTableButton;
        private TextBox searchTextBox;
        private Label searchLabel;
        private DataGridView dataGridView1;
    }
}
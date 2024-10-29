namespace DemoApp.Forms
{
    partial class FondBibliotekiForm
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
            searchTextBox = new TextBox();
            searchLabel = new Label();
            RefreshTableButton = new Button();
            kolichestvoKnigTextBox = new TextBox();
            kolichestvoKnigLabel = new Label();
            bibliotekaIDTextBox = new TextBox();
            bibliotekaIdLabel = new Label();
            nazvanieFondTextBox = new TextBox();
            nazvanieFondLabel = new Label();
            SearchButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            kolichestvoSbornikovTextBox = new TextBox();
            kolichestvoSbornikovLabel = new Label();
            kolichestvoZurnalovTextBox = new TextBox();
            kolichestvoGazetLabel = new Label();
            kolichestvoGazetTextBox = new TextBox();
            kolichestvoZurnalovLabel = new Label();
            kolichestvoDissLabel = new Label();
            kolichestvoDissTextBox = new TextBox();
            kolichestvoReferatovLabel = new Label();
            kolichestvoReferatovTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(874, 597);
            dataGridView1.TabIndex = 1;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(892, 471);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(187, 23);
            searchTextBox.TabIndex = 26;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(892, 453);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 15);
            searchLabel.TabIndex = 25;
            searchLabel.Text = "Поиск";
            // 
            // RefreshTableButton
            // 
            RefreshTableButton.Location = new Point(892, 529);
            RefreshTableButton.Name = "RefreshTableButton";
            RefreshTableButton.Size = new Size(187, 23);
            RefreshTableButton.TabIndex = 24;
            RefreshTableButton.Text = "Обновить Таблицу";
            RefreshTableButton.UseVisualStyleBackColor = true;
            RefreshTableButton.Click += RefreshTableButton_Click;
            // 
            // kolichestvoKnigTextBox
            // 
            kolichestvoKnigTextBox.Location = new Point(892, 117);
            kolichestvoKnigTextBox.Name = "kolichestvoKnigTextBox";
            kolichestvoKnigTextBox.Size = new Size(187, 23);
            kolichestvoKnigTextBox.TabIndex = 23;
            // 
            // kolichestvoKnigLabel
            // 
            kolichestvoKnigLabel.AutoSize = true;
            kolichestvoKnigLabel.Location = new Point(892, 99);
            kolichestvoKnigLabel.Name = "kolichestvoKnigLabel";
            kolichestvoKnigLabel.Size = new Size(100, 15);
            kolichestvoKnigLabel.TabIndex = 22;
            kolichestvoKnigLabel.Text = "Количество книг";
            // 
            // bibliotekaIDTextBox
            // 
            bibliotekaIDTextBox.Location = new Point(892, 73);
            bibliotekaIDTextBox.Name = "bibliotekaIDTextBox";
            bibliotekaIDTextBox.Size = new Size(187, 23);
            bibliotekaIDTextBox.TabIndex = 21;
            // 
            // bibliotekaIdLabel
            // 
            bibliotekaIdLabel.AutoSize = true;
            bibliotekaIdLabel.Location = new Point(892, 55);
            bibliotekaIdLabel.Name = "bibliotekaIdLabel";
            bibliotekaIdLabel.Size = new Size(87, 15);
            bibliotekaIdLabel.TabIndex = 20;
            bibliotekaIdLabel.Text = "ID библиотеки";
            // 
            // nazvanieFondTextBox
            // 
            nazvanieFondTextBox.Location = new Point(892, 29);
            nazvanieFondTextBox.Name = "nazvanieFondTextBox";
            nazvanieFondTextBox.Size = new Size(187, 23);
            nazvanieFondTextBox.TabIndex = 19;
            // 
            // nazvanieFondLabel
            // 
            nazvanieFondLabel.AutoSize = true;
            nazvanieFondLabel.Location = new Point(892, 11);
            nazvanieFondLabel.Name = "nazvanieFondLabel";
            nazvanieFondLabel.Size = new Size(97, 15);
            nazvanieFondLabel.TabIndex = 18;
            nazvanieFondLabel.Text = "Название фонда";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(892, 500);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(187, 23);
            SearchButton.TabIndex = 17;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(892, 427);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(187, 23);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(892, 398);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(187, 23);
            EditButton.TabIndex = 15;
            EditButton.Text = "Обновить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(892, 369);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(187, 23);
            AddButton.TabIndex = 14;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // kolichestvoSbornikovTextBox
            // 
            kolichestvoSbornikovTextBox.Location = new Point(892, 252);
            kolichestvoSbornikovTextBox.Name = "kolichestvoSbornikovTextBox";
            kolichestvoSbornikovTextBox.Size = new Size(187, 23);
            kolichestvoSbornikovTextBox.TabIndex = 32;
            // 
            // kolichestvoSbornikovLabel
            // 
            kolichestvoSbornikovLabel.AutoSize = true;
            kolichestvoSbornikovLabel.Location = new Point(892, 234);
            kolichestvoSbornikovLabel.Name = "kolichestvoSbornikovLabel";
            kolichestvoSbornikovLabel.Size = new Size(135, 15);
            kolichestvoSbornikovLabel.TabIndex = 31;
            kolichestvoSbornikovLabel.Text = "Количество сборников";
            // 
            // kolichestvoZurnalovTextBox
            // 
            kolichestvoZurnalovTextBox.Location = new Point(892, 164);
            kolichestvoZurnalovTextBox.Name = "kolichestvoZurnalovTextBox";
            kolichestvoZurnalovTextBox.Size = new Size(187, 23);
            kolichestvoZurnalovTextBox.TabIndex = 30;
            // 
            // kolichestvoGazetLabel
            // 
            kolichestvoGazetLabel.AutoSize = true;
            kolichestvoGazetLabel.Location = new Point(892, 190);
            kolichestvoGazetLabel.Name = "kolichestvoGazetLabel";
            kolichestvoGazetLabel.Size = new Size(102, 15);
            kolichestvoGazetLabel.TabIndex = 29;
            kolichestvoGazetLabel.Text = "Количество газет";
            // 
            // kolichestvoGazetTextBox
            // 
            kolichestvoGazetTextBox.Location = new Point(892, 208);
            kolichestvoGazetTextBox.Name = "kolichestvoGazetTextBox";
            kolichestvoGazetTextBox.Size = new Size(187, 23);
            kolichestvoGazetTextBox.TabIndex = 28;
            // 
            // kolichestvoZurnalovLabel
            // 
            kolichestvoZurnalovLabel.AutoSize = true;
            kolichestvoZurnalovLabel.Location = new Point(892, 146);
            kolichestvoZurnalovLabel.Name = "kolichestvoZurnalovLabel";
            kolichestvoZurnalovLabel.Size = new Size(130, 15);
            kolichestvoZurnalovLabel.TabIndex = 27;
            kolichestvoZurnalovLabel.Text = "Количество журналов";
            // 
            // kolichestvoDissLabel
            // 
            kolichestvoDissLabel.AutoSize = true;
            kolichestvoDissLabel.Location = new Point(892, 278);
            kolichestvoDissLabel.Name = "kolichestvoDissLabel";
            kolichestvoDissLabel.Size = new Size(145, 15);
            kolichestvoDissLabel.TabIndex = 33;
            kolichestvoDissLabel.Text = "Количество диссертаций";
            // 
            // kolichestvoDissTextBox
            // 
            kolichestvoDissTextBox.Location = new Point(892, 296);
            kolichestvoDissTextBox.Name = "kolichestvoDissTextBox";
            kolichestvoDissTextBox.Size = new Size(187, 23);
            kolichestvoDissTextBox.TabIndex = 34;
            // 
            // kolichestvoReferatovLabel
            // 
            kolichestvoReferatovLabel.AutoSize = true;
            kolichestvoReferatovLabel.Location = new Point(892, 322);
            kolichestvoReferatovLabel.Name = "kolichestvoReferatovLabel";
            kolichestvoReferatovLabel.Size = new Size(134, 15);
            kolichestvoReferatovLabel.TabIndex = 35;
            kolichestvoReferatovLabel.Text = "Количество рефератов";
            // 
            // kolichestvoReferatovTextBox
            // 
            kolichestvoReferatovTextBox.Location = new Point(894, 340);
            kolichestvoReferatovTextBox.Name = "kolichestvoReferatovTextBox";
            kolichestvoReferatovTextBox.Size = new Size(187, 23);
            kolichestvoReferatovTextBox.TabIndex = 36;
            // 
            // FondBibliotekiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 624);
            Controls.Add(kolichestvoReferatovTextBox);
            Controls.Add(kolichestvoReferatovLabel);
            Controls.Add(kolichestvoDissTextBox);
            Controls.Add(kolichestvoDissLabel);
            Controls.Add(kolichestvoSbornikovTextBox);
            Controls.Add(kolichestvoSbornikovLabel);
            Controls.Add(kolichestvoZurnalovTextBox);
            Controls.Add(kolichestvoGazetLabel);
            Controls.Add(kolichestvoGazetTextBox);
            Controls.Add(kolichestvoZurnalovLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(RefreshTableButton);
            Controls.Add(kolichestvoKnigTextBox);
            Controls.Add(kolichestvoKnigLabel);
            Controls.Add(bibliotekaIDTextBox);
            Controls.Add(bibliotekaIdLabel);
            Controls.Add(nazvanieFondTextBox);
            Controls.Add(nazvanieFondLabel);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "FondBibliotekiForm";
            Text = "FondBibliotekiForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox searchTextBox;
        private Label searchLabel;
        private Button RefreshTableButton;
        private TextBox kolichestvoKnigTextBox;
        private Label kolichestvoKnigLabel;
        private TextBox bibliotekaIDTextBox;
        private Label bibliotekaIdLabel;
        private TextBox nazvanieFondTextBox;
        private Label nazvanieFondLabel;
        private Button SearchButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private TextBox kolichestvoSbornikovTextBox;
        private Label kolichestvoSbornikovLabel;
        private TextBox kolichestvoZurnalovTextBox;
        private Label kolichestvoGazetLabel;
        private TextBox kolichestvoGazetTextBox;
        private Label kolichestvoZurnalovLabel;
        private Label kolichestvoDissLabel;
        private TextBox kolichestvoDissTextBox;
        private Label kolichestvoReferatovLabel;
        private TextBox kolichestvoReferatovTextBox;
    }
}
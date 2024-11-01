namespace DemoApp.Forms
{
    partial class PopolnenieFondaForm
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
            kolichestvoEkzemplyarovTextBox = new TextBox();
            kolichestvoEkzemplyaroveLabel = new Label();
            dataIzdaniaTextBox = new TextBox();
            dataIzdaniaLabel = new Label();
            izdatelstvoTextBox = new TextBox();
            izdatelstvoLabel = new Label();
            nazavanieIstochnikaTextBox = new TextBox();
            tipLiteraturyLabel = new Label();
            tipLiteraturyTextBox = new TextBox();
            nazavanieIstochnikaLabel = new Label();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            RefreshTableButton = new Button();
            dataPopolneniaTextBox = new TextBox();
            dataPopolneniaLabel = new Label();
            sotrudnikIDTextBox = new TextBox();
            sotrudnikIdLabel = new Label();
            fondIdTextBox = new TextBox();
            fondIdLabel = new Label();
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
            dataGridView1.Size = new Size(997, 542);
            dataGridView1.TabIndex = 0;
            // 
            // kolichestvoEkzemplyarovTextBox
            // 
            kolichestvoEkzemplyarovTextBox.Location = new Point(1017, 342);
            kolichestvoEkzemplyarovTextBox.Name = "kolichestvoEkzemplyarovTextBox";
            kolichestvoEkzemplyarovTextBox.Size = new Size(187, 23);
            kolichestvoEkzemplyarovTextBox.TabIndex = 59;
            // 
            // kolichestvoEkzemplyaroveLabel
            // 
            kolichestvoEkzemplyaroveLabel.AutoSize = true;
            kolichestvoEkzemplyaroveLabel.Location = new Point(1015, 324);
            kolichestvoEkzemplyaroveLabel.Name = "kolichestvoEkzemplyaroveLabel";
            kolichestvoEkzemplyaroveLabel.Size = new Size(147, 15);
            kolichestvoEkzemplyaroveLabel.TabIndex = 58;
            kolichestvoEkzemplyaroveLabel.Text = "Количество экземпляров";
            // 
            // dataIzdaniaTextBox
            // 
            dataIzdaniaTextBox.Location = new Point(1015, 298);
            dataIzdaniaTextBox.Name = "dataIzdaniaTextBox";
            dataIzdaniaTextBox.Size = new Size(187, 23);
            dataIzdaniaTextBox.TabIndex = 57;
            // 
            // dataIzdaniaLabel
            // 
            dataIzdaniaLabel.AutoSize = true;
            dataIzdaniaLabel.Location = new Point(1015, 280);
            dataIzdaniaLabel.Name = "dataIzdaniaLabel";
            dataIzdaniaLabel.Size = new Size(79, 15);
            dataIzdaniaLabel.TabIndex = 56;
            dataIzdaniaLabel.Text = "Дата издания";
            // 
            // izdatelstvoTextBox
            // 
            izdatelstvoTextBox.Location = new Point(1015, 254);
            izdatelstvoTextBox.Name = "izdatelstvoTextBox";
            izdatelstvoTextBox.Size = new Size(187, 23);
            izdatelstvoTextBox.TabIndex = 55;
            // 
            // izdatelstvoLabel
            // 
            izdatelstvoLabel.AutoSize = true;
            izdatelstvoLabel.Location = new Point(1015, 236);
            izdatelstvoLabel.Name = "izdatelstvoLabel";
            izdatelstvoLabel.Size = new Size(81, 15);
            izdatelstvoLabel.TabIndex = 54;
            izdatelstvoLabel.Text = "Издательство";
            // 
            // nazavanieIstochnikaTextBox
            // 
            nazavanieIstochnikaTextBox.Location = new Point(1015, 166);
            nazavanieIstochnikaTextBox.Name = "nazavanieIstochnikaTextBox";
            nazavanieIstochnikaTextBox.Size = new Size(187, 23);
            nazavanieIstochnikaTextBox.TabIndex = 53;
            // 
            // tipLiteraturyLabel
            // 
            tipLiteraturyLabel.AutoSize = true;
            tipLiteraturyLabel.Location = new Point(1015, 192);
            tipLiteraturyLabel.Name = "tipLiteraturyLabel";
            tipLiteraturyLabel.Size = new Size(108, 15);
            tipLiteraturyLabel.TabIndex = 52;
            tipLiteraturyLabel.Text = "ID тип литературы";
            // 
            // tipLiteraturyTextBox
            // 
            tipLiteraturyTextBox.Location = new Point(1015, 210);
            tipLiteraturyTextBox.Name = "tipLiteraturyTextBox";
            tipLiteraturyTextBox.Size = new Size(187, 23);
            tipLiteraturyTextBox.TabIndex = 51;
            // 
            // nazavanieIstochnikaLabel
            // 
            nazavanieIstochnikaLabel.AutoSize = true;
            nazavanieIstochnikaLabel.Location = new Point(1015, 148);
            nazavanieIstochnikaLabel.Name = "nazavanieIstochnikaLabel";
            nazavanieIstochnikaLabel.Size = new Size(120, 15);
            nazavanieIstochnikaLabel.TabIndex = 50;
            nazavanieIstochnikaLabel.Text = "Название источника";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(1015, 473);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(187, 23);
            searchTextBox.TabIndex = 49;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(1015, 455);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 15);
            searchLabel.TabIndex = 48;
            searchLabel.Text = "Поиск";
            // 
            // RefreshTableButton
            // 
            RefreshTableButton.Location = new Point(1015, 531);
            RefreshTableButton.Name = "RefreshTableButton";
            RefreshTableButton.Size = new Size(187, 23);
            RefreshTableButton.TabIndex = 47;
            RefreshTableButton.Text = "Обновить Таблицу";
            RefreshTableButton.UseVisualStyleBackColor = true;
            RefreshTableButton.Click += RefreshTableButton_Click;
            // 
            // dataPopolneniaTextBox
            // 
            dataPopolneniaTextBox.Location = new Point(1015, 119);
            dataPopolneniaTextBox.Name = "dataPopolneniaTextBox";
            dataPopolneniaTextBox.Size = new Size(187, 23);
            dataPopolneniaTextBox.TabIndex = 46;
            // 
            // dataPopolneniaLabel
            // 
            dataPopolneniaLabel.AutoSize = true;
            dataPopolneniaLabel.Location = new Point(1015, 101);
            dataPopolneniaLabel.Name = "dataPopolneniaLabel";
            dataPopolneniaLabel.Size = new Size(103, 15);
            dataPopolneniaLabel.TabIndex = 45;
            dataPopolneniaLabel.Text = "Дата пополнения";
            // 
            // sotrudnikIDTextBox
            // 
            sotrudnikIDTextBox.Location = new Point(1015, 75);
            sotrudnikIDTextBox.Name = "sotrudnikIDTextBox";
            sotrudnikIDTextBox.Size = new Size(187, 23);
            sotrudnikIDTextBox.TabIndex = 44;
            // 
            // sotrudnikIdLabel
            // 
            sotrudnikIdLabel.AutoSize = true;
            sotrudnikIdLabel.Location = new Point(1015, 57);
            sotrudnikIdLabel.Name = "sotrudnikIdLabel";
            sotrudnikIdLabel.Size = new Size(84, 15);
            sotrudnikIdLabel.TabIndex = 43;
            sotrudnikIdLabel.Text = "ID сотрудника";
            // 
            // fondIdTextBox
            // 
            fondIdTextBox.Location = new Point(1015, 31);
            fondIdTextBox.Name = "fondIdTextBox";
            fondIdTextBox.Size = new Size(187, 23);
            fondIdTextBox.TabIndex = 42;
            // 
            // fondIdLabel
            // 
            fondIdLabel.AutoSize = true;
            fondIdLabel.Location = new Point(1015, 13);
            fondIdLabel.Name = "fondIdLabel";
            fondIdLabel.Size = new Size(56, 15);
            fondIdLabel.TabIndex = 41;
            fondIdLabel.Text = "ID фонда";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(1015, 502);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(187, 23);
            SearchButton.TabIndex = 40;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(1015, 429);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(187, 23);
            DeleteButton.TabIndex = 39;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(1015, 400);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(187, 23);
            EditButton.TabIndex = 38;
            EditButton.Text = "Обновить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(1015, 371);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(187, 23);
            AddButton.TabIndex = 37;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // PopolnenieFondaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 565);
            Controls.Add(kolichestvoEkzemplyarovTextBox);
            Controls.Add(kolichestvoEkzemplyaroveLabel);
            Controls.Add(dataIzdaniaTextBox);
            Controls.Add(dataIzdaniaLabel);
            Controls.Add(izdatelstvoTextBox);
            Controls.Add(izdatelstvoLabel);
            Controls.Add(nazavanieIstochnikaTextBox);
            Controls.Add(tipLiteraturyLabel);
            Controls.Add(tipLiteraturyTextBox);
            Controls.Add(nazavanieIstochnikaLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(RefreshTableButton);
            Controls.Add(dataPopolneniaTextBox);
            Controls.Add(dataPopolneniaLabel);
            Controls.Add(sotrudnikIDTextBox);
            Controls.Add(sotrudnikIdLabel);
            Controls.Add(fondIdTextBox);
            Controls.Add(fondIdLabel);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(dataGridView1);
            Name = "PopolnenieFondaForm";
            Text = "PopolnenieFondaForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox kolichestvoEkzemplyarovTextBox;
        private Label kolichestvoEkzemplyaroveLabel;
        private TextBox dataIzdaniaTextBox;
        private Label dataIzdaniaLabel;
        private TextBox izdatelstvoTextBox;
        private Label izdatelstvoLabel;
        private TextBox nazavanieIstochnikaTextBox;
        private Label tipLiteraturyLabel;
        private TextBox tipLiteraturyTextBox;
        private Label nazavanieIstochnikaLabel;
        private TextBox searchTextBox;
        private Label searchLabel;
        private Button RefreshTableButton;
        private TextBox dataPopolneniaTextBox;
        private Label dataPopolneniaLabel;
        private TextBox sotrudnikIDTextBox;
        private Label sotrudnikIdLabel;
        private TextBox fondIdTextBox;
        private Label fondIdLabel;
        private Button SearchButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
    }
}
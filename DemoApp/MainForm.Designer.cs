namespace DemoApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bibliotekiButton = new Button();
            fondBibliotekButton = new Button();
            tipLiteraturyButton = new Button();
            sotrudnikiButton = new Button();
            popolnenieFondaButton = new Button();
            SuspendLayout();
            // 
            // bibliotekiButton
            // 
            bibliotekiButton.Font = new Font("Segoe UI", 20.25F);
            bibliotekiButton.Location = new Point(12, 12);
            bibliotekiButton.Name = "bibliotekiButton";
            bibliotekiButton.Size = new Size(296, 58);
            bibliotekiButton.TabIndex = 0;
            bibliotekiButton.Text = "Библиотеки";
            bibliotekiButton.UseVisualStyleBackColor = true;
            bibliotekiButton.Click += bibliotekiButton_Click;
            // 
            // fondBibliotekButton
            // 
            fondBibliotekButton.Font = new Font("Segoe UI", 20.25F);
            fondBibliotekButton.Location = new Point(12, 76);
            fondBibliotekButton.Name = "fondBibliotekButton";
            fondBibliotekButton.Size = new Size(296, 58);
            fondBibliotekButton.TabIndex = 2;
            fondBibliotekButton.Text = "Фонд библиотек";
            fondBibliotekButton.UseVisualStyleBackColor = true;
            fondBibliotekButton.Click += fondBibliotekButton_Click;
            // 
            // tipLiteraturyButton
            // 
            tipLiteraturyButton.Font = new Font("Segoe UI", 20.25F);
            tipLiteraturyButton.Location = new Point(12, 207);
            tipLiteraturyButton.Name = "tipLiteraturyButton";
            tipLiteraturyButton.Size = new Size(296, 58);
            tipLiteraturyButton.TabIndex = 3;
            tipLiteraturyButton.Text = "Тип литературы";
            tipLiteraturyButton.UseVisualStyleBackColor = true;
            tipLiteraturyButton.Click += tipLiteraturyButton_Click;
            // 
            // sotrudnikiButton
            // 
            sotrudnikiButton.Font = new Font("Segoe UI", 20.25F);
            sotrudnikiButton.Location = new Point(12, 143);
            sotrudnikiButton.Name = "sotrudnikiButton";
            sotrudnikiButton.Size = new Size(296, 58);
            sotrudnikiButton.TabIndex = 4;
            sotrudnikiButton.Text = "Сотрудники";
            sotrudnikiButton.UseVisualStyleBackColor = true;
            sotrudnikiButton.Click += sotrudnikiButton_Click;
            // 
            // popolnenieFondaButton
            // 
            popolnenieFondaButton.Font = new Font("Segoe UI", 20.25F);
            popolnenieFondaButton.Location = new Point(12, 271);
            popolnenieFondaButton.Name = "popolnenieFondaButton";
            popolnenieFondaButton.Size = new Size(296, 58);
            popolnenieFondaButton.TabIndex = 5;
            popolnenieFondaButton.Text = "Пополнение фонда";
            popolnenieFondaButton.UseVisualStyleBackColor = true;
            popolnenieFondaButton.Click += popolnenieFondaButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 350);
            Controls.Add(popolnenieFondaButton);
            Controls.Add(sotrudnikiButton);
            Controls.Add(tipLiteraturyButton);
            Controls.Add(fondBibliotekButton);
            Controls.Add(bibliotekiButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button bibliotekiButton;
        private Button fondBibliotekButton;
        private Button tipLiteraturyButton;
        private Button sotrudnikiButton;
        private Button popolnenieFondaButton;
    }
}

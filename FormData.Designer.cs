namespace Aviasales
{
    partial class FormData
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
            textBoxName = new TextBox();
            comboBox1 = new ComboBox();
            labelName = new Label();
            labelPlace = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(62, 65);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(294, 23);
            textBoxName.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(67, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(62, 35);
            labelName.Name = "labelName";
            labelName.Size = new Size(139, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Фамилия Имя Отчество";
            // 
            // labelPlace
            // 
            labelPlace.AutoSize = true;
            labelPlace.Location = new Point(67, 125);
            labelPlace.Name = "labelPlace";
            labelPlace.Size = new Size(97, 15);
            labelPlace.TabIndex = 4;
            labelPlace.Text = "Выберите место";
            // 
            // button1
            // 
            button1.Location = new Point(259, 155);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 254);
            Controls.Add(button1);
            Controls.Add(labelPlace);
            Controls.Add(labelName);
            Controls.Add(comboBox1);
            Controls.Add(textBoxName);
            Name = "FormData";
            Text = "FormData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label labelName;
        private Label labelPlace;
        private Button button1;
    }
}
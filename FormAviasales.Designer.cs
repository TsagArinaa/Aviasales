namespace Aviasales
{
    partial class FormAviasales
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
            label1 = new Label();
            listBoxFligth = new ListBox();
            listBoxSelected = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "Список рейсов";
            label1.Click += label1_Click;
            // 
            // listBoxFligth
            // 
            listBoxFligth.FormattingEnabled = true;
            listBoxFligth.ItemHeight = 15;
            listBoxFligth.Location = new Point(12, 59);
            listBoxFligth.Name = "listBoxFligth";
            listBoxFligth.Size = new Size(278, 379);
            listBoxFligth.TabIndex = 1;
            listBoxFligth.DoubleClick += listBoxFligth_DoubleClick;
            // 
            // listBoxSelected
            // 
            listBoxSelected.FormattingEnabled = true;
            listBoxSelected.ItemHeight = 15;
            listBoxSelected.Location = new Point(517, 59);
            listBoxSelected.Name = "listBoxSelected";
            listBoxSelected.Size = new Size(271, 379);
            listBoxSelected.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(507, 25);
            label2.Name = "label2";
            label2.Size = new Size(260, 32);
            label2.TabIndex = 3;
            label2.Text = "Выбранные рейсы";
            // 
            // FormAviasales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listBoxSelected);
            Controls.Add(listBoxFligth);
            Controls.Add(label1);
            Name = "FormAviasales";
            Text = "Main Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxFligth;
        private ListBox listBoxSelected;
        private Label label2;
    }
}

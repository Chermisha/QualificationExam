namespace ServiceAccounting
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addServiceButton = new System.Windows.Forms.Button();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.servicesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(250, 298);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(75, 23);
            this.addServiceButton.TabIndex = 0;
            this.addServiceButton.Text = "button1";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(153, 97);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(101, 20);
            this.costTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(153, 152);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(101, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // servicesListBox
            // 
            this.servicesListBox.FormattingEnabled = true;
            this.servicesListBox.Location = new System.Drawing.Point(337, 119);
            this.servicesListBox.Name = "servicesListBox";
            this.servicesListBox.Size = new System.Drawing.Size(120, 95);
            this.servicesListBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.servicesListBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.addServiceButton);
            this.Name = "MainForm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox servicesListBox;
    }
}


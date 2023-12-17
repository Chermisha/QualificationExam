namespace ServiceAccounting
{
    partial class ServiceForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkDescriptionButton = new System.Windows.Forms.Button();
            this.servicesListBox = new System.Windows.Forms.ListBox();
            this.ExportToExcelButton = new System.Windows.Forms.Button();
            this.ImportToExcelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteAllButton1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServicesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.addServisesToolStripMenuItem_Click);
            // 
            // addServicesToolStripMenuItem
            // 
            this.addServicesToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addServicesToolStripMenuItem.Name = "addServicesToolStripMenuItem";
            this.addServicesToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.addServicesToolStripMenuItem.Text = "Добавить услугу";
            this.addServicesToolStripMenuItem.Click += new System.EventHandler(this.addServisesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // checkDescriptionButton
            // 
            this.checkDescriptionButton.Location = new System.Drawing.Point(366, 348);
            this.checkDescriptionButton.Name = "checkDescriptionButton";
            this.checkDescriptionButton.Size = new System.Drawing.Size(154, 23);
            this.checkDescriptionButton.TabIndex = 2;
            this.checkDescriptionButton.Text = "Изменить";
            this.checkDescriptionButton.UseVisualStyleBackColor = true;
            this.checkDescriptionButton.Click += new System.EventHandler(this.checkDescriptionButton_Click);
            // 
            // servicesListBox
            // 
            this.servicesListBox.FormattingEnabled = true;
            this.servicesListBox.Location = new System.Drawing.Point(14, 98);
            this.servicesListBox.Name = "servicesListBox";
            this.servicesListBox.Size = new System.Drawing.Size(506, 225);
            this.servicesListBox.TabIndex = 4;
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.Location = new System.Drawing.Point(16, 348);
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(154, 23);
            this.ExportToExcelButton.TabIndex = 12;
            this.ExportToExcelButton.Text = "Экспорт";
            this.ExportToExcelButton.UseVisualStyleBackColor = true;
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
            // 
            // ImportToExcelButton
            // 
            this.ImportToExcelButton.Location = new System.Drawing.Point(16, 377);
            this.ImportToExcelButton.Name = "ImportToExcelButton";
            this.ImportToExcelButton.Size = new System.Drawing.Size(154, 23);
            this.ImportToExcelButton.TabIndex = 11;
            this.ImportToExcelButton.Text = "Импорт";
            this.ImportToExcelButton.UseVisualStyleBackColor = true;
            this.ImportToExcelButton.Click += new System.EventHandler(this.ImportFromExcelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Все услуги";
            // 
            // deleteAllButton1
            // 
            this.deleteAllButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteAllButton1.Location = new System.Drawing.Point(14, 423);
            this.deleteAllButton1.Name = "deleteAllButton1";
            this.deleteAllButton1.Size = new System.Drawing.Size(154, 23);
            this.deleteAllButton1.TabIndex = 14;
            this.deleteAllButton1.Text = "Удалить все";
            this.deleteAllButton1.UseVisualStyleBackColor = true;
            this.deleteAllButton1.Click += new System.EventHandler(this.deleteAllButton1_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(562, 477);
            this.Controls.Add(this.deleteAllButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportToExcelButton);
            this.Controls.Add(this.ImportToExcelButton);
            this.Controls.Add(this.servicesListBox);
            this.Controls.Add(this.checkDescriptionButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServiceForm";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addServicesToolStripMenuItem;
        private System.Windows.Forms.Button checkDescriptionButton;
        private System.Windows.Forms.ListBox servicesListBox;
        private System.Windows.Forms.Button ExportToExcelButton;
        private System.Windows.Forms.Button ImportToExcelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button deleteAllButton1;
    }
}
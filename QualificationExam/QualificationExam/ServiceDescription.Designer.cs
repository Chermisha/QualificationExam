namespace ServiceAccounting
{
    partial class ServiceDescription
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
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.costTextBox2 = new System.Windows.Forms.TextBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox3 = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.saveChangeButton1 = new System.Windows.Forms.Button();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel1.Location = new System.Drawing.Point(34, 69);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(126, 20);
            this.nameLabel1.TabIndex = 0;
            this.nameLabel1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(188, 71);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(223, 20);
            this.nameTextBox1.TabIndex = 3;
            // 
            // costTextBox2
            // 
            this.costTextBox2.Location = new System.Drawing.Point(188, 109);
            this.costTextBox2.Name = "costTextBox2";
            this.costTextBox2.Size = new System.Drawing.Size(135, 20);
            this.costTextBox2.TabIndex = 4;
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceLabel.Location = new System.Drawing.Point(24, 18);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(64, 20);
            this.serviceLabel.TabIndex = 5;
            this.serviceLabel.Text = "Услуга:";
            // 
            // descriptionTextBox3
            // 
            this.descriptionTextBox3.Location = new System.Drawing.Point(38, 180);
            this.descriptionTextBox3.Multiline = true;
            this.descriptionTextBox3.Name = "descriptionTextBox3";
            this.descriptionTextBox3.Size = new System.Drawing.Size(373, 150);
            this.descriptionTextBox3.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(38, 358);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveChangeButton1
            // 
            this.saveChangeButton1.Location = new System.Drawing.Point(280, 358);
            this.saveChangeButton1.Name = "saveChangeButton1";
            this.saveChangeButton1.Size = new System.Drawing.Size(131, 23);
            this.saveChangeButton1.TabIndex = 8;
            this.saveChangeButton1.Text = "Сохранить изменения";
            this.saveChangeButton1.UseVisualStyleBackColor = true;
            this.saveChangeButton1.Click += new System.EventHandler(this.saveChangeButton1_Click);
            // 
            // deleteButton1
            // 
            this.deleteButton1.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteButton1.Location = new System.Drawing.Point(280, 388);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(131, 23);
            this.deleteButton1.TabIndex = 9;
            this.deleteButton1.Text = "Удалить услугу";
            this.deleteButton1.UseVisualStyleBackColor = false;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // ServiceDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 423);
            this.Controls.Add(this.deleteButton1);
            this.Controls.Add(this.saveChangeButton1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.descriptionTextBox3);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.costTextBox2);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel1);
            this.Name = "ServiceDescription";
            this.Text = "ServiceDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox costTextBox2;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.TextBox descriptionTextBox3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveChangeButton1;
        private System.Windows.Forms.Button deleteButton1;
    }
}

namespace PR2_Surgai_ZVD4
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
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.createListButton = new System.Windows.Forms.Button();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchAddressTextBox = new System.Windows.Forms.TextBox();
            this.searchAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(27, 37);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(73, 16);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Прізвище:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(67, 80);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Ім\'я:";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(11, 124);
            this.patronymicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(89, 16);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "По-батькові:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(11, 161);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(178, 16);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Адреса (вулиця, будинок):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата народження:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(108, 34);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(211, 22);
            this.surnameTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(108, 77);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(108, 121);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(211, 22);
            this.patronymicTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(108, 195);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(211, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(108, 258);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(211, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn,
            this.patronymicColumn,
            this.addressColumn,
            this.dateOfBirthColumn});
            this.dataGridView.Location = new System.Drawing.Point(339, 77);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(552, 203);
            this.dataGridView.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(70, 307);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 45);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Створити запис";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // createListButton
            // 
            this.createListButton.Location = new System.Drawing.Point(681, 307);
            this.createListButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createListButton.Name = "createListButton";
            this.createListButton.Size = new System.Drawing.Size(210, 45);
            this.createListButton.TabIndex = 12;
            this.createListButton.Text = "Створити список виборців";
            this.createListButton.UseVisualStyleBackColor = true;
            this.createListButton.Click += new System.EventHandler(this.createListButton_Click);
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Прізвище";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Ім\'я";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // patronymicColumn
            // 
            this.patronymicColumn.HeaderText = "По-батькові";
            this.patronymicColumn.Name = "patronymicColumn";
            this.patronymicColumn.ReadOnly = true;
            // 
            // addressColumn
            // 
            this.addressColumn.HeaderText = "Адреса";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // dateOfBirthColumn
            // 
            this.dateOfBirthColumn.HeaderText = "Дата народження";
            this.dateOfBirthColumn.Name = "dateOfBirthColumn";
            this.dateOfBirthColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Мешканці";
            // 
            // searchAddressTextBox
            // 
            this.searchAddressTextBox.Location = new System.Drawing.Point(471, 318);
            this.searchAddressTextBox.Name = "searchAddressTextBox";
            this.searchAddressTextBox.Size = new System.Drawing.Size(165, 22);
            this.searchAddressTextBox.TabIndex = 14;
            // 
            // searchAddressLabel
            // 
            this.searchAddressLabel.AutoSize = true;
            this.searchAddressLabel.Location = new System.Drawing.Point(337, 321);
            this.searchAddressLabel.Name = "searchAddressLabel";
            this.searchAddressLabel.Size = new System.Drawing.Size(128, 16);
            this.searchAddressLabel.TabIndex = 15;
            this.searchAddressLabel.Text = "Необхідна адреса:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 373);
            this.Controls.Add(this.searchAddressLabel);
            this.Controls.Add(this.searchAddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createListButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сургай П-81";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button createListButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchAddressTextBox;
        private System.Windows.Forms.Label searchAddressLabel;
    }
}


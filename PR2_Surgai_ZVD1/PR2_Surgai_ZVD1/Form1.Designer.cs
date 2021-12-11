
namespace PR2_Surgai_ZVD1
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.longestSurnameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 356);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 396);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(123, 395);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 41);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Сортувати";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // longestSurnameButton
            // 
            this.longestSurnameButton.Location = new System.Drawing.Point(230, 395);
            this.longestSurnameButton.Name = "longestSurnameButton";
            this.longestSurnameButton.Size = new System.Drawing.Size(75, 41);
            this.longestSurnameButton.TabIndex = 3;
            this.longestSurnameButton.Text = "Найдовше прізвище";
            this.longestSurnameButton.UseVisualStyleBackColor = true;
            this.longestSurnameButton.Click += new System.EventHandler(this.longestSurnameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.longestSurnameButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сургай Андрій П-81 ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button longestSurnameButton;
    }
}


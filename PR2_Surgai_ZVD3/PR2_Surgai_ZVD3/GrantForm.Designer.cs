
namespace PR2_Surgai_ZVD3
{
    partial class GrantForm
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
            this.grantDataGridView = new System.Windows.Forms.DataGridView();
            this.textLabel = new System.Windows.Forms.Label();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grantDataGridView
            // 
            this.grantDataGridView.AllowUserToAddRows = false;
            this.grantDataGridView.AllowUserToDeleteRows = false;
            this.grantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.nameColumn,
            this.marksColumn});
            this.grantDataGridView.Location = new System.Drawing.Point(16, 64);
            this.grantDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grantDataGridView.Name = "grantDataGridView";
            this.grantDataGridView.Size = new System.Drawing.Size(496, 378);
            this.grantDataGridView.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(115, 24);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(299, 16);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Студенти до наказу на отримання стипендії ";
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Прізвище";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.Width = 150;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Ім\'я";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 150;
            // 
            // marksColumn
            // 
            this.marksColumn.HeaderText = "Оцінки за семестр";
            this.marksColumn.Name = "marksColumn";
            this.marksColumn.Width = 150;
            // 
            // GrantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 463);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.grantDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "GrantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сургай П-81";
            this.Load += new System.EventHandler(this.GrantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grantDataGridView;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksColumn;
    }
}
namespace PR_4
{
    partial class Form1
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
            dataGridPartners = new DataGridView();
            panelControls = new Panel();
            labelName = new Label();
            labelSales = new Label();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            textName = new TextBox();
            textPhone = new TextBox();
            textRating = new TextBox();
            textSales = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridPartners).BeginInit();
            SuspendLayout();
            // 
            // dataGridPartners
            // 
            dataGridPartners.BackgroundColor = Color.White;
            dataGridPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPartners.Dock = DockStyle.Fill;
            dataGridPartners.Location = new Point(0, 0);
            dataGridPartners.Name = "dataGridPartners";
            dataGridPartners.Size = new Size(800, 450);
            dataGridPartners.TabIndex = 0;
            dataGridPartners.CellContentClick += dataGridPartners_CellContentClick;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.White;
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(800, 100);
            panelControls.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.White;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(24, 115);
            labelName.Name = "labelName";
            labelName.Size = new Size(226, 21);
            labelName.TabIndex = 2;
            labelName.Text = "Тип | Наименование партнера";
            labelName.Click += labelName_Click;
            // 
            // labelSales
            // 
            labelSales.AutoSize = true;
            labelSales.BackColor = Color.White;
            labelSales.Font = new Font("Segoe UI", 12F);
            labelSales.Location = new Point(435, 115);
            labelSales.Name = "labelSales";
            labelSales.Size = new Size(77, 21);
            labelSales.TabIndex = 5;
            labelSales.Text = "Продажи";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(24, 246);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(103, 31);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.White;
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(146, 246);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 31);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(289, 246);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(103, 31);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.White;
            buttonRefresh.Font = new Font("Segoe UI", 12F);
            buttonRefresh.Location = new Point(409, 246);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(103, 31);
            buttonRefresh.TabIndex = 9;
            buttonRefresh.Text = "Обновить";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // textName
            // 
            textName.Location = new Point(24, 151);
            textName.Name = "textName";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 10;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(24, 180);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(100, 23);
            textPhone.TabIndex = 11;
            // 
            // textRating
            // 
            textRating.Location = new Point(24, 209);
            textRating.Name = "textRating";
            textRating.Size = new Size(100, 23);
            textRating.TabIndex = 12;
            // 
            // textSales
            // 
            textSales.Location = new Point(435, 139);
            textSales.Name = "textSales";
            textSales.Size = new Size(100, 23);
            textSales.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textSales);
            Controls.Add(textRating);
            Controls.Add(textPhone);
            Controls.Add(textName);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(labelSales);
            Controls.Add(labelName);
            Controls.Add(panelControls);
            Controls.Add(dataGridPartners);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridPartners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPartners;
        private Panel panelControls;
        private Label labelName;
        private Label labelSales;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonRefresh;
        private TextBox textName;
        private TextBox textPhone;
        private TextBox textRating;
        private TextBox textSales;
    }
}

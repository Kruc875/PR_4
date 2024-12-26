namespace PR_4
{
    partial class FormType
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
            panelControls = new Panel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            panelFill = new Panel();
            dataGridViewTypes = new DataGridView();
            panelControls.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.White;
            panelControls.Controls.Add(buttonAdd);
            panelControls.Controls.Add(buttonEdit);
            panelControls.Controls.Add(buttonDelete);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(800, 61);
            panelControls.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.White;
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(12, 12);
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
            buttonEdit.Location = new Point(125, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 31);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(265, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(103, 31);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 389);
            panelFill.TabIndex = 2;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.Size = new Size(780, 369);
            dataGridViewTypes.TabIndex = 0;
            dataGridViewTypes.CellContentClick += dataGridViewTypes_CellContentClick;
            // 
            // FormType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(panelControls);
            Name = "FormType";
            panelControls.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelControls;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Panel panelFill;
        private DataGridView dataGridViewTypes;
    }
}

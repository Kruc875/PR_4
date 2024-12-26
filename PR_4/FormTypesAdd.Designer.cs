namespace PR_4
{
    partial class FormTypesAdd
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCanel = new Button();
            buttonSave = new Button();
            labelTypeName = new Label();
            panelFill = new Panel();
            textBoxEmail = new TextBox();
            Email = new Label();
            textBoxTelephone = new TextBox();
            labelTelephone = new Label();
            textBoxDirectorName = new TextBox();
            labelDirectorName = new Label();
            textBoxINN = new TextBox();
            labelINN = new Label();
            textBoxLegalAddress = new TextBox();
            labelLegalAddress = new Label();
            textBoxTypeName = new TextBox();
            labelName = new Label();
            flowLayoutPanel1.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonCanel);
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 381);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(405, 50);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonCanel
            // 
            buttonCanel.DialogResult = DialogResult.Cancel;
            buttonCanel.FlatStyle = FlatStyle.Flat;
            buttonCanel.ImageAlign = ContentAlignment.MiddleRight;
            buttonCanel.Location = new Point(299, 13);
            buttonCanel.Name = "buttonCanel";
            buttonCanel.Size = new Size(83, 23);
            buttonCanel.TabIndex = 0;
            buttonCanel.Text = "Отмена";
            buttonCanel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ImageAlign = ContentAlignment.MiddleRight;
            buttonSave.Location = new Point(210, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(83, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelTypeName
            // 
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(0, 0);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Padding = new Padding(10);
            labelTypeName.Size = new Size(405, 35);
            labelTypeName.TabIndex = 1;
            labelTypeName.Text = "Партнеры";
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxEmail);
            panelFill.Controls.Add(Email);
            panelFill.Controls.Add(textBoxTelephone);
            panelFill.Controls.Add(labelTelephone);
            panelFill.Controls.Add(textBoxDirectorName);
            panelFill.Controls.Add(labelDirectorName);
            panelFill.Controls.Add(textBoxINN);
            panelFill.Controls.Add(labelINN);
            panelFill.Controls.Add(textBoxLegalAddress);
            panelFill.Controls.Add(labelLegalAddress);
            panelFill.Controls.Add(textBoxTypeName);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(labelTypeName);
            panelFill.Controls.Add(flowLayoutPanel1);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(10, 10);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(405, 431);
            panelFill.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(0, 259);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(405, 23);
            textBoxEmail.TabIndex = 17;
            textBoxEmail.TextChanged += textBoxRating_TextChanged;
            // 
            // Email
            // 
            Email.Location = new Point(0, 236);
            Email.Name = "Email";
            Email.Size = new Size(405, 20);
            Email.TabIndex = 16;
            Email.Text = "Email";
            Email.Click += labelRating_Click;
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Dock = DockStyle.Fill;
            textBoxTelephone.Location = new Point(0, 210);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(405, 23);
            textBoxTelephone.TabIndex = 15;
            // 
            // labelTelephone
            // 
            labelTelephone.Dock = DockStyle.Top;
            labelTelephone.Location = new Point(0, 195);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(405, 15);
            labelTelephone.TabIndex = 14;
            labelTelephone.Text = "Телефон";
            // 
            // textBoxDirectorName
            // 
            textBoxDirectorName.Dock = DockStyle.Top;
            textBoxDirectorName.Location = new Point(0, 172);
            textBoxDirectorName.Name = "textBoxDirectorName";
            textBoxDirectorName.Size = new Size(405, 23);
            textBoxDirectorName.TabIndex = 13;
            // 
            // labelDirectorName
            // 
            labelDirectorName.Dock = DockStyle.Top;
            labelDirectorName.Location = new Point(0, 149);
            labelDirectorName.Name = "labelDirectorName";
            labelDirectorName.Size = new Size(405, 23);
            labelDirectorName.TabIndex = 12;
            labelDirectorName.Text = "ФИО Директора";
            // 
            // textBoxINN
            // 
            textBoxINN.Dock = DockStyle.Top;
            textBoxINN.Location = new Point(0, 126);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(405, 23);
            textBoxINN.TabIndex = 11;
            // 
            // labelINN
            // 
            labelINN.Dock = DockStyle.Top;
            labelINN.Location = new Point(0, 111);
            labelINN.Name = "labelINN";
            labelINN.Size = new Size(405, 15);
            labelINN.TabIndex = 10;
            labelINN.Text = "ИНН";
            // 
            // textBoxLegalAddress
            // 
            textBoxLegalAddress.Dock = DockStyle.Top;
            textBoxLegalAddress.Location = new Point(0, 88);
            textBoxLegalAddress.Name = "textBoxLegalAddress";
            textBoxLegalAddress.Size = new Size(405, 23);
            textBoxLegalAddress.TabIndex = 9;
            // 
            // labelLegalAddress
            // 
            labelLegalAddress.Dock = DockStyle.Top;
            labelLegalAddress.Location = new Point(0, 73);
            labelLegalAddress.Name = "labelLegalAddress";
            labelLegalAddress.Size = new Size(405, 15);
            labelLegalAddress.TabIndex = 8;
            labelLegalAddress.Text = "Адрес";
            labelLegalAddress.Click += label1_Click;
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Dock = DockStyle.Top;
            textBoxTypeName.Location = new Point(0, 50);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(405, 23);
            textBoxTypeName.TabIndex = 7;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(0, 35);
            labelName.Name = "labelName";
            labelName.Size = new Size(405, 15);
            labelName.TabIndex = 6;
            labelName.Text = "Тип | Наименование партнера";
            // 
            // FormTypesAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(425, 451);
            Controls.Add(panelFill);
            Name = "FormTypesAdd";
            Padding = new Padding(10);
            Text = "-";
            flowLayoutPanel1.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCanel;
        private Button buttonSave;
        private Label labelTypeName;
        private Panel panelFill;
        private Label labelName;
        private Label labelINN;
        private Label labelLegalAddress;
        private Label labelDirectorName;
        private Label labelTelephone;
        protected internal TextBox textBoxLegalAddress;
        protected internal TextBox textBoxTypeName;
        protected internal TextBox textBoxDirectorName;
        protected internal TextBox textBoxINN;
        protected internal TextBox textBoxTelephone;
        private Label Email;
        protected internal TextBox textBoxEmail;
    }
}
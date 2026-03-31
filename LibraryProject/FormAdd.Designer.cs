namespace LibraryProject
{
    partial class FormAdd
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
            btnSave = new Button();
            btnCancel = new Button();
            txtISBN = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numPageCount = new NumericUpDown();
            numTotalAmount = new NumericUpDown();
            numAvailableAmount = new NumericUpDown();
            numPublishYear = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbAuthors = new ComboBox();
            cmbGenres = new ComboBox();
            cmbPublishers = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtAnnotation = new TextBox();
            label11 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPageCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAvailableAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPublishYear).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 585);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(717, 45);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(74, 111, 165);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(603, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 32);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(74, 111, 165);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(486, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 32);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(51, 56);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(269, 26);
            txtISBN.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(51, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 26);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 4;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 94);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 5;
            label2.Text = "Название книги";
            // 
            // numPageCount
            // 
            numPageCount.Location = new Point(51, 330);
            numPageCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPageCount.Name = "numPageCount";
            numPageCount.Size = new Size(120, 26);
            numPageCount.TabIndex = 7;
            // 
            // numTotalAmount
            // 
            numTotalAmount.Location = new Point(51, 399);
            numTotalAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTotalAmount.Name = "numTotalAmount";
            numTotalAmount.Size = new Size(120, 26);
            numTotalAmount.TabIndex = 8;
            // 
            // numAvailableAmount
            // 
            numAvailableAmount.Location = new Point(51, 468);
            numAvailableAmount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numAvailableAmount.Name = "numAvailableAmount";
            numAvailableAmount.Size = new Size(120, 26);
            numAvailableAmount.TabIndex = 9;
            // 
            // numPublishYear
            // 
            numPublishYear.Location = new Point(51, 537);
            numPublishYear.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPublishYear.Name = "numPublishYear";
            numPublishYear.Size = new Size(120, 26);
            numPublishYear.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 299);
            label4.Name = "label4";
            label4.Size = new Size(117, 19);
            label4.TabIndex = 11;
            label4.Text = "Кол-во страниц";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 368);
            label5.Name = "label5";
            label5.Size = new Size(136, 19);
            label5.TabIndex = 12;
            label5.Text = "Всего экземпляров";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 437);
            label6.Name = "label6";
            label6.Size = new Size(164, 19);
            label6.TabIndex = 13;
            label6.Text = "Доступно экземпляров";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 506);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 14;
            label7.Text = "Год выпуска";
            // 
            // cmbAuthors
            // 
            cmbAuthors.FormattingEnabled = true;
            cmbAuthors.Location = new Point(426, 56);
            cmbAuthors.Name = "cmbAuthors";
            cmbAuthors.Size = new Size(233, 27);
            cmbAuthors.TabIndex = 15;
            // 
            // cmbGenres
            // 
            cmbGenres.FormattingEnabled = true;
            cmbGenres.Location = new Point(426, 124);
            cmbGenres.Name = "cmbGenres";
            cmbGenres.Size = new Size(233, 27);
            cmbGenres.TabIndex = 16;
            // 
            // cmbPublishers
            // 
            cmbPublishers.FormattingEnabled = true;
            cmbPublishers.Location = new Point(426, 192);
            cmbPublishers.Name = "cmbPublishers";
            cmbPublishers.Size = new Size(233, 27);
            cmbPublishers.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 26);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 18;
            label8.Text = "Автор";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(426, 94);
            label9.Name = "label9";
            label9.Size = new Size(47, 19);
            label9.TabIndex = 19;
            label9.Text = "Жанр";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(426, 162);
            label10.Name = "label10";
            label10.Size = new Size(70, 19);
            label10.TabIndex = 20;
            label10.Text = "Издатель";
            // 
            // txtAnnotation
            // 
            txtAnnotation.Location = new Point(51, 194);
            txtAnnotation.Multiline = true;
            txtAnnotation.Name = "txtAnnotation";
            txtAnnotation.Size = new Size(269, 93);
            txtAnnotation.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 163);
            label11.Name = "label11";
            label11.Size = new Size(85, 19);
            label11.TabIndex = 22;
            label11.Text = "Аннотация";
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(717, 630);
            Controls.Add(label11);
            Controls.Add(txtAnnotation);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cmbPublishers);
            Controls.Add(cmbGenres);
            Controls.Add(cmbAuthors);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numPublishYear);
            Controls.Add(numAvailableAmount);
            Controls.Add(numTotalAmount);
            Controls.Add(numPageCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtISBN);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление/редактирование книги";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numPageCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAvailableAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPublishYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtISBN;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private NumericUpDown numPageCount;
        private NumericUpDown numTotalAmount;
        private NumericUpDown numAvailableAmount;
        private NumericUpDown numPublishYear;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbAuthors;
        private ComboBox cmbGenres;
        private ComboBox cmbPublishers;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtAnnotation;
        private Label label11;
    }
}
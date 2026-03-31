namespace LibraryProject
{
    partial class FormBooks
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
            panel1 = new Panel();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoans = new Button();
            label1 = new Label();
            cmbSort = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnLogout = new Button();
            lblUsername = new Label();
            dgvBooks = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(flowLayoutPanelButtons);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 89);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Controls.Add(btnAdd);
            flowLayoutPanelButtons.Controls.Add(btnEdit);
            flowLayoutPanelButtons.Controls.Add(btnDelete);
            flowLayoutPanelButtons.Controls.Add(btnLoans);
            flowLayoutPanelButtons.Controls.Add(label1);
            flowLayoutPanelButtons.Controls.Add(cmbSort);
            flowLayoutPanelButtons.Dock = DockStyle.Left;
            flowLayoutPanelButtons.Location = new Point(0, 0);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Padding = new Padding(10);
            flowLayoutPanelButtons.Size = new Size(609, 89);
            flowLayoutPanelButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(74, 111, 165);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(13, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 32);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(74, 111, 165);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(130, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 32);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(74, 111, 165);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(290, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnLoans
            // 
            btnLoans.BackColor = Color.FromArgb(74, 111, 165);
            btnLoans.FlatAppearance.BorderSize = 0;
            btnLoans.FlatStyle = FlatStyle.Flat;
            btnLoans.Location = new Point(407, 13);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(111, 32);
            btnLoans.TabIndex = 4;
            btnLoans.Text = "Выдачи";
            btnLoans.UseVisualStyleBackColor = false;
            btnLoans.Click += BtnLoans_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 48);
            label1.Name = "label1";
            label1.Size = new Size(387, 21);
            label1.TabIndex = 6;
            label1.Text = "Сортировка по кол-ву доступных экземпляров";
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "по убыванию", "по возрастанию" });
            cmbSort.Location = new Point(406, 51);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(165, 29);
            cmbSort.TabIndex = 5;
            cmbSort.SelectedIndexChanged += CmbSort_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnLogout);
            flowLayoutPanel1.Controls.Add(lblUsername);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(615, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(484, 89);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(74, 111, 165);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(350, 13);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(111, 32);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Выход";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(291, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(53, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "label1";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.ColumnHeadersVisible = false;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(0, 89);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1099, 524);
            dgvBooks.TabIndex = 1;
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1099, 613);
            Controls.Add(dgvBooks);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список книг";
            panel1.ResumeLayout(false);
            flowLayoutPanelButtons.ResumeLayout(false);
            flowLayoutPanelButtons.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelButtons;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLogout;
        private Label lblUsername;
        private DataGridView dgvBooks;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoans;
        private ComboBox cmbSort;
        private Label label1;
    }
}
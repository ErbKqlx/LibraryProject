using LibraryProject.Models;
using LibraryProject.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class FormBooks : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormBooks(User currentUser, bool isGuest)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            IsGuest = isGuest;

            lblUsername.Text = IsGuest ? "Гость" : $"{CurrentUser.Surname} {CurrentUser.Name} {CurrentUser.Patronymic}";

            foreach (Button button in flowLayoutPanelButtons.Controls)
            {
                button.Visible = !isGuest;
            }

            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "colId";
            colId.Visible = false;
            colId.ReadOnly = true;

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 20;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvBooks.Columns.AddRange([
                colId, colPhoto, colInfo
            ]);

            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var books = db.Books
                        .Include(i => i.IdAuthorNavigation)
                        .Include(i => i.IdGenreNavigation)
                        .Include(i => i.IdPublisherNavigation)
                        .ToList();

                    dgvBooks.SuspendLayout();
                    dgvBooks.Rows.Clear();

                    foreach (var book in books)
                    {
                        int rowIndex = dgvBooks.Rows.Add();
                        var row = dgvBooks.Rows[rowIndex];

                        row.Cells["colId"].Value = book.Id;
                        row.Cells["colPhoto"].Value = Resources.book_placeholder;
                        row.Cells["colInfo"].Value = FormatBookInfo(book);

                        ApplyRowStyles(row, book);
                    }

                    dgvBooks.ResumeLayout();
                    dgvBooks.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatBookInfo(Book book)
        {
            //throw new NotImplementedException();

            return $"ISBN: {book.Isbn}" + Environment.NewLine +
                $"Название книги: {book.BookName}" + Environment.NewLine +
                $"Автор: {book.IdAuthorNavigation.AuthorName}" + Environment.NewLine +
                $"Жанр: {book.IdGenreNavigation.GenreName}" + Environment.NewLine +
                $"Издательство: {book.IdPublisherNavigation.PublisherName}" + Environment.NewLine +
                $"Кол-во страниц: {book.PageCount}" + Environment.NewLine +
                $"Всего экземпляров: {book.TotalAmount}" + Environment.NewLine +
                $"Доступно экземпляров: {book.AvailableAmount}" + Environment.NewLine +
                $"Аннотация: {book.Annotation}" + Environment.NewLine +
                $"Год издания: {book.PublishYear}" + Environment.NewLine;
        }

        private void ApplyRowStyles(DataGridViewRow row, Book book)
        {
            if (book.AvailableAmount <= 0)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFCCCC");
            }

            if (book.AvailableAmount >= 1 && book.AvailableAmount <= 2)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF3CD");
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new FormAdd();
            formAdd.ShowDialog();

            if (formAdd.DialogResult == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var formAdd = new FormAdd((long)dgvBooks.CurrentRow.Cells[0].Value);
            formAdd.ShowDialog();

            if (formAdd.DialogResult == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить книгу?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new LibraryContext())
                    {
                        //MessageBox.Show(dgvBooks.CurrentRow.Cells[0].Value.GetType().ToString());

                        var book = db.Books.Where(i => i.Id == (long)dgvBooks.CurrentRow.Cells[0].Value).FirstOrDefault();

                        db.Books.Remove(book);
                        db.SaveChanges();

                        LoadBooks();
                    }

                    MessageBox.Show("Книга удалена",
                        "Удаление",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

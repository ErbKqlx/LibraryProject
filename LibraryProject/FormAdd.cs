using LibraryProject.Models;
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
    public partial class FormAdd : Form
    {
        private long _selectedId;
        public FormAdd(long id = -1)
        {
            InitializeComponent();
            _selectedId = id;

            LoadBookInfo();
        }

        private void LoadBookInfo()
        {
            using (var db = new LibraryContext())
            {
                db.Authors.Load();
                db.Genres.Load();
                db.Publishers.Load();

                cmbAuthors.DataSource = db.Authors.Local.ToBindingList();
                cmbAuthors.DisplayMember = "AuthorName";
                cmbAuthors.ValueMember = "Id";

                cmbGenres.DataSource = db.Genres.Local.ToBindingList();
                cmbGenres.DisplayMember = "GenreName";
                cmbGenres.ValueMember = "Id";

                cmbPublishers.DataSource = db.Publishers.Local.ToBindingList();
                cmbPublishers.DisplayMember = "PublisherName";
                cmbPublishers.ValueMember = "Id";

                Book book;
                if (_selectedId != -1)
                {
                    book = db.Books.Find(_selectedId);
                }
                else
                {
                    book = new Book();
                }

                txtISBN.Text = book.Isbn;
                txtName.Text = book.BookName;
                txtAnnotation.Text = book.Annotation;
                numPageCount.Value = book.PageCount;
                numTotalAmount.Value = book.TotalAmount;
                numAvailableAmount.Value = book.AvailableAmount;
                numPublishYear.Value = book.PublishYear;
                cmbAuthors.SelectedValue = book.IdAuthor;
                cmbGenres.SelectedValue = book.IdGenre;
                cmbPublishers.SelectedValue = book.IdPublisher;


            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    Book book;
                    if (_selectedId != -1)
                    {
                        book = db.Books.Find(_selectedId);
                    }
                    else
                    {
                        book = new Book();
                    }

                    book.Isbn = txtISBN.Text;
                    book.BookName = txtName.Text;
                    book.Annotation = txtAnnotation.Text;
                    book.PageCount = (short)numPageCount.Value;
                    book.TotalAmount = (short)numTotalAmount.Value;
                    book.AvailableAmount = (short)numAvailableAmount.Value;
                    book.PublishYear = (short)numPublishYear.Value;
                    book.IdAuthor = (int)cmbAuthors.SelectedValue;
                    book.IdGenre = (short)cmbGenres.SelectedValue;
                    book.IdPublisher = (int)cmbPublishers.SelectedValue;

                    if (_selectedId != -1)
                    {
                        db.Books.Update(book);
                    }
                    else
                    {
                        db.Books.Add(book);
                    }


                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"{ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

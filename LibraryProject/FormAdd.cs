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
        public FormAdd(long id = -1)
        {
            InitializeComponent();

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
                if (id != -1)
                {
                    book = db.Books.Find(id);
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
    }
}

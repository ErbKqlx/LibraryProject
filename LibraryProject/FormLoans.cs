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
    public partial class FormLoans : Form
    {
        public User CurrentUser { get; private set; }
        public FormLoans(User currentUser)
        {
            InitializeComponent();

            CurrentUser = currentUser;

            lblUsername.Text = $"{CurrentUser.Surname} {CurrentUser.Name} {CurrentUser.Patronymic}";

            var colId = new DataGridViewTextBoxColumn();
            colId.Name = "colId";
            colId.Visible = false;
            colId.ReadOnly = true;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvLoans.Columns.AddRange([
                colId, colInfo
            ]);

            LoadLoans();

        }

        private void LoadLoans()
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var loans = db.BookLoans
                        .Include(i => i.IdUserNavigation)
                        .Include(i => i.IdBookNavigation)
                        .Include(i => i.IdStatusNavigation)
                        .ToList();


                    dgvLoans.SuspendLayout();
                    dgvLoans.Rows.Clear();

                    foreach (var loan in loans)
                    {
                        int rowIndex = dgvLoans.Rows.Add();
                        var row = dgvLoans.Rows[rowIndex];

                        row.Cells["colId"].Value = loan.Id;
                        row.Cells["colInfo"].Value = FormatLoanInfo(loan);
                    }

                    dgvLoans.ResumeLayout();
                    dgvLoans.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatLoanInfo(BookLoan loan)
        {
            //throw new NotImplementedException();

            return $"Читатель: {loan.IdUserNavigation.Surname} {loan.IdUserNavigation.Name} {loan.IdUserNavigation.Patronymic}" + Environment.NewLine +
                $"Книга: {loan.IdBookNavigation.BookName}" + Environment.NewLine +
                $"Дата выдачи: {loan.GiveDate}" + Environment.NewLine +
                $"Планируемая дата возврата: {loan.ReturnDatePlanned}" + Environment.NewLine +
                $"Фактическая дата возврата: {loan.ReturnDateReal}" + Environment.NewLine +
                $"Статус: {loan.IdStatusNavigation.StatusName}";
        }
    }
}

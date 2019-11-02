using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Services;
using Library.Models;

namespace Library.Forms
{
    public partial class BookCrud : Form
    {
        private readonly BookService _bookService;
        private Book _selectedBook;
        public BookCrud()
        {
            _bookService = new BookService();
            _selectedBook = new Book();
            InitializeComponent();
            FillBooks();
        }
        private void Reset()
        {
            TxtTitle.Text = string.Empty;
            TxtPrice.Text = string.Empty;
            TxtAuthor.Text = string.Empty;
            NmrcCount.Text = string.Empty;
            BtnAdd.Show();
            BtnDelete.Hide();
            BtnUpdate.Hide();
            BtnCancel.Hide();
        }
        private void FillBooks()
        {
            foreach (Book item in _bookService.All())
            {
                DgvBooks.Rows.Add(item.Id, item.Title, item.Price, item.Author, item.Count);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtTitle.Text == string.Empty || TxtPrice.Text == string.Empty || TxtAuthor.Text == string.Empty || NmrcCount.Text == string.Empty)
            {
                MessageBox.Show("Books information can't be null");
                return;
            }
            Book book = new Book()
            {
                Title = TxtTitle.Text,
                Price = Convert.ToDecimal(TxtPrice.Text),
                Author = TxtAuthor.Text,
                Count = Convert.ToInt32(NmrcCount.Text)
            };
            _bookService.Add(book);
            DgvBooks.Rows.Clear();
            FillBooks();
            Reset();
        }
        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        BtnAdd.Hide();
            BtnUpdate.Show();
            BtnDelete.Show();
            BtnCancel.Show();
            int Id = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value);
            _selectedBook = _bookService.Find(Id);
            TxtTitle.Text = _selectedBook.Title;
            TxtPrice.Text = _selectedBook.Price.ToString();
            TxtAuthor.Text = _selectedBook.Author;
            NmrcCount.Text = _selectedBook.Count.ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Delete book", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _bookService.Delete(_selectedBook);
                DgvBooks.Rows.Clear();
                FillBooks();
                Reset();
            }
            MessageBox.Show("book is deleted");
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtTitle.Text == string.Empty || TxtPrice.Text == string.Empty || TxtAuthor.Text == string.Empty || NmrcCount.Text == string.Empty)
            {
                MessageBox.Show("Books information can't be null");
                return;
            }
            _selectedBook.Title = TxtTitle.Text;
            _selectedBook.Price = Convert.ToDecimal(TxtPrice.Text);
            _selectedBook.Author = TxtAuthor.Text;
            _selectedBook.Count = Convert.ToInt32(NmrcCount.Text);
            _bookService.Update(_selectedBook);
            DgvBooks.Rows.Clear();
            FillBooks();
            Reset();
            MessageBox.Show("book is updated");
        }


    }
}

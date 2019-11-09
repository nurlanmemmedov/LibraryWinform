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
        private int _SelectedIndex;
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
            BtnDeactive.Hide();
            BtnUpdate.Hide();
            BtnCancel.Hide();
        }
        private void ResetSearch()
        {
            TxtNameSearch.Text = string.Empty;
            TxtAuthorSearch.Text = string.Empty;
            BtnCancelSearch.Hide();
        }
        private void FillBooks()
        {
            foreach (Book item in _bookService.All())
            {
                if (item.isActive)
                {
                    DgvBooks.Rows.Add(item.Id, item.Title, item.Price, item.Author, item.Count);
                }
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
            DgvBooks.Rows.Add(book.Id, book.Title, book.Price, book.Author, book.Count);
            ResetSearch();
            Reset();
        }
        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Hide();
            BtnUpdate.Show();
            BtnDeactive.Show();
            BtnCancel.Show();
            int Id = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value);
            _SelectedIndex = e.RowIndex;
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


        private void BtnDeactive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to deactive", "Deactive book", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _selectedBook.isActive = false;
                _bookService.Update(_selectedBook);
                DgvBooks.Rows.RemoveAt(_SelectedIndex);
                ResetSearch();
                Reset();
            }
            MessageBox.Show("book is deactived");
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
            DgvBooks.Rows[_SelectedIndex].Cells[0].Value = _selectedBook.Id;
            DgvBooks.Rows[_SelectedIndex].Cells[1].Value = TxtTitle.Text;
            DgvBooks.Rows[_SelectedIndex].Cells[2].Value = TxtPrice.Text;
            DgvBooks.Rows[_SelectedIndex].Cells[3].Value = TxtAuthor.Text;
            DgvBooks.Rows[_SelectedIndex].Cells[4].Value = NmrcCount.Text;
            ResetSearch();
            Reset();
            MessageBox.Show("book is updated");
        }

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)
        {
            if ((TxtAuthorSearch.Text == string.Empty && TxtNameSearch.Text == string.Empty))
            {
                DgvBooks.Rows.Clear();
                FillBooks();
                ResetSearch();
                return;
            }
            DgvBooks.Rows.Clear();
            foreach (Book item in _bookService.All())
            {
                if ((item.Title.ToLower().Contains(TxtNameSearch.Text.ToLower())
                    || TxtNameSearch.Text == string.Empty) && (item.Author.ToLower().Contains(TxtAuthorSearch.Text.ToLower())
                    || TxtAuthorSearch.Text == string.Empty)&& item.isActive == true)
                {
                    DgvBooks.Rows.Add(item.Id, item.Title, item.Price, item.Author, item.Count);
                }
            }
            BtnCancelSearch.Show();
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            DgvBooks.Rows.Clear();
            FillBooks();
            ResetSearch();
        }

    }
}

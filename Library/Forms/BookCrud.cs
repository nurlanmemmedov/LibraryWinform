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
using System.Text.RegularExpressions;

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
        private void Reset()//reset the all changes on textboxes and numericupdown
        {
            TxtTitle.Text = string.Empty;
            NumPrice.Value = 0;
            TxtAuthor.Text = string.Empty;
            NmrcCount.Value = 0;
            BtnAdd.Show();
            BtnDeactive.Hide();
            BtnUpdate.Hide();
            BtnCancel.Hide();
        }

        private void ResetSearch()//reset the searching 
        {
            TxtNameSearch.Text = string.Empty;
            TxtAuthorSearch.Text = string.Empty;
            BtnCancelSearch.Hide();
        }

        private void FillBooks()//fill all books which are active
        {
            foreach (Book item in _bookService.All())
            {
                if (item.isActive)//check if book is active
                {
                    DgvBooks.Rows.Add(item.Id, item.Title, item.Price, item.Author, item.Count);
                }
            }
        }

        public bool isDigit(string str)//checks if the string contains digits
        {
            foreach (Char item in str)
            {
                
                if ((item < '0' || item > '9'))
                {
                    return false;
                }
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)//add the new book
        {
            //check if the book information is null
            if (TxtTitle.Text == string.Empty ||  TxtAuthor.Text == string.Empty || NmrcCount.Value == 0 )
            {
                MessageBox.Show("Books information can't be null");
                return;
            }
            //check if the book title contains letter
            if (!Regex.IsMatch(TxtTitle.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the title can only contain letters");
                return;
            }
            //check if the author contains letter
            if (!Regex.IsMatch(TxtAuthor.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the author name can not contain digit");
                return;
            }
            //check if the given book is already exist
            foreach (Book item in _bookService.All())
            {
                if (item.isActive == true)
                {
                    if (item.Title == TxtTitle.Text &&
                        item.Author == TxtAuthor.Text &&
                        item.Price == NumPrice.Value &&
                        item.Count == NmrcCount.Value)
                    {
                        MessageBox.Show("such book is already exists");
                        return;
                    }
                }
            }
            Book book = new Book()//book to adding
            {
                Title = TxtTitle.Text,
                Price = NumPrice.Value,
                Author = TxtAuthor.Text,
                Count = Convert.ToInt32(NmrcCount.Text),
                isActive = true
            };
            _bookService.Add(book);
            DgvBooks.Rows.Add(book.Id, book.Title, book.Price, book.Author, book.Count);
            ResetSearch();
            Reset();
        }

        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//select the book to updating or deactiving
        {
            BtnAdd.Hide();
            BtnUpdate.Show();
            BtnDeactive.Show();
            BtnCancel.Show();
            int Id = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value);
            _selectedBook = _bookService.Find(Id);
            //index of selected book on datagridview
            _SelectedIndex = e.RowIndex;
            //fill the selected book information to the textboxes
            TxtTitle.Text = _selectedBook.Title;
            NumPrice.Value = _selectedBook.Price;
            TxtAuthor.Text = _selectedBook.Author;
            NmrcCount.Value = _selectedBook.Count;
        }

        private void BtnCancel_Click(object sender, EventArgs e)//call the reset function to canceling selected book
        {
            Reset();
        }

        private void BtnDeactive_Click(object sender, EventArgs e)//deactive the selected book
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

        private void BtnUpdate_Click(object sender, EventArgs e)//update the selected book
        {
            //check if the book information is null
            if (TxtTitle.Text == string.Empty ||  TxtAuthor.Text == string.Empty)
            {
                MessageBox.Show("Books information can't be null");
                return;
            }
            //check if the book title contains letter
            if (!Regex.IsMatch(TxtTitle.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the title can not contain digit");
                return;
            }
            //check if the author contains letter
            if (!Regex.IsMatch(TxtAuthor.Text, @"^[a-zA-Z\s]*$"))
            {
                MessageBox.Show("the author name can not contain digit");
                return;
            }
            //check if the given book is already exist
            foreach (Book item in _bookService.All())
            {
                if (item.isActive == true)
                {
                    if (item.Title == TxtTitle.Text &&
                        item.Author == TxtAuthor.Text &&
                        item.Price == NumPrice.Value &&
                        item.Count == NmrcCount.Value)
                    {
                        MessageBox.Show("such book is already exists");
                        return;
                    }
                }
            }
            //update the selected book information
            _selectedBook.Title = TxtTitle.Text;
            _selectedBook.Price = NumPrice.Value;
            _selectedBook.Author = TxtAuthor.Text;
            _selectedBook.Count = Convert.ToInt32(NmrcCount.Value); ;
            _bookService.Update(_selectedBook);
            //apply changes to selected book on datagridview
            DgvBooks.Rows[_SelectedIndex].Cells[0].Value = _selectedBook.Id;
            DgvBooks.Rows[_SelectedIndex].Cells[1].Value = TxtTitle.Text;
            DgvBooks.Rows[_SelectedIndex].Cells[2].Value = NumPrice.Value;
            DgvBooks.Rows[_SelectedIndex].Cells[3].Value = TxtAuthor.Text;
            DgvBooks.Rows[_SelectedIndex].Cells[4].Value = NmrcCount.Value;
            ResetSearch();
            Reset();
            MessageBox.Show("book is updated");
        }

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)//shows the result of the searching when the text changes
        {
            //check if the searching textboxes is empty
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

        private void BtnCancelSearch_Click(object sender, EventArgs e)//call the resetsearch and cancel the searching results
        {
            DgvBooks.Rows.Clear();
            FillBooks();
            ResetSearch();
        }

        private void PbBack_Click(object sender, EventArgs e)//hide the current form and return to previous
        {
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PE_PRN211_LeHaDuy_RePo.Models;
using PE_PRN211_LeHaDuy_RePo.Repositories;

namespace PE_PRN211_LeHaDuy
{
    public partial class frmBookManagement : Form
    {
        private IBookRepository _bookRepository;
        BindingSource source;

        public frmBookManagement()
        {
            this._bookRepository = new BookRepository();
            InitializeComponent();
        }

        private void frmBookManagement_Load(object sender, EventArgs e)
        {
            txtBookID.Enabled = false;
            txtBookName.Enabled = false;
            txtQuantity.Enabled = false;
            txtAuthorName.Enabled = false;
            txtPublisherID.Enabled = false;
        }
        private void ClearText()
        {
            txtBookID.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtQuantity.Text = null;
            txtAuthorName.Text = string.Empty;
            txtPublisherID.Text = string.Empty;
        }
        private void LoadBookList()
        {
            var books = _bookRepository.GetBooks();
            try
            {
                // The BindingSource component is designed simplify
                // the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = books.ToList();

                txtBookID.DataBindings.Clear();
                txtBookName.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtAuthorName.DataBindings.Clear();
                txtPublisherID.DataBindings.Clear();

                txtBookID.DataBindings.Add("Text", source, "BookID");
                txtBookName.DataBindings.Add("Text", source, "BookName");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtAuthorName.DataBindings.Add("Text", source, "AuthorName");
                txtPublisherID.DataBindings.Add("Text", source, "PublisherID");

                dgvBookGrid.DataSource = null;
                dgvBookGrid.DataSource = source;
                if (books.ToList().Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load book list");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadBookList();
        }
        private Book GetBookObject()
        {
            Book book = new Book();
            try
            {
                book = new Book()
                {
                    BookId = txtBookID.Text,
                    BookName = txtBookName.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    AuthorName = txtAuthorName.Text,
                    PublisherId = txtPublisherID.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get book");
            }
            return book;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this book", "Delete book", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var book = GetBookObject();
                    _bookRepository.DeleteBook(book.BookId);
                    LoadBookList();
                    MessageBox.Show(@"Delete successfully!!", @"Delete Product", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a book");
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmBookDetail frmBookDetail = new frmBookDetail()
            {
                Text = "Add book",
                InsertOrUpdate = false,
                BookRepository = _bookRepository
            };
            if(frmBookDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBookList();
                source.Position = source.Count - 1;
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmBookDetail frmBookDetail = new frmBookDetail()
            {
                Text = "Add book",
                InsertOrUpdate = true,
                BookInfo = GetBookObject(),
                BookRepository = _bookRepository
            };
            if (frmBookDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBookList();
                source.Position = source.Count - 1;
            }
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();


    }
}

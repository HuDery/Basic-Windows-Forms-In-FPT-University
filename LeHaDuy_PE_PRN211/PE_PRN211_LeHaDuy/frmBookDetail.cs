using PE_PRN211_LeHaDuy_RePo.Repositories;
using PE_PRN211_LeHaDuy_RePo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PE_PRN211_LeHaDuy
{
    public partial class frmBookDetail : Form
    {
        public frmBookDetail()
        {
            InitializeComponent();
            ShowCboPublisherID();
        }

        public IBookRepository BookRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Book BookInfo { get; set; }

        private void frmBookDetail_Load(object sender, EventArgs e)
        {
            cboPublisherID.SelectedIndex = 0;
            txtBookID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtBookID.Text = BookInfo.BookId.ToString();
                txtBookName.Text = BookInfo.BookName.ToString();
                txtQuantity.Text = BookInfo.Quantity.ToString();
                txtAuthorName.Text = BookInfo.AuthorName.ToString();
                cboPublisherID.Text = BookInfo.PublisherId.ToString();
            }
        }
        private void ClearText()
        {
            txtBookID.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtQuantity.Text = null;
            txtAuthorName.Text = string.Empty;
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:PeDB"];
            return strConn;
        }
        public void ShowCboPublisherID()
        {
            var cs = GetConnectionString();
            BookPubLisherContext db = new BookPubLisherContext(cs);
            var publisher = (from x in db.Publishers select x).ToList();
            BindingSource publisherSoucre = new BindingSource();
            publisherSoucre.DataSource = publisher;
            cboPublisherID.DataSource = null;
            cboPublisherID.DataSource = publisherSoucre;
            cboPublisherID.ValueMember = "PublisherID";
            this.cboPublisherID.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var book = new Book()
                {
                    BookId = txtBookID.Text.Trim(),
                    BookName = txtBookName.Text.Trim(),
                    Quantity = int.Parse(txtQuantity.Text),
                    AuthorName = txtAuthorName.Text.Trim(),
                    PublisherId = cboPublisherID.Text.Trim(),
                };
                if (book.BookId.Length < 6 || book.BookId.Length > 12)
                {
                    throw new Exception("BookID just from 6 to 12 charaters!");
                }
                if (book.BookId == String.Empty)
                {
                    throw new Exception("BookID can't empty!");
                }
                if (book.AuthorName.Length <= 10)
                {
                    throw new Exception("AuthorName just greater than 10 characters!");
                }
                if (book.BookName == String.Empty)
                {
                    throw new Exception("BookName can't empty!");
                }
                if (book.Quantity <= 0)
                {
                    throw new Exception("Quantity can't less than 0!");
                }
                if (book.AuthorName == String.Empty)
                {
                    throw new Exception("AuthorName can't empty!");
                }
                if (InsertOrUpdate == false)
                {
                    BookRepository.InsertBook(book);
                    MessageBox.Show(@"Add successfully!!", @"Add a new book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    BookRepository.UpdateBook(book);
                    MessageBox.Show(@"Update successfully!!", @"Update Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new book" : "Update a book");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}

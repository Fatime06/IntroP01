using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		private void RefreshGrid()
		{
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = bookList;
			dataGridView1.Refresh();
		}

		private void ClearTextBoxes()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}

		List<Book> bookList = new List<Book>();
		private Book selectedBook = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Book book = new Book()
			{
				Name = "Cinayet ve Ceza",
				Author = "Fyodor Dostoyevski",
				Genre = "Classic"
			};
			bookList.Add(book);

			Book book2 = new Book()
			{
				Name = "1984",
				Author = "George Orwell",
				Genre = "Elmi-Fantastik"
			};
			bookList.Add(book2);

			Book book3 = new Book()
			{
				Name = "Qurur ve Qerez",
				Author = "Jane Austen",
				Genre = "Classic"
			};
			bookList.Add(book3);

			RefreshGrid();

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = bookList;
			dataGridView1.Refresh();
		}

		private void btnAddBook_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			string author = textBox2.Text;
			string genre = textBox3.Text;

			Book book = new Book()
			{
				Name = name,
				Author = author,
				Genre = genre
			};
			bookList.Add(book);

			MessageBox.Show("the book has been added!");
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";

			dataGridView1.DataSource = null;
			dataGridView1.DataSource = bookList;
		}

		private void btnDeleteBook_Click(object sender, EventArgs e)
		{
			if (selectedBook != null)
			{
				bookList.Remove(selectedBook);
				MessageBox.Show("The book has been deleted!");
				ClearTextBoxes();
				RefreshGrid();
				selectedBook = null;
			}
			else
			{
				MessageBox.Show("No book selected!");
			}
		}

		private void btnUpdateBook_Click(object sender, EventArgs e)
		{

			if (selectedBook != null)
			{
				selectedBook.Name = textBox1.Text;
				selectedBook.Author = textBox2.Text;
				selectedBook.Genre = textBox3.Text;

				MessageBox.Show("The book has been updated!");
				ClearTextBoxes();
				RefreshGrid();
				selectedBook = null; // Seçimi sıfırla
			}
			else
			{
				MessageBox.Show("No book selected!");
			}
		}

		private void btnDeleteBook_Click_1(object sender, EventArgs e)
		{
			if (selectedBook != null)
			{
				bookList.Remove(selectedBook);
				MessageBox.Show("The book has been deleted!");
				ClearTextBoxes();
				RefreshGrid();
				selectedBook = null;
			}
			else
			{
				MessageBox.Show("No book selected!");
			}
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				var selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Book;
				if (selectedItem != null)
				{
					selectedBook = selectedItem;
					textBox1.Text = selectedBook.Name;
					textBox2.Text = selectedBook.Author;
					textBox3.Text = selectedBook.Genre;
				}
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
	
}

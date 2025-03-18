namespace WindowsFormsApp3
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.btnUpdateBook = new System.Windows.Forms.Button();
			this.btnDeleteBook = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(12, 78);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(199, 32);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(301, 78);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(199, 32);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(589, 78);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(199, 32);
			this.textBox3.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(298, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Author";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(586, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Genre";
			// 
			// btnAddBook
			// 
			this.btnAddBook.BackColor = System.Drawing.SystemColors.MenuBar;
			this.btnAddBook.Location = new System.Drawing.Point(12, 196);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(199, 52);
			this.btnAddBook.TabIndex = 6;
			this.btnAddBook.Text = "Add";
			this.btnAddBook.UseVisualStyleBackColor = false;
			this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
			// 
			// btnUpdateBook
			// 
			this.btnUpdateBook.BackColor = System.Drawing.SystemColors.MenuBar;
			this.btnUpdateBook.Location = new System.Drawing.Point(301, 196);
			this.btnUpdateBook.Name = "btnUpdateBook";
			this.btnUpdateBook.Size = new System.Drawing.Size(199, 52);
			this.btnUpdateBook.TabIndex = 7;
			this.btnUpdateBook.Text = "Update";
			this.btnUpdateBook.UseVisualStyleBackColor = false;
			this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
			// 
			// btnDeleteBook
			// 
			this.btnDeleteBook.BackColor = System.Drawing.SystemColors.MenuBar;
			this.btnDeleteBook.Location = new System.Drawing.Point(589, 196);
			this.btnDeleteBook.Name = "btnDeleteBook";
			this.btnDeleteBook.Size = new System.Drawing.Size(199, 52);
			this.btnDeleteBook.TabIndex = 8;
			this.btnDeleteBook.Text = "Delete";
			this.btnDeleteBook.UseVisualStyleBackColor = false;
			this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-2, 300);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(804, 150);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Desktop;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDeleteBook);
			this.Controls.Add(this.btnUpdateBook);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.Button btnUpdateBook;
		private System.Windows.Forms.Button btnDeleteBook;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}


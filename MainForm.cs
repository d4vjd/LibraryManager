using LibraryManager.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class MainForm : Form
    {
        private LibraryManager.Logic.Logic logic = new LibraryManager.Logic.Logic();
        private Context context = new Context();

        public MainForm()
        {
            InitializeComponent();

            BookList.DataSource = context.Books.ToList();
            BookList.DisplayMember = "Title";

            ClientList.DataSource = context.Clients.ToList();
            ClientList.DisplayMember = "Name";

            AddBookForm addBookForm = new AddBookForm(context, this);

        }

        // add/delete books

        private void button1_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(context, this);
            addBookForm.ShowDialog();
        }

        public void OnBookAdded(object sender, EventArgs e)
        {
            BookList.DataSource = null;
            BookList.DataSource = context.Books.ToList();
            BookList.DisplayMember = "Title";
        }
        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            Book selectedBook = BookList.SelectedItem as Book;

            if (selectedBook == null)
            {
                MessageBox.Show("Please select a book to delete.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    context.Books.Remove(selectedBook);
                    context.SaveChanges();
                    BookList.DataSource = null;
                    BookList.DataSource = context.Books.ToList();
                    BookList.DisplayMember = "Title";
                }
            }
        }

        // add/delete clients

        private void addClientButton_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm(context, this);
            addClientForm.ShowDialog();
        }

        public void OnClientAdded(object sender, EventArgs e)
        {
            ClientList.DataSource = null;
            ClientList.DataSource = context.Clients.ToList();
            ClientList.DisplayMember = "Name";
        }
        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            Client selectedClient = ClientList.SelectedItem as Client;

            if (selectedClient == null)
            {
                MessageBox.Show("Please select a client to delete.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    context.Clients.Remove(selectedClient);
                    context.SaveChanges();
                    ClientList.DataSource = null;
                    ClientList.DataSource = context.Clients.ToList();
                    ClientList.DisplayMember = "Name";
                }
            }
        }

        //borrow book

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            var borrowBookForm = new BorrowBookForm(context);
            borrowBookForm.ShowDialog();
        }

        //sidebar

        bool sidebarExpand=true;
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Collapse sidebar
                for (double i = 1; i >= 0; i -= 0.1)
                {
                    // calculate new width for sidebar
                    int newWidth = (int)(sidebar.MinimumSize.Width + (sidebar.Width - sidebar.MinimumSize.Width) * (float)i);

                    // set new size for sidebar
                    sidebar.Size = new Size(newWidth, sidebar.Height);

                    // wait before setting the next size
                    await Task.Delay(20);

                    // check if we've reached the minimum width
                    if (sidebar.Width <= sidebar.MinimumSize.Width)
                    {
                        sidebarExpand = false;
                        sidebarTimer.Stop();
                        break;
                    }
                }
            }
            else
            {
                // Expand sidebar
                for (double i = 0; i <= 1; i += 0.1)
                {
                    // calculate new width for sidebar
                    int newWidth = (int)(sidebar.MaximumSize.Width * (float)i);

                    // set new size for sidebar
                    sidebar.Size = new Size(newWidth, sidebar.Height);

                    // wait before setting the next size
                    await Task.Delay(20);

                    // check if we've reached the maximum width
                    if (sidebar.Width >= sidebar.MaximumSize.Width)
                    {
                        sidebarExpand = true;
                        sidebarTimer.Stop();
                        break;
                    }
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }




        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BookList = new System.Windows.Forms.ListBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.borrowBookButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BookList
            // 
            this.BookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(80)))), ((int)(((byte)(77)))));
            this.BookList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookList.FormattingEnabled = true;
            this.BookList.ItemHeight = 17;
            this.BookList.Location = new System.Drawing.Point(475, 113);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(251, 463);
            this.BookList.TabIndex = 0;
            this.BookList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ClientList
            // 
            this.ClientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(80)))), ((int)(((byte)(77)))));
            this.ClientList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 17;
            this.ClientList.Location = new System.Drawing.Point(869, 113);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(251, 463);
            this.ClientList.TabIndex = 1;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(80)))), ((int)(((byte)(77)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(314, 620);
            this.sidebar.MinimumSize = new System.Drawing.Size(67, 620);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(314, 620);
            this.sidebar.TabIndex = 9;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 110);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteBookButton);
            this.panel3.Location = new System.Drawing.Point(3, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 77);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addClientButton);
            this.panel4.Location = new System.Drawing.Point(3, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 77);
            this.panel4.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addBookButton);
            this.panel2.Location = new System.Drawing.Point(3, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 77);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deleteClientButton);
            this.panel5.Location = new System.Drawing.Point(3, 368);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 77);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.borrowBookButton);
            this.panel6.Location = new System.Drawing.Point(3, 451);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 77);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(3, 534);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(306, 77);
            this.panel7.TabIndex = 13;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::LibraryManager.Properties.Resources.icons8_squared_menu_50;
            this.menuButton.Location = new System.Drawing.Point(9, 31);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 46);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBookButton.Image = global::LibraryManager.Properties.Resources.icons8_remove_book_50;
            this.deleteBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBookButton.Location = new System.Drawing.Point(0, 0);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(308, 77);
            this.deleteBookButton.TabIndex = 3;
            this.deleteBookButton.Text = "Delete book";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.Image = global::LibraryManager.Properties.Resources.icons8_add_administrator_50;
            this.addClientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addClientButton.Location = new System.Drawing.Point(0, 0);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(307, 77);
            this.addClientButton.TabIndex = 6;
            this.addClientButton.Text = "Add client";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.Black;
            this.addBookButton.Image = global::LibraryManager.Properties.Resources.icons8_add_book_501;
            this.addBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBookButton.Location = new System.Drawing.Point(0, 0);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(308, 77);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "Add book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClientButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClientButton.Image = global::LibraryManager.Properties.Resources.icons8_remove_administrator_50;
            this.deleteClientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteClientButton.Location = new System.Drawing.Point(0, 0);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(307, 77);
            this.deleteClientButton.TabIndex = 7;
            this.deleteClientButton.Text = "Delete client";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // borrowBookButton
            // 
            this.borrowBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBookButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBookButton.Image = global::LibraryManager.Properties.Resources.icons8_borrow_book_50;
            this.borrowBookButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBookButton.Location = new System.Drawing.Point(0, 0);
            this.borrowBookButton.Name = "borrowBookButton";
            this.borrowBookButton.Size = new System.Drawing.Size(306, 77);
            this.borrowBookButton.TabIndex = 8;
            this.borrowBookButton.Text = "Borrow / Return book";
            this.borrowBookButton.UseVisualStyleBackColor = true;
            this.borrowBookButton.Click += new System.EventHandler(this.borrowBookButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::LibraryManager.Properties.Resources.icons8_chart_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "Statistics";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(90, 31);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(85, 37);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book List:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(916, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Client List:";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(129)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1197, 620);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.BookList);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

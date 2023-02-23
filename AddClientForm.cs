using LibraryManager.DataModels;
using LibraryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context = LibraryManager.DataModels.Context;
using System.Data.Entity.Validation;

namespace LibraryManager
{
    public partial class AddClientForm : Form
    {
        public LibraryManager.Logic.Logic logic = new LibraryManager.Logic.Logic();
        private Context context;
        private MainForm mainForm;

        public AddClientForm(Context context, MainForm mainForm)
        {
            InitializeComponent();
            this.context = context;
            this.mainForm = mainForm;

            ClientAdded += mainForm.OnClientAdded;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter client name.");
                return;
            }

            int nextClientId = context.Clients.OrderByDescending(c => c.Id).FirstOrDefault().Id + 1;
            Client client = new Client
            {
                Id = nextClientId,
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                JoinDate = joinDateTimePicker.Value
            };
            context.Clients.Add(client);

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                //this code loops through the EntityValidationErrors collection and builds a
                //string that lists each property and its corresponding validation error.
                StringBuilder sb = new StringBuilder();

                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        sb.AppendLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }

                MessageBox.Show($"An error occurred while adding the client:\n\n{sb.ToString()}");
                return;
            }

            OnClientAdded(EventArgs.Empty);

            MessageBox.Show("Client added successfully.");
            this.Close();
        }

        public event EventHandler ClientAdded;
        public virtual void OnClientAdded(EventArgs e)
        {
            ClientAdded?.Invoke(this, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}

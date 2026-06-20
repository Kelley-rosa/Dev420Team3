using MongoDB.Driver;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class RegisterForm : Form
    {
        IMongoCollection<User> userCollection;

        public RegisterForm()
        {
            InitializeComponent();

            var connectionString =
                ConfigurationManager.ConnectionStrings["MongoDBConnection"].ConnectionString;

            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);

            userCollection = database.GetCollection<User>("users");
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string email = textBox_email.Text;
            string role = comboBox_role.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check if the username already exists
            var filter = Builders<User>.Filter.Eq("username", username);
            var existingUser = userCollection.Find(filter).FirstOrDefault();

            if (existingUser == null)
            {
                var user = new User
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    Role = role
                };

                userCollection.InsertOne(user);
                MessageBox.Show("Registered successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists, please choose a different one.");
            }
        }
    }
}
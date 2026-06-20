using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Configuration;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
        IMongoCollection<User> userCollection;

        public LoginForm()
        {
            InitializeComponent();

            // get connection string from app config
            var connectionString =
                ConfigurationManager.ConnectionStrings["MongoDBConnection"].ConnectionString;

            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);

            // get the users collection
            userCollection = database.GetCollection<User>("users");
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // get info from the user
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check user info against the database
            var filter = Builders<User>.Filter.Eq("username", username) &
                Builders<User>.Filter.Eq("password", password);

            var user = userCollection.Find(filter).FirstOrDefault();

            // if user exists, pass them to main form
            if (user != null)
            {
                MessageBox.Show("Login successful! Welcome " + user.Username);
                ((MainForm)Application.OpenForms["MainForm"]).SetLoggedInUser(user);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
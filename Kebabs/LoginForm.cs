using Kebabs.Models;
using Kebabs.Services;

namespace Kebabs
{
    public partial class Kebabs : Form
    {
        private readonly AuthService _authService = new AuthService();
        public Kebabs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, Color.White);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            //1) Basic Validation 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Login with AuthService 
            var user = _authService.Login(username, password);
            if (user == null)
            {
                MessageBox.Show("Please enter username and password.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //3 Successfully login -> save to session
            AppSession.CurrentUser = user;

            //Form for Role
            OpenFormForRole(user);

        }
        private void OpenFormForRole(User user)
        {
            Form nextForm;

            switch (user.Role)
            {
                case "Customer":
                    nextForm = new CustomerForm(user);
                    break;
                case "Restaurant":
                    nextForm = new RestaurantForm(user);
                    break;
                case "Courier":
                    nextForm = new CourierForm(user);
                    break;
                default:
                    MessageBox.Show("Unknown user role: " + user.Role);
                    return;
            }

            //Close Application When you close child  form
            nextForm.FormClosed += (s, e) => this.Close();

            nextForm.Show();
            this.Hide();
        }

        private void Kebabs_Load(object sender, EventArgs e)
        {

        }
    }
}

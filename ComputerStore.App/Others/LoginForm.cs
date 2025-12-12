using ComputerStore.App.Infra;
using ComputerStore.App.Register;
using ComputerStore.Domain.Base;
using ComputerStore.Domain.Entity;
using ComputerStore.Service.Service;
using ComputerStore.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace ComputerStore.App.Others
{
    public partial class LoginForm : LostForm
    {
        private readonly IBaseService<User> _userService;
        public LoginForm(IBaseService<User> userService)
        {

            _userService = userService;
            InitializeComponent();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User? user = GetUser(txtLogin.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid login and/or password!", "ComputerStore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                Session.LoggedInUser = user;
                MessageBox.Show($"Welcome, {user.Name}!", "to Computer Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private User? GetUser(string login, string password)
        {

            var user = _userService.Get<User>().Where(x => x.Login == login).FirstOrDefault();
            if (user == null)
                return null;
            return user.Password != password ? null : user;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btnNewAcount_Click(object sender, EventArgs e)
        {
            var form = ConfigureDI.serviceProvider!.GetService<UserRegister>();
            form.ShowDialog();
        }
    }
}

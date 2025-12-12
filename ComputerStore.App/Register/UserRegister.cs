
using ComputerStore.App.Base;
using ComputerStore.App.ViewModel;
using ComputerStore.Domain.Base;
using ComputerStore.Domain.Entity;
using ComputerStore.Service.Validators;
using ReaLTaiizor.Controls;

namespace ComputerStore.App.Register
{
    public partial class UserRegister : TestBaseForm
    {
        private IBaseService<User> _userService;
        private List<UserViewModel> _users;

        public UserRegister(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
            
        }

        private void FormToObject(User user)
        {
            user.Name = txtName.Text;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.IsEnable = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                var user = new User();
                FormToObject(user);
                _userService.Add<User, User, UserValidator>(user);
                MessageBox.Show("Your account was successfully created.",
                    "Computer Store",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                ClearFields();
                MessageBox.Show(ex.Message,@"Computer Store",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
                                      
        }

        private void ClearFields()
        {
            foreach (var control in this.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                {
                   textBox.Clear();
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMITMAUI1.VeiwModels
{
    public class SignUpViewModel : ViewModelBase
    {
        #region Properties
        private string? _firstName;
        private string? _lastName;
        private string? _email;
        private string? _password;
        private string? _mobile;
        private bool _entryAsPassword;
        private string? _passwordIconCode;
        public string FirstName
        {
            get => _firstName!;
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string LastName
        {
            get => _lastName!;
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Email
        {
            get => _email!;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get => _password!;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Mobile
        {
            get => _mobile!;
            set
            {
                if (_mobile != value)
                {
                    _mobile = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool EntryAsPassword
        {
            get => _entryAsPassword;
            set
            {
                if (_entryAsPassword != value)
                {
                    _entryAsPassword = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PasswordIconCode
        {
            get => _passwordIconCode!;
            set
            {
                if (_passwordIconCode != value)
                {
                    _passwordIconCode = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        public SignUpViewModel()
        {
        
        }
    }
}

using AMITMAUI1.Helper;
using AMITMAUI1.Service;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AMITMAUI1.VeiwModels
{
    public class SignInVeiwModel : ViewModelBase /*ObservableObject*/
    {
        private string? _username;
        private string? _password;
        private bool _enteryasPassword;
        private bool _isMessageLabelVisble;
        private string? _MessageText;
        private Color? _messageTextColor;
        private string? _togglepasswordButtonText;
        private bool _isDEbugMode => true;
        private DBMokup? _dbMokup;
        public string TogglePasswordButtonText
        {
            get => _togglepasswordButtonText!;
            set
            {
                if (_togglepasswordButtonText != value)
                {
                    _togglepasswordButtonText = value;
                    OnPropertyChanged(nameof(TogglePasswordButtonText));
                }
            }
        }
        public bool IsMessageLabelVisble
        {
            get => _isMessageLabelVisble;
            set
            {
                if (_isMessageLabelVisble != value)
                {
                    _isMessageLabelVisble = value;
                    OnPropertyChanged(nameof(IsMessageLabelVisble));
                }
            }
        }
        public string Username
        {
            get => _username!;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                    //OnPropertyChanged(nameof(IsSignInButtonEnabled));
                    (SignInCommand as Command)?.ChangeCanExecute();
                }
            }
        }
        public string UserPassword
        {
            get => _password!;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(UserPassword));
                    (SignInCommand as Command)?.ChangeCanExecute();
                }
            }
        }
        public bool EntryAsPassword
        {
            get => _enteryasPassword;
            set
            {
                if (_enteryasPassword != value)
                {
                    _enteryasPassword = value;
                    OnPropertyChanged(nameof(EntryAsPassword));
                }
            }
        }
        public string MessageText
        {
            get => _MessageText!;
            set
            {
                if (_MessageText != value)
                {
                    _MessageText = value;
                    OnPropertyChanged(nameof(MessageText));
                }
            }
        }
        public Color MessageTextColor
        {
            get => _messageTextColor!;
            set
            {
                if (_messageTextColor != value)
                {
                    _messageTextColor = value;
                    OnPropertyChanged(nameof(MessageTextColor));
                }
            }
        }

        public ICommand ShowPasswordCommand { get; }
        public ICommand SignInCommand { get; }

        public SignInVeiwModel()
        {
            // ShowPasswordCommand = new Command(OnTugglePasswordButtonClicked);
            ShowPasswordCommand = new Command(() =>
            {
                if (EntryAsPassword)
                    TogglePasswordButtonText = FontHelper.CLOSED_EYE_ICON;
                else
                    TogglePasswordButtonText = FontHelper.OPEN_EYE_ICON;

                EntryAsPassword = !EntryAsPassword;
            });
            SignInCommand = new Command(OnSignInButtonClicked , CanSignIn);
            
            TogglePasswordButtonText = FontHelper.CLOSED_EYE_ICON;

            EntryAsPassword = true;

            _dbMokup = new DBMokup();

            if (_isDEbugMode)
            {
                Username = "admin@mail.com";
                UserPassword = "admin";
            }
        }

        void OnTugglePasswordButtonClicked()
        {
            //if (EntryAsPassword)
            //    TogglePasswordButtonText = FontHelper.CLOSED_EYE_ICON;
            //else
            //    TogglePasswordButtonText = FontHelper.OPEN_EYE_ICON;

            //EntryAsPassword = !EntryAsPassword;
        }

        void OnSignInButtonClicked()
        {
            if (_dbMokup!.IsExist(Username, UserPassword))
            {
                MessageText = MessagesHelper.SIGNINSUCCESSMESSAGE;
                MessageTextColor = Colors.Green;
            }
            else
            {
                MessageText = MessagesHelper.SIGNINERRORMESSAGE;
                MessageTextColor = Colors.Red;
            }
            IsMessageLabelVisble = true;
        }
        private bool CanSignIn()
        {
            return !(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(UserPassword));
        }
    }
}

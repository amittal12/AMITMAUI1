using AMITMAUI1.Helper;
using AMITMAUI1.Service;
using AMITMAUI1.VeiwModels;

namespace AMITMAUI1.Views;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
        BindingContext = new SignInVeiwModel();
    }
}
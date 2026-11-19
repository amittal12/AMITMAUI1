


using AMITMAUI1.Views;

namespace AMITMAUI1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new SignUpPage2());
            //return new Window(new SignUpPage2());
        }
    }
}
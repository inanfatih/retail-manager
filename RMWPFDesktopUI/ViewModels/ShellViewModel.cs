using Caliburn.Micro;

namespace WPFDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        //private ICalculations _calculations;
        //public ShellViewModel(ICalculations calculations)
        //{
        //    _calculations = calculations;
        //}
        private LoginViewModel _loginVM;
        public ShellViewModel(LoginViewModel loginVM)
        {
            _loginVM = loginVM;
            ActivateItem(_loginVM);
        }
    }
}

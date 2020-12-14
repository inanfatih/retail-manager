namespace RMWPFDesktopUI.ViewModels
{
    public class ShellViewModel
    {
        private ICalculations _calculations;
        public ShellViewModel(ICalculations calculations)
        {
            _calculations = calculations;
        }
    }
}

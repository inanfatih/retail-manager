using Caliburn.Micro;
using WPFDesktopUI.EventModels;

namespace WPFDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        //private ICalculations _calculations;
        //public ShellViewModel(ICalculations calculations)
        //{
        //    _calculations = calculations;
        //}

        private IEventAggregator _events;
        private SalesViewModel _salesVM;

        public ShellViewModel(
            IEventAggregator events,
            SalesViewModel salesVM)
        {
            _events = events;
            _salesVM = salesVM;

            _events.Subscribe(this);

            ActivateItem(IoC.Get<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
        }
    }
}

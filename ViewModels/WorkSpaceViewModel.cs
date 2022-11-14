using Magazynuj.Helpers;
using System.Windows.Input;
using System;

namespace Magazynuj.ViewModels
{
    public abstract class WorkSpaceViewModel : BaseViewModel
    {

        #region Constructor
        public WorkSpaceViewModel() { }
        #endregion

        #region CloseCommand
        // komenda do zamykania zakładki
        private BaseCommand _CloseCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                    _CloseCommand = new BaseCommand(() => this.OnRequestClose());// ta komenda wywoła metodę OnRequestClose
                return _CloseCommand;
            }
        }
        #endregion

        #region Helpers
        public event EventHandler RequestClose;
        private void OnRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        #endregion
    }
}
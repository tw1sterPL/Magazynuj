using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynuj.ViewModels
{
    public class NewInvoiceViewModel : WorkSpaceViewModel
    {
        #region Constructor
        public NewInvoiceViewModel()
        {
            base.DisplayName = "Faktura";
        }
        #endregion
    }
}

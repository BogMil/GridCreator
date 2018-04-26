using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GridCreator.View.Pages
{
    public interface IBasePage
    {
        void GoToNextPage(GridCreatorWindow baseWindow);
        void GoToPreviousPage(GridCreatorWindow baseWindow);
    }
}

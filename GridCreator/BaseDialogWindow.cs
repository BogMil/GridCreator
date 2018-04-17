using Microsoft.VisualStudio.PlatformUI;

namespace GridCreator
{
    public class BaseDialogWindow : DialogWindow
    {

        public BaseDialogWindow()
        {
            this.HasMaximizeButton = true;
            this.HasMinimizeButton = true;
        }
    }
}

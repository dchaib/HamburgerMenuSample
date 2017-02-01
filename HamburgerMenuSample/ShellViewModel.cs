using Caliburn.Micro;
using MahApps.Metro.Controls;

namespace HamburgerMenuSample
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShell
    {
        public ShellViewModel()
        {
            DisplayName = "Hamburger menu sample";
        }

        public void ShowScreen(HamburgerMenuItem menuItem)
        {
            switch ((string)menuItem.Tag)
            {
                case "1": ActivateItem(new Screen1ViewModel()); break;
                case "2": ActivateItem(new Screen2ViewModel()); break;
                default: break;
            }
        }
    }
}
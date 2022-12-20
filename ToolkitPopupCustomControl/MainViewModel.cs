using CommunityToolkit.Maui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToolkitPopupCustomControl
{
    public class MainViewModel
    {
        public ICommand DisplayPopupCommand { private set; get; }

        public MainViewModel() {
            DisplayPopupCommand = new Command(
            execute: async () =>
            {
                var vm = new PopupViewModel();
                var newPopup = new Popup1(vm);

                var result = await Application.Current.MainPage.ShowPopupAsync(newPopup);
            });
        }

    }
}

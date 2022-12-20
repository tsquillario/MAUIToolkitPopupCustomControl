using CommunityToolkit.Maui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToolkitPopupCustomControl
{
    public class PopupViewModel
    {
        public ICommand TestCommand { private set; get; }
        public PopupViewModel() { 
            TestCommand = new Command(
            execute: () =>
            {
                Console.WriteLine("TEST COMMAND");
            });
        }
}
}

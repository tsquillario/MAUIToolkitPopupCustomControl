using CommunityToolkit.Maui.Views;

namespace ToolkitPopupCustomControl;

public partial class Popup1 : Popup
{
	public Popup1(PopupViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
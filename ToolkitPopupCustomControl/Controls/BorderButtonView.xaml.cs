using System.Windows.Input;

namespace ToolkitPopupCustomControl.Controls;

public partial class BorderButtonView : ContentView
{
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(BorderButtonView), string.Empty);
    public string Text
    {
        get => (string)GetValue(BorderButtonView.TextProperty);
        set => SetValue(BorderButtonView.TextProperty, value);
    }

    public static readonly BindableProperty ToolTipTextProperty = BindableProperty.Create(nameof(ToolTipText), typeof(string), typeof(BorderButtonView), string.Empty);
    public string ToolTipText
    {
        get => (string)GetValue(BorderButtonView.ToolTipTextProperty);
        set => SetValue(BorderButtonView.ToolTipTextProperty, value);
    }

    public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(BorderButtonView));
    public ICommand Command
    {
        get => (ICommand)GetValue(BorderButtonView.CommandProperty);
        set => SetValue(BorderButtonView.CommandProperty, value);
    }

    public BorderButtonView()
    {
        InitializeComponent();
    }
}
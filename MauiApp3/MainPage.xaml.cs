using Microsoft.Maui.HotReload;

namespace MauiApp3;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        Button button = new Button
        {
            Text = "Click me!"
        };
        Button button2 = new Button
        {
            Text = "Naklejka"
        };
        Button button3 = new Button
        {
            Text = "Hejka!"
        };
        Label label = new Label
        {
            Text = "Pole",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center

        };
        CheckBox checkBox = new CheckBox
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        button.Clicked += (sender, e) =>
        {
            button.Text = "Klikles mnie";
            button2.Text = "Przycisk wyzej zostal klikniety";
        };
        checkBox.CheckedChanged += (sender, e) =>
        {
            label.Text = "Kliknales na checkboxa";
            checkBox.IsChecked = false;
        };

        Content = new StackLayout
        {
            Children = { button,button2,button3,label,checkBox }
        };
    }

}


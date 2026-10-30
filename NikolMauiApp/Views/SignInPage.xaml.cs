
using NikolMauiApp.Helpers;

namespace NikolMauiApp.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}
    private void TogglePassordButton_Clicked(object sender, EventArgs e)
    {
        var visBtn = sender as Button;
        PasswordEntry.IsPassword = !PasswordEntry.IsPassword;

        if (PasswordEntry.IsPassword)
            visBtn!.Text = FontHelper.CLOSED_EYE_ICON;
        else
            visBtn!.Text = FontHelper.OPEN_EYE_ICON;
    }
}
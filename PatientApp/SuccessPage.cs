namespace PatientApp;

public class SuccessPage : ContentPage
{
	public SuccessPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Successfully Added the Photos"
				}
			}
		};
	}
}

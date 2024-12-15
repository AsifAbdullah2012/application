namespace PatientApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(FootPhoto), typeof(FootPhoto)); // routing to footphoto

		Routing.RegisterRoute(nameof(SuccessPage), typeof(SuccessPage));
	}
}


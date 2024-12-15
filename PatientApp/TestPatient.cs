using Java.Nio.FileNio.Attributes;
using static Java.Util.Jar.Attributes;

namespace PatientApp;

public class TestPatient : ContentPage
{

    private Entry firstNameEntry;
    private Entry lastNameEntry;
    private DatePicker dateOfBirthPicker;
    private Entry weightEntry;
    private Entry shoeSizeEntry;



    public TestPatient()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};


        //----------------------------------------------------

            // Create UI elements
            firstNameEntry = new Entry
            {
                Placeholder = "First Name"
            };
            firstNameEntry.SetBinding(Entry.TextProperty, "NewPatient.FirstName");

            lastNameEntry = new Entry
            {
                Placeholder = "Last Name"
            };
            lastNameEntry.SetBinding(Entry.TextProperty, "NewPatient.LastName");

            dateOfBirthPicker = new DatePicker();
            dateOfBirthPicker.SetBinding(DatePicker.DateProperty, "NewPatient.DateOfBirth");

            weightEntry = new Entry
            {
                Placeholder = "Weight",
                Keyboard = Keyboard.Numeric
            };
            weightEntry.SetBinding(Entry.TextProperty, "NewPatient.Weight");

            shoeSizeEntry = new Entry
            {
                Placeholder = "Shoe Size",
                Keyboard = Keyboard.Numeric
            };
            shoeSizeEntry.SetBinding(Entry.TextProperty, "NewPatient.ShoeSize");



            //------------ photo label starts ----------------------------
            /*

            var photoLabel = new Label
            {
                Text = "Patient Foot Photos:",
                Margin = new Thickness(0, 20, 0, 10)
            };

            var photoCollectionView = new CollectionView
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    var photoLabel = new Label();
                    photoLabel.SetBinding(Label.TextProperty, ".");
                    return photoLabel;
                })
                
            };
            photoCollectionView.SetBinding(CollectionView.ItemsSourceProperty, "Photos");

            var addPhotoButton = new Button
            {
                Text = "Add Photo",
                Margin = new Thickness(0, 20, 0, 10)
            };
            addPhotoButton.SetBinding(Button.CommandProperty, "AddPhotoCommand");

            */


            // ------ photo label ends --------------------

            var submitButton = new Button
            {
                Text = "Submit",
                Margin = new Thickness(0, 20, 0, 10)
            };
            submitButton.SetBinding(Button.CommandProperty, "SubmitPatientCommand");
            submitButton.Clicked += OnSubmitButtonClicked;

        // Layout
        var stackLayout = new VerticalStackLayout
            {
                Padding = 30,
                Children =
                {
                    firstNameEntry,
                    lastNameEntry,
                    dateOfBirthPicker,
                    weightEntry,
                    shoeSizeEntry,
                    //photoLabel,
                    //photoCollectionView,
                    //addPhotoButton,
                    submitButton
                }
            };

            var scrollView = new ScrollView
            {
                Content = stackLayout
            };

            Content = scrollView;







        
    }


    private async void OnSubmitButtonClicked(object sender, EventArgs e)
    {
        // Get user input
        string firstname = firstNameEntry.Text;
        string lastName = lastNameEntry.Text;
        DateTime dob = dateOfBirthPicker.Date;
        string weight = weightEntry.Text;
        string shoesize = shoeSizeEntry.Text;

        // Validate input
        if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(weight) || string.IsNullOrWhiteSpace(shoesize))
        {
            await DisplayAlert("Error", "Please fill out all fields.", "OK");
            return;
        }

        // Navigate to the next page with the patient information
        await Shell.Current.GoToAsync(nameof(FootPhoto));
    }
}





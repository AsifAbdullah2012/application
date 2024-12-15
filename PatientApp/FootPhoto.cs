using Microsoft.Maui.Controls;

namespace PatientApp;

public class FootPhoto : ContentPage
{
	public FootPhoto()
	{







        //--------------------- foot photo simple with instructions ..............................



        var grid = new Grid
        {

            

            RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star }
                },
            ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star }
                }
        };

        // Create Buttons
        var button1 = CreateCameraButton("Left Foot Top");
        var button2 = CreateCameraButton("Left Foot Bottom");
        var button3 = CreateCameraButton("Right Foot Top");
        var button4 = CreateCameraButton("Right Foot Bottom");



        // Add buttons to the grid with margin
        button1.Margin = new Thickness(15); // Add margin to each button
        button2.Margin = new Thickness(15);
        button3.Margin = new Thickness(15);
        button4.Margin = new Thickness(15);

        // Add buttons to the grid
        grid.Add(button1, 0, 0); // Add to row 0, column 0
        grid.Add(button2, 1, 0); // Add to row 0, column 1
        grid.Add(button3, 0, 1); // Add to row 1, column 0
        grid.Add(button4, 1, 1); // Add to row 1, column 1

        // Set the grid as the Content of the page
        //Content = grid;


        // Create the Grid layout (2 rows x 1 column)


       
        var imagegrid = new Grid
        {
            RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star }
                },
            ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }
                },
            Padding = 10,
            RowSpacing = 10
        };








        

        var submitButton = new Button
        {
            Text = "Submit",
            Margin = new Thickness(0, 10, 0, 10)
        };
        submitButton.SetBinding(Button.CommandProperty, "SubmitPatientFootCommand");
        submitButton.Clicked += OnSubmitButtonClicked;


        // layout information savings
        // Layout
        var stackLayout = new VerticalStackLayout
        {
            Padding = 20,
            Children =
                {
                    grid,
                    submitButton
                }
        };

        var scrollView = new ScrollView
        {
            Content = stackLayout
        };

        Content = scrollView;

    }

    private Button CreateCameraButton(string text)
    {
        var button = new Button { Text = text };
        button.Clicked += async (s, e) => await OpenCameraAsync();
        return button;
    }

    private async Task OpenCameraAsync()
    {
        try
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                var photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // Show confirmation (optional)
                    await DisplayAlert("Photo Captured", $"File saved at {photo.FullPath}", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Camera not supported on this device.", "OK");
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions (e.g., user denies permission)
            await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
        }

    }


    private async void OnSubmitButtonClicked(object sender, EventArgs e)
    {


        // Navigate to the next page with the patient information
        await Shell.Current.GoToAsync(nameof(SuccessPage));
    }


 








}
    

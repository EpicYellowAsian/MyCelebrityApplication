using MyCelebrityApplication.DataManager;

namespace MyCelebrityApplication;

public partial class SearchResult : ContentPage
{
	public SearchResult(List<Models.Celebrity> celebrity)
	{
		InitializeComponent();
		//BindingContext = new DataManager.CelebrityDataManager();
		this.BindingContext = celebrity; 
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}
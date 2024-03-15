using MyCelebrityApplication.DataManager;

namespace MyCelebrityApplication
{
    // Jag har inte använt mig av singleton i min uppgift då jag inte har någon inloggningsfunktion och därav har jag inte behövt använda mig av singleton. 
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void OnSearchClicked(object sender, EventArgs e)
        {
            try
            {
                string searchQuery = searchBar.Text;
                List<Models.Celebrity> celebrities = await CelebrityDataManager.GetCelebrity("celebrity?name=" + searchQuery);
                await Navigation.PushAsync(new SearchResult(celebrities));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't gather information, try again " + ex.Message); 
            }
        }
    }
}

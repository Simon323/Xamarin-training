using Xamarin.Forms;

namespace HelloWorld
{
	public partial class App : Application
	{
		public App()
		{
			//InitializeComponent();

			//MainPage = new HelloWorldPage();

			//MainPage = new ContentPage
			//{
			//	Content = new StackLayout
			//	{
			//		VerticalOptions = LayoutOptions.Center, 
			//		Children = {
			//			new Label {
			//				HorizontalTextAlignment = TextAlignment.Center,
			//				Text = "Welcome in west world"
			//			}
			//		}
			//	}
			//};

			//MainPage = new Example();

			//MainPage = new NavigationPage(new HomePage());

			//MainPage = new TabbedPage
			//{
			//	Children = {
			//		new HomePage(),
			//		new FirstPage("Hello")
			//	}
			//};

			MainPage = new ListViewPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace HelloWorld.Views.SimpleLogin
{
	public partial class SignupPage : ContentPage
	{
		public SignupPage()
		{
			// A new element we're creating here - the Entry element
			// Entry allows us to capture user input
			// We are adding a Placeholder attribute to tell the user
			// which data we want them to enter
			var email = new Entry
			{
				Placeholder = "Email"
			};

			// Similar to the email entry button, we capture the
			// users password here. To hide the password from being
			// displayed we set the `IsPassword` attribute to true
			var password = new Entry
			{
				Placeholder = "Password",
				IsPassword = true
			};

			var signupButton = new Button
			{
				Text = "Sign Up"
			};

			signupButton.Clicked += (object sender, EventArgs e) =>
			{
				// We have created a function that takes the captured email
				// and password and attempts to create a new user account
				Signup(email.Text, password.Text);
			};

			Content = new StackLayout
			{
				Padding = 30,
				Spacing = 10,
				Children = { new Label { Text = "Signup for a CloudCakes Account", FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)), HorizontalOptions = LayoutOptions.Center },
				  email,
				  password,
				  signupButton
				}
			};
		}

		// The Signup function calls the `dbconnections/signup` API and attempts
		// to create a new user account
		public void Signup(string username, string password)
		{
			//var client = new RestClient("https://{YOUR-AUTH0-DOMAIN}.auth0.com");
			//var request = new RestRequest("dbconnections/signup", Method.POST);

			//request.AddParameter("client_id", "{YOUR-AUTH0-CLIENT-ID}");
			//request.AddParameter("email", username);
			//request.AddParameter("password", password);
			//request.AddParameter("connection", "{YOUR-DATABASE-CONNECTION-NAME");

			//IRestResponse response = client.Execute(request);
			// Once the request is executed we capture the response.
			// If we get a `user_id`, we know that the account has been created
			// and display an appropriate message. If we do not get a `user_id`
			// we know something went wrong, so we ask the user if they already have
			// an account and if not to try again.

			//UserSignup user = JsonConvert.DeserializeObject<UserSignup>(response.Content);
			var user = new UserSignup
			{
				user_id = "Tony"
			};
			if (user.user_id != null)
			{
				DisplayAlert("Account Created", "Head back to the hompage and login with your new account", "Ok");
			}
			else {
				DisplayAlert("Oh No!", "Account could not be created. Do you already have an account? Please try again.", "Ok");
			}
		}

		public class UserSignup
		{
			public string user_id { get; set; }
		}
	}
}
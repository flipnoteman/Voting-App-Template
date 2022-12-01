using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using CsvHelper;
using Voting_App_V1_0;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Voting_App_V1._0
{
    public partial class MainPage : ContentPage
    {
        private string username = "";
        private string password = "";

        private List<Registrant> list;

        public MainPage()
        {
            InitializeComponent();

            list = new List<Registrant>();

            list.Add(new Registrant
            {
                IDN = 102,
                LastName = "Davis",
                Major = "CS",
                Minor = "Math",
                Password = "password",
                Roll = "S"
            });

            list.Add( new Registrant
            {
                IDN = 103,
                LastName = "Smith",
                Major = "ITE",
                Minor = "Humanities",
                Password = "Adm1n",
                Roll = "F"
            });

            // Stub for Reading CSV for database for login
            //
            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "Registrants.csv";

            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //using (StreamReader reader = new StreamReader(stream))
            //{

            //    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            //    {
            //        while (csv.Read())
            //        {
            //            list.Add(new Registrant
            //            {
            //                IDN = int.Parse(csv.GetField<string>(0)),
            //                LastName = csv.GetField<String>(1),
            //                Major = csv.GetField<String>(2),
            //                Minor = csv.GetField<String>(3),
            //                Password = csv.GetField<String>(4),
            //                Roll = csv.GetField<String>(5)
            //            });
            //        }
            //    }
            //}
        }


        private void InputView_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        private void User_OnCompleted(object sender, EventArgs e)
        {
            username = ((Entry)sender).Text;
        }

        private void Pass_OnCompleted(object sender, EventArgs e)
        {
            password = ((Entry)sender).Text;
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            username = UserEntry.Text;
            password = PasswordEntry.Text;

            foreach (var x in list)
            {
                if (username != null)
                {
                    if (x.IDN.ToString().Trim() == username.Trim() && x.Password.Trim() == password.Trim())
                    {
                        if (x.Roll.Trim() == "S")
                        {
                            await Navigation.PushAsync(new ContestPage());
                        }
                        else
                        {
                            await Navigation.PushAsync(new AdminPage());
                        }
                    }
                    else
                    {
                        ErrorLabel.Text = "IDN or Password is incorrect, Please try again";
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Voting_App_V1_0
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class VotingPage1 : ContentPage
{
    private Vote vote;

    public VotingPage1()
    {
        InitializeComponent();

        vote = new Vote();
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        vote.candidate = (e.CurrentSelection[0] as Candidates).Name;
    }

    private async void OnClickEvent(object sender, EventArgs e)
    {
        if (vote.candidate != null)
        {
            await Navigation.PopAsync();
        }
        else
        {
            ErrLabel.Text = "Please select a candidate to submit";
        }
    }
}
}
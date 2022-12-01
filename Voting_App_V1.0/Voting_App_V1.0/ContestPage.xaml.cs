using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Voting_App_V1_0
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContestPage : ContentPage
    {
        public IList<Contest> Contests { get; set; }
        
        //public SQLiteConnection SqlConnect(string sql)
        //{
            ///This is a stub for the SQL connection we would have made to the Candidate registration team for Contests
        //}

        public ContestPage()
        {
            InitializeComponent();

            Contests = new List<Contest>();
            IList<Candidates> c = new List<Candidates>();
            
            c.Add(new Candidates {
                Name = "Alpha Blaster"
            });
            c.Add(new Candidates
            {
                Name = "Playse Holda"
            });
            c.Add(new Candidates {
                Name = "John White"
            });
            c.Add(new Candidates
            {
                Name = "Joe White"
            });
            c.Add(new Candidates
            {
                Name = "Joan White"
            });
            c.Add(new Candidates
            {
                Name = "Walt White"
            });

            Contests.Add(new Contest
            {
                Candidates = c,
                Name = "Homecoming Queen",
                Description = "Apr. 14 - Apr. 24 Vote for this years Homecoming Queen!",
                ImgURL = "https://images.vexels.com/media/users/3/194554/isolated/preview/54aa74f8383906dbde7f2150f9618440-trazo-de-tiara-ligera-de-quincea-ntilde-era-by-vexels.png"

            });

            Contests.Add(new Contest
            {
                Candidates = c,
                Name = "President",
                Description = "Apr 14. - Apr.24 Vote for the new President of the University of South alabama!",
                ImgURL = "https://th.bing.com/th/id/OIP.eLuoEUPXvL5wvKU4hV4GQgHaE7?pid=ImgDet&rs=1"
            });

            Contests.Add(new Contest
            {
                Candidates = c,
                Name = "Department Chair",
                Description = "Apr.14 - June. 14 Vote for the upcoming Department Chair of Computer Science",
                ImgURL = "https://th.bing.com/th/id/R.a7d7f220384b8390719156e65a6703bb?rik=7vx1O5QM28kACQ&riu=http%3a%2f%2fclipartmag.com%2fimages%2fchair-clipart-free-10.png&ehk=q61DQlVLAAOFF5e5Ul4DkIpr%2fq7nbWaAsPR1PE8kR4k%3d&risl=&pid=ImgRaw&r=0"
            });

            IList<Candidates> c1 = new List<Candidates>();
            c1.Add(new Candidates()
            {
                Name = "Yay"
            });
            c1.Add(new Candidates()
            {
                Name = "Nay"
            });

            Contests.Add(new Contest
            {
                Candidates = c1,
                Name = "Pool Table in Shelby Hall?",
                Description = "Apr 14. - July 24th Don't you want to play pool with the ladies?",
                ImgURL = "https://th.bing.com/th/id/R.f7a9af6c2ddc84fdf29456da51489021?rik=eRaWsSE7E5q%2bQg&riu=http%3a%2f%2fcliparts.co%2fcliparts%2f6cp%2foML%2f6cpoMLBzi.gif&ehk=osSvh0%2ffeq5462Ft%2fXIpcw0ULKUitzn4SbWU2GBRcQE%3d&risl=&pid=ImgRaw&r=0"
            });

            BindingContext = this;
        }

        public async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contest selectedItem = e.CurrentSelection[0] as Contest;

            var vpage = new VotingPage1
            {
                BindingContext = selectedItem
            };

            await Navigation.PushAsync(vpage);
        }
    }

}
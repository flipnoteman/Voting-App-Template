using System;
using SQLite;
using System.Text;

using Xamarin.Forms;

namespace Voting_App_V1_0.Models
{
	public class VotingAppV10
    {
        [PrimaryKey, AutoIncrement] 
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
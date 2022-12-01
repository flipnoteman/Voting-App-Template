using System;
using System.Collections.Generic;
using System.Text;

namespace Voting_App_V1_0
{
    public class Candidates
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

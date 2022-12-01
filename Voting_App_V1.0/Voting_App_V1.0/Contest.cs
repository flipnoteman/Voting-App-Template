using System;
using System.Collections.Generic;
using System.Net.Mime;
using Voting_App_V1_0;

public class Contest
{
    public IList<Candidates> Candidates { get; set; }
    public string Name { get; set; }
    public string ImgURL { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return Name;
    }
}

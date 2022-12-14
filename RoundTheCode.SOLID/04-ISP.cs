using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.SOLID.ISP
{
    // INTERFACE SEGREGATION PRINCIPAL

    public interface ITeam
    {
        int BallCount { get; set; }

        // remove and add to wicket interface
        //int WicketCount { get; set; }
    }

    // new interface for WicketCount
    public interface IWicket
    {
        int WicketCount { get; set; }
    }

    public class CricketTeam : ITeam, IWicket
    {
        public string? Name { get; set; }
        public int BallCount { get; set; }
        public int WicketCount { get; set; }
    }

    public class PoolTeam : ITeam 
    {
        public string? Name { get; set; }
        public int BallCount { get; set; }

        // wickets aren't used for the pool team
        //public int WicketCount { get; set;}
    }
}

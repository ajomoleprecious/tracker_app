using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of entries in the matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new();
        /// <summary>
        /// Represents the winner of the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round number of the matchup.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}

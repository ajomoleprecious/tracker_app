using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee of the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of entered teams.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new();
        /// <summary>
        /// Represents the list of prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new();
        /// <summary>
        /// Represents the list of rounds.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new();
    }
}

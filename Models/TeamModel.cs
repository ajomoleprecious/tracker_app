﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the list of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new ();
        /// <summary>
        /// Represents the name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}

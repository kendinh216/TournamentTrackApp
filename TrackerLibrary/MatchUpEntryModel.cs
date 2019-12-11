using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchUpEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came 
        /// from as the winner 
        /// </summary>
        public MatchUpModel ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        /// 
        /// </param>
        public MatchUpEntryModel(double initialScore)
        {
            Console.WriteLine();
        }
    }
}

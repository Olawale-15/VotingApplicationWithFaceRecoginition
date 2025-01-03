﻿namespace VotingApplication.Entities
{
    public class Voters
    {
        public Guid VotersId { get; set; }  
        public required string VotersCardNumber { get; set; }
        public bool HasVoted { get; set; }
        public DateTime VotedAt { get; set; }
        public required string FaceDate { get; set; }    
    }
}

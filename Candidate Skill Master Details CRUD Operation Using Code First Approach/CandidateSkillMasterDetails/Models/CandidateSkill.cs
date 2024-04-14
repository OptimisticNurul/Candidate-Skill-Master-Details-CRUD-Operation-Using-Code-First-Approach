using System.ComponentModel.DataAnnotations.Schema;

namespace CandidateSkillMasterDetails.Models
{
    public class CandidateSkill
    {
        public int CandidateSkillId { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }
        //nev
        public virtual Skill? Skill { get; set; }
        public virtual Candidate? Candidate { get; set; }
    }
}

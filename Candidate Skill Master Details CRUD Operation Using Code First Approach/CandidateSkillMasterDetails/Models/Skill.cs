namespace CandidateSkillMasterDetails.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; } = default!;
        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; } = new List<CandidateSkill>();
    }
}

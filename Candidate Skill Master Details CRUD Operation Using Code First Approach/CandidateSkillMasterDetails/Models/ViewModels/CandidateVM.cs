using System.ComponentModel.DataAnnotations;

namespace CandidateSkillMasterDetails.Models.ViewModels
{
    public class CandidateVM
    {
        public CandidateVM()
        {
            this.SkillList = new List<int>();
        }
        public int CandidateId { get; set; }
        [Required, StringLength(50), Display(Name = "Candidate Name")]
        public string CandidateName { get; set; } = default!;
        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = default!;
        public IFormFile? ImageFile { get; set; }
        public string? Image { get; set; }
        public bool Fresher { get; set; }

        public List<int> SkillList { get; set; }
    }
}

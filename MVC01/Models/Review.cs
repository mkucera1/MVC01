using System.ComponentModel.DataAnnotations;

namespace MVC01.Models
{
    public class Review
    {
        public int ReviewID{ get; set; }
        public virtual Album Album { get; set; }

        public int AlbumID { get; set; }

        public string Contents { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email Address")]
        public string ReviewerEmail { get; set; }
    }
}
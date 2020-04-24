using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models
{
    //POCO = Plain Old CLR/C# Object
    [Table(name: "Zanbil")]
    public class Blog
    {
        public Blog()
        {
            CreatedDateTime = System.DateTime.Now;
            UniqueID = System.Guid.NewGuid();
        }

        //public int BlogID { get; set; }

        //[Key]
        //[Column(Order=1)]
        //public int PrimaryTrackingKey { get; set; }

        //[Column(Order = 2)]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ID { get; set; }
        
        [Key]
        public System.Guid UniqueID { get; set; }



        [Column(name: "Shalgham", TypeName = "NTEXT", Order = 3)]
        [Required(ErrorMessage = "فیلد تیتر الزامی است")]
        [MaxLength(50)]
        [Display(Name = "تیتر")]
        public string Title { get; set; }



        [Column(name: "Sibzamini", Order = 1)]
        [MinLength(10), MaxLength(30)]
        public string BloggerName { get; set; }



        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(Order = 5)]
        public DateTime CreatedDateTime { get; set; }
        //public DateTime? CreatedDateTime { get; set; }



        [StringLength(maximumLength: 30, MinimumLength = 10)]
        [Column(Order = 6)]
        public string Description { get; set; }



        [Timestamp]
        [Column(Order = 4)]
        public Byte[] TimeStamp { get; set; }



        //public BlogDetails BlogDetails { get; set; }



        //public DateTime? CreatedDateTime { get; set; }


        [NotMapped]
        public TimeSpan Age
        {
            get
            {
                return System.DateTime.Now - CreatedDateTime;
            }
        }
    }
}
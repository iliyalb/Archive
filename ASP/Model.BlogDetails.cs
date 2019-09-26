using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Models
{
    [ComplexType]
    public class BlogDetails
    {
        public DateTime? CreatedDateTime { get; set; }

        [StringLength(maximumLength: 30, MinimumLength=10)]
        public string Description { get; set; }
        
        [Timestamp]
        public Byte[] TimeStamp { get; set; }
    }
}
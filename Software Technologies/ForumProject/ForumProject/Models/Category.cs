using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForumProject.Models
{
    public class Category
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(1500)]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        
    }
}
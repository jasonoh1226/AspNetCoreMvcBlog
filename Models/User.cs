using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMvcBlog.Models
{
    public class User 
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserName { get; set; }
    }
}
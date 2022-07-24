using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Models.Entites
{
    public class Album
    {

        // infromation provided from Url 
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; } = string.Empty;
    }
}

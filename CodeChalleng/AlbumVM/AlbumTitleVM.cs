using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Album.Models
{
    public class AlbumTitleVM
    {
        public AlbumTitleVM()
        {
        }

        // The title is the only infromation i need to passback to user. 
        public AlbumTitleVM(Entites.Album src)
        {
            Title = src.Title;
        }
        public string Title { get; set; }
    }
}

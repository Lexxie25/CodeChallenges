using Album.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor.Repository.Interfaces
{
    public interface IProcessorAlbum
    {
        Task<List<AlbumTitleVM>> LoadInfo(string search);
    }
}

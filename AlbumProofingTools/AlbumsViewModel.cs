using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AlbumProofingTools.Models;

namespace AlbumProofingTools
{

    public class AlbumsViewModel
    {
        public ObservableCollection<Album> LoadedAlbums  = new ObservableCollection<Album>();
      
        public AlbumsViewModel()
        {
            LoadedAlbums = new ObservableCollection<Album>();
        }


    }
}
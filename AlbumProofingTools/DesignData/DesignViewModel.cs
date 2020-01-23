using System;
using AlbumProofingTools.Models;

namespace AlbumProofingTools.DesignData
{
    public class DesignViewModel:MainViewModel
    {
       public DesignViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                var Album = new Album($"Album {i + 1}", DateTime.Now, 1);
                Album.ProcessProgress = new Progress();
                Album.ProcessProgress.ProgressValue = i * 5 > 100 ? 100 : i * 5;
                Album.ProcessProgress.ProgressInfo = $"Wysyłanie pliku {(i*3)+1}/15";
                Album.SetStatus(AlbumStatus.Idle);
                LoadedAlbums.Add(Album);
            }
            LoadedAlbums[1].SetStatus(AlbumStatus.Processing);
            LoadedAlbums[0].SetStatus(AlbumStatus.EditingProcessing);

            var editingAlbum = LoadedAlbums[0];
            for (int i = 0; i < 10; i++)
            {
                editingAlbum.Spreads.Add(new Spread()
                {
                    Title = $"Rozkładówka_{i+1}.jpg"
                });
            }

            for (int i = 0; i < 3; i++)
            {
                editingAlbum.Spreads[i].Status = SpreadStatus.Loaded;
            }
            editingAlbum.ProcessProgress.ProgressInfo = $"Wczytywanie pliku 3/15";
            editingAlbum.ProcessProgress.ProgressValue = 30;
        }
    }
}
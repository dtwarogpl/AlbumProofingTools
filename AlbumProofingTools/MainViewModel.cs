using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using AlbumProofingTools.Models;

namespace AlbumProofingTools
{
    public class MainViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Album> LoadedAlbums { get;protected  set; }

        public string Dupa => "Treść dupa";

        public MainViewModel()
        {
            LoadedAlbums = new ObservableCollection<Album>();
        }

        

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
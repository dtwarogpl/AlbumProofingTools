using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AlbumProofingTools.Annotations;

namespace AlbumProofingTools.Models
{
    

    public class Album:INotifyPropertyChanged
    {
        public Album(string name, DateTime lastModTime, int commentsCount)
        {
            Name = name;
            LastModTime = lastModTime;
            CommentsCount = commentsCount;
            Spreads = new ObservableCollection<Spread>();
            Status = AlbumStatus.Idle;
        }

        public ObservableCollection<Spread> Spreads { get; set; }

        private Progress _processProgress;
        public Progress ProcessProgress
        {
            get => _processProgress;
            set
            {
                if (Equals(value, _processProgress)) return;
                _processProgress = value;
                OnPropertyChanged();
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        private DateTime _lastModTime;

        public DateTime LastModTime
        {
            get => _lastModTime;
            set
            {
                if (value.Equals(_lastModTime)) return;
                _lastModTime = value;
                OnPropertyChanged();
            }
        }

        private int _commentsCount;

        public int CommentsCount
        {
            get => _commentsCount;
            set
            {
                if (value == _commentsCount) return;
                _commentsCount = value;
                OnPropertyChanged();
            }
        }

        private int _spreadsCount;

        public int SpreadsCount
        {
            get => _spreadsCount;
            set
            {
                if (value == _spreadsCount) return;
                _spreadsCount = value;
                OnPropertyChanged();
            }
        }

        private AlbumStatus _status;

        public AlbumStatus Status
        {
            get => _status;
            protected set
            {
                if (value == _status) return;
                _status = value;
                OnPropertyChanged();
            }
        }

        public void SetStatus(AlbumStatus status)
        {
            Status = status;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
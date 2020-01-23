using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using AlbumProofingTools.Annotations;

namespace AlbumProofingTools.Models
{
    public class Spread:INotifyPropertyChanged
    {
        private string _title;
        private SpreadStatus _status;
        private FileInfo SourceFile { get; set; }

        public SpreadStatus Status

        {
            get { return _status; }
            set
            {
                if (value == _status) return;
                _status = value;
                OnPropertyChanged();
            }
        }

        public Spread()
        {
            Status = SpreadStatus.Raw;
        }

        public string Title
        {
            get => _title;
            set
            {
                if (value == _title) return;
                _title = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayName));
            }
        }


        public String DisplayName => string.IsNullOrWhiteSpace(Title) ? SourceFile.Name : Title;


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
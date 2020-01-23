using System.ComponentModel;
using System.Runtime.CompilerServices;
using AlbumProofingTools.Annotations;

namespace AlbumProofingTools
{
    public enum AlbumStatus
    {
        Idle,
        Selected,
        Processing,
        Editing,
        EditingProcessing,
    }

    public enum SpreadStatus
    {
        Raw,
        Loaded
    }

    public class Progress:INotifyPropertyChanged {
        private string _progressInfo;
        private int _progressValue;

        public string ProgressInfo
        {
            get => _progressInfo;
            set
            {
                if (value == _progressInfo) return;
                _progressInfo = value;
                OnPropertyChanged();
            }
        }

        public int ProgressValue
        {
            get => _progressValue;
            set
            {
                if (value == _progressValue) return;
                _progressValue = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
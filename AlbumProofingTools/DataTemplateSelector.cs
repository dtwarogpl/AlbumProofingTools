using System;
using System.Windows;
using System.Windows.Controls;
using AlbumProofingTools.Models;

namespace AlbumProofingTools
{
    public class AlbumListDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate
            SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is Album)
            {
                Album album = item as Album;

                switch (album.Status)
                {
                    case AlbumStatus.Idle:
                    case AlbumStatus.Selected:
                    case AlbumStatus.Processing:
                      return  element.FindResource("DefaultAlbumTemplate") as DataTemplate;
                    case AlbumStatus.Editing:
                        case AlbumStatus.EditingProcessing:
                       return element.FindResource("EditingAlbumTemplate") as DataTemplate;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return null;
        }
    }
}
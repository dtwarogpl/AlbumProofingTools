using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using AlbumProofingTools.Models;

namespace AlbumProofingTools
{
    public class Helpers
    {
        
    }

    public class RowToIndexConverter : MarkupExtension, IValueConverter
    {
        static RowToIndexConverter converter;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DataGridRow row = value as DataGridRow;
            if (row != null)
                return row.GetIndex()+1;
            else
                return -1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (converter == null) converter = new RowToIndexConverter();
            return converter;
        }

        public RowToIndexConverter()
        {
        }
    }

    //public class AlbumListDataTemplateSelector : DataTemplateSelector
    //{
    //    public override DataTemplate
    //        SelectTemplate(object item, DependencyObject container)
    //    {
    //        FrameworkElement element = container as FrameworkElement;

    //        if (element != null && item != null && item is Album)
    //        {
    //            Album album = item as Album;


    //            if (album.Status == Album.AlbumStatus.Selected)
    //                return element.FindResource("SelectedAlbumTemplate") as DataTemplate;

    //            return element.FindResource("DefaultAlbumTemplate") as DataTemplate;
    //        }
    //        return null;

    //    }
    //}
}
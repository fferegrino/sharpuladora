using System;
using Xamarin.Forms;

namespace Sharpuladora.Pages
{
    public class CalcPage : ContentPage
    {
        Grid _gridLayout;
        
        public CalcPage()
        {
            _gridLayout = CreateGridLayout();
            
            Content = _gridLayout;
        }
        
        
        private Grid CreateGridLayout()
        {
            var layout = new Grid();
            layout.HorizontalOptions = LayoutOptions.StartAndExpand;
            layout.VerticalOptions = LayoutOptions.StartAndExpand;

            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            
            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            return layout;
        }
    }
}

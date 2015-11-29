using System;
using Xamarin.Forms;

namespace Sharpuladora.Pages
{
    public class CalcPage : ContentPage
    {
        Grid _layout;
        
        Button _b0, _b1, _b2, _b3, _b4, _b5, _b6, _b7;
        Button _calculateBtn, _plusBtn, _minusBtn, _clearBtn;
        Label _resultDisplay;
        
        public CalcPage()
        {
            _layout = CreateGridLayout();

            CreateUiElements();
            
            Content = _layout;
        }

        private void CreateUiElements()
        {
            _resultDisplay = new Label
            {
                FontSize = 40,
                Text = "0"
            };
            Grid.SetColumnSpan(_resultDisplay, 4);
            _layout.Children.Add(_resultDisplay);

            #region Numeric buttons

            _b0 = new Button { Text = "0" };
            Grid.SetColumn(_b0, 1);
            Grid.SetRow(_b0, 4);
            _layout.Children.Add(_b0);

            _b1 = new Button { Text = "1" };
            Grid.SetColumn(_b1, 0);
            Grid.SetRow(_b1, 3);
            _layout.Children.Add(_b1);

            _b2 = new Button { Text = "2" };
            Grid.SetColumn(_b2, 1);
            Grid.SetRow(_b2, 3);
            _layout.Children.Add(_b2);

            _b3 = new Button { Text = "3" };
            Grid.SetColumn(_b3, 2);
            Grid.SetRow(_b3, 3);
            _layout.Children.Add(_b3);

            // TODO: add missing buttons

            #endregion

            #region Control buttons

            _calculateBtn = new Button { Text = "=" };
            Grid.SetColumn(_calculateBtn, 3);
            Grid.SetRow(_calculateBtn, 4);
            _layout.Children.Add(_calculateBtn);

            _clearBtn = new Button { Text = "C" };
            Grid.SetColumn(_clearBtn, 3);
            Grid.SetRow(_clearBtn, 1);
            _layout.Children.Add(_clearBtn);

            // TODO: add missing buttons
            
            #endregion
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

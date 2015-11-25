using System;
using Xamarin.Forms;

namespace Sharpuladora.Pages
{
    public class CalcPage : ContentPage
    {
        Grid _gridLayout;
        Button _b0, _b1, _b2, _b3, _b4, _b5, _b6, _b7;
        Button _igualBtn, _masBtn, _menosBtn, _borrarBtn;
        Label _displayResultado;

        string primerNumero;
        string segundoNumero;
        string resultado;
        string operador;

        public CalcPage()
        {
            _gridLayout = CreateGridLayout();

            CreateUiElements();

            WireEvents();


            // Trick to make our calculater fullscreen
            var relativeLayout = new RelativeLayout();
            relativeLayout.Children.Add(_gridLayout, // <= Original layout
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent(p => p.Width),
                Constraint.RelativeToParent(p => p.Height));
            Content = relativeLayout;
        }

        private void WireEvents()
        {
            _b0.Clicked += OnNumericButtonClicked;
            _b1.Clicked += OnNumericButtonClicked;
            _b2.Clicked += OnNumericButtonClicked;
            _b3.Clicked += OnNumericButtonClicked;

            _igualBtn.Clicked += OnControlButtonClicked;

            _borrarBtn.Clicked += OnClearButtonClicked;
        }

        #region Events

        void OnClearButtonClicked(object sender, EventArgs e)
        {
            primerNumero = "";
            segundoNumero = "";
            operador = "";
        }

        private void OnControlButtonClicked(object sender, EventArgs e)
        {
            Button botonClickeado = (Button)sender;
            string operador = botonClickeado.Text;
            if (operador == "=")
            {
                int r = 0;
                // Acá va la calculadora
                _displayResultado.Text = "R:" + r;
            }
            else
            {
                // Otro operador
            }
        }

        void OnNumericButtonClicked(object sender, EventArgs e)
        {
            Button botonClickeado = (Button)sender;
            if (primerNumero == null || primerNumero == "")
            {
                primerNumero = botonClickeado.Text;
            }
            else
            {
                segundoNumero = botonClickeado.Text;
            }
        }

        #endregion

        private void CreateUiElements()
        {
            _displayResultado = new Label
            {
                FontSize = 40,
                Text = "0"
            };
            Grid.SetColumnSpan(_displayResultado, 4);
            _gridLayout.Children.Add(_displayResultado);

            #region Numeric buttons

            _b0 = new Button { Text = "0" };
            Grid.SetColumn(_b0, 1);
            Grid.SetRow(_b0, 4);
            _gridLayout.Children.Add(_b0);

            _b1 = new Button { Text = "1" };
            Grid.SetColumn(_b1, 0);
            Grid.SetRow(_b1, 3);
            _gridLayout.Children.Add(_b1);

            _b2 = new Button { Text = "2" };
            Grid.SetColumn(_b2, 1);
            Grid.SetRow(_b2, 3);
            _gridLayout.Children.Add(_b2);

            _b3 = new Button { Text = "3" };
            Grid.SetColumn(_b3, 2);
            Grid.SetRow(_b3, 3);
            _gridLayout.Children.Add(_b3);

            // TODO: add missing buttons

            #endregion

            #region Control buttons

            _igualBtn = new Button { Text = "=" };
            Grid.SetColumn(_igualBtn, 3);
            Grid.SetRow(_igualBtn, 4);
            _gridLayout.Children.Add(_igualBtn);

            _borrarBtn = new Button { Text = "C" };
            Grid.SetColumn(_borrarBtn, 3);
            Grid.SetRow(_borrarBtn, 1);
            _gridLayout.Children.Add(_borrarBtn);

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

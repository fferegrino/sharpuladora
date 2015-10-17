using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Calculadora.Pages
{
    public class CalculadoraPage : ContentPage
    {
        Grid grid;
        Button b0, b1, b2, b3, b4, b5, b6, b7;
        Button botonIgual, botonMas, botonMenos, botonBorrar;
        Label display;

        string primerNumero;
        string segundoNumero;
        string resultado;
        string operador;

        public CalculadoraPage()
        {
            grid = new Grid();
            grid.HorizontalOptions = LayoutOptions.StartAndExpand;
            grid.VerticalOptions = LayoutOptions.StartAndExpand;

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });


            display = new Label
            {
                FontSize = 40,
                Text = "0"
            };
            Grid.SetColumnSpan(display, 4);
            grid.Children.Add(display);

            b0 = new Button { Text = "0" };
            b0.Clicked += BotonNumerico_Clicked;
            Grid.SetColumn(b0, 1);
            Grid.SetRow(b0, 4);
            grid.Children.Add(b0);
            
            b1 = new Button { Text = "1" };
            b1.Clicked += BotonNumerico_Clicked;
            Grid.SetColumn(b1, 0);
            Grid.SetRow(b1, 3);
            grid.Children.Add(b1);

            b2 = new Button { Text = "2" };
            b2.Clicked += BotonNumerico_Clicked;
            Grid.SetColumn(b2, 1);
            Grid.SetRow(b2, 3);
            grid.Children.Add(b2);

            b3 = new Button { Text = "3" };
            b3.Clicked += BotonNumerico_Clicked;
            Grid.SetColumn(b3, 2);
            Grid.SetRow(b3, 3);
            grid.Children.Add(b3);

            botonIgual = new Button { Text = "=" };
            botonIgual.Clicked += BotonOperador_Clicked;
            Grid.SetColumn(botonIgual, 3);
            Grid.SetRow(botonIgual, 4);
            grid.Children.Add(botonIgual);

            botonBorrar = new Button { Text = "C" };
            botonBorrar.Clicked += BotonBorrar_Clicked;
            Grid.SetColumn(botonBorrar, 3);
            Grid.SetRow(botonBorrar, 1);
            grid.Children.Add(botonBorrar);

            // Truco para que la calculadora use toda la pantalla del celular :B
            var relativeLayout = new RelativeLayout();
            relativeLayout.Children.Add(grid,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent(p => p.Width),
                Constraint.RelativeToParent(p => p.Height));
            Content = relativeLayout;
        }

        void BotonBorrar_Clicked(object sender, EventArgs e)
        {
            primerNumero = "";
            segundoNumero = "";
            operador = "";
        }

        private void BotonOperador_Clicked(object sender, EventArgs e)
        {
            Button botonClickeado = (Button)sender;
            string operador = botonClickeado.Text;
            if (operador == "=")
            {
                int r = 0;
                // Acá va la calculadora
                display.Text = "R:" + r;
            }
            else
            {
                // Otro operador
            }
        }

        void BotonNumerico_Clicked(object sender, EventArgs e)
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

        

    }
}

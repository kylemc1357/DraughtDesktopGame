using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Diagnostics;

namespace DraughtDesktopGame
{
    public partial class MainPage : ContentPage
    {
        private const int GridSize = 8;
        private readonly Color lightColor = Colors.Red;
        private readonly Color darkColor = Colors.Green;

        public int BoardGridSize => GridSize;

        public MainPage()
        {
            InitializeComponent();
            CreateDraughtsBoard();
        }

        private void CreateDraughtsBoard()
        {
            DraughtsGrid.RowDefinitions.Clear();
            DraughtsGrid.ColumnDefinitions.Clear();

            for (int i = 0; i < GridSize; i++)
            {
                DraughtsGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(80) });
                DraughtsGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(80) });
            }

            for (int row = 0; row < GridSize; row++)
            {
                for (int col = 0; col < GridSize; col++)
                {
                    var boxView = new BoxView   //simple element to represent a square - can set colour etc
                    {
                        Color = (row + col) % 2 == 0 ? lightColor : darkColor,
                        InputTransparent = false  //allows to detect clicks, didnt workt without this 
                    };

                    boxView.SetValue(Grid.RowProperty, row);
                    boxView.SetValue(Grid.ColumnProperty, col);

                    var tapGesture = new TapGestureRecognizer();  //used to detect clicks on an individual box
                    tapGesture.Tapped += OnSquareTapped;
                    boxView.GestureRecognizers.Add(tapGesture);

                    Grid.SetRow(boxView, row);
                    Grid.SetColumn(boxView, col);
                    DraughtsGrid.Children.Add(boxView);
                }
            }
        }

        private async void OnSquareTapped(object sender, EventArgs e)
        {
            if (sender is BoxView boxBeenTapped)
            {
                int row = (int)boxBeenTapped.GetValue(Grid.RowProperty);
                int col = (int)boxBeenTapped.GetValue(Grid.ColumnProperty);

                await DisplayAlert("Test", $"Tapped square at row {row}, column {col}", "close");
            }
        }
    }
}

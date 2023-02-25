using Mapsui.UI.Maui;
using static Microsoft.Maui.ApplicationModel.Permissions;
using SkiaSharp.Views.Maui.Controls.Hosting;
namespace MapsUITest;

public partial class MainPage : ContentPage
{
        public MainPage()
        {
		InitializeComponent();
                var mapControl = new MapControl();
                mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
                Content = mapControl;
        }
}


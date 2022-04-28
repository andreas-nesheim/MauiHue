using Q42.HueApi.Interfaces;
using Q42.HueApi;

namespace MauiHue;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        var bridgeIP = "XXX.XXX.XX.XX";
        var appKey = "abcdefghijklmnopqrstuvwxyz1234567890";

        ILocalHueClient client = new LocalHueClient(bridgeIP);
        client.Initialize(appKey);

        var command = new LightCommand { Alert = Alert.Once };
        await client.SendCommandAsync(command);
    }
}


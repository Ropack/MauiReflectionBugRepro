using System.Reflection;

namespace MauiReflectionBugRepro;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
    {
        var properties = typeof(Foo).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        CounterBtn.Text = $"Type {nameof(Foo)} has {properties.Length} properties.";
	}
}


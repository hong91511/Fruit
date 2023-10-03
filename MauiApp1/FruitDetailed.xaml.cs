namespace MauiApp1;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string fruitName, string fruitImage, string fruitDescriptiion)
	{
		InitializeComponent();
		showName.Text = fruitName;
		showImage.Source = fruitImage; 
		showDescription.Text = fruitDescriptiion;
	}
}
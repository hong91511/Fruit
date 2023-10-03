namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            List<Fruit> list = new List<Fruit>()
            {
                new Fruit() {Name="Apple", ImageUrl="apple.png", Description="This is an Apple"},
                new Fruit() {Name="Orange", ImageUrl="orange.png", Description="This is an Orange"},
                new Fruit() {Name="Banana", ImageUrl="banana.png", Description="This is an Banana"},
                new Fruit() {Name="Kiwi", ImageUrl="kiwi.png", Description="This is an Kiwi"},
                new Fruit() {Name="Strawberry", ImageUrl="strawberry.png", Description="This is an Strawberry"},
                new Fruit() {Name="Pineapple", ImageUrl="pineapple.png", Description="This is an Pineapple"},
                new Fruit() {Name="Watermelon", ImageUrl="watermelon.png", Description="This is an watermelon"},
                new Fruit() {Name="Grapes", ImageUrl="grape.png", Description="This is an Grapes"},
            };
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }


        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.ImageUrl, selectedItem.Description));
        }
    }
}
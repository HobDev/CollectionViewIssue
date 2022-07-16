using ItemsView = Microsoft.Maui.Controls.ItemsView;

namespace CollectionViewIssue;

public partial class MainPage : ContentPage
{

    MainViewModel viewModel;
    public MainPage()
    {
        InitializeComponent();
        viewModel = new MainViewModel();
        CollectionView collection = new CollectionView();

        collection.SelectionMode = SelectionMode.Multiple;
        collection.ItemSizingStrategy = ItemSizingStrategy.MeasureFirstItem;
        collection.ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
        {
            ItemSpacing = 5
        };
        collection.SetBinding(ItemsView.ItemsSourceProperty, "AllGames", BindingMode.OneTime);

        DataTemplate interestsTemplate = new DataTemplate(() =>
{

    Button button = new Button { CornerRadius = 10, BackgroundColor = Colors.LightGray, TextColor = Colors.DarkGrey };
    button.SetBinding(Button.TextProperty, "Name");
    return button;


    //Label label = new Label();
    //Border border = new Border
    //{
    //    Background = Colors.LightGray,
    //    StrokeThickness = 0,
    //    Padding = new Thickness(8, 4),
    //    HorizontalOptions = LayoutOptions.Fill,
    //    StrokeShape = new RoundRectangle { CornerRadius = new CornerRadius(20) },
    //    Content = label
    //};
    //label.SetBinding(Label.TextProperty, "Name");
    //return border;

});
        collection.ItemTemplate = interestsTemplate;
        collection.SetBinding(SelectableItemsView.SelectionChangedCommandProperty, "GameSelectedCommand");
        Content = collection;



        BindingContext = viewModel;
    }


}



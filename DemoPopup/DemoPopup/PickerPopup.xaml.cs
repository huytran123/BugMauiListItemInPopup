using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;

namespace DemoPopup;

public partial class PickerPopup : BaseBottomPopup
{
    public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();
    public PickerPopup()
    {
        InitializeComponent();
        for (var i = 0; i < 100; ++i)
        {
            Items.Add($"Test {i}");
        }
        BindingContext = this;

    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        this.CloseAsync();
    }
}

namespace DemoPopup;

public partial class BaseBottomPopup : BasePopup
{
    public View PopupView
    {
        get => ContentViewPopup.Content;
        set => ContentViewPopup.Content = value;
    }
    public BaseBottomPopup():base("")
	{
		InitializeComponent();
	}
}

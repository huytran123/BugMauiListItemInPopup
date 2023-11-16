using System;
using System.Runtime.CompilerServices;

namespace DemoPopup;

public class BasePopup : CommunityToolkit.Maui.Views.Popup
{
    public string PopupTitle { get; set; }

    public BasePopup(string title) : base()
    {
        this.PopupTitle = title;
        Color = Color.FromArgb("#00000000");
    }


    #region INotifyPropertyChanged
    protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action onChanged = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
            return false;

        backingStore = value;
        onChanged?.Invoke();
        OnPropertyChanged(propertyName);
        return true;
    }
    #endregion
}

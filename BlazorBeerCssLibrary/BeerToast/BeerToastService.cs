namespace BlazorBeerCssLibrary.BeerToast;

public class BeerToastService
{
    public ToastType ToastType {get; private set;}
    public string ToastMessage { get; private set; } = "";
    public string Icon { get; private set; } = "";
    public void ShowToast(ToastType toastType, string toastMessage, string icon = "")
    {
        ToastType = toastType;
        ToastMessage = toastMessage;
        Icon = icon;
        NotifyStateChanged();
    }

    public event Action OnChange;
    private void NotifyStateChanged() => OnChange?.Invoke();
}

public enum ToastType
{
    Primary,
    Error,
    Success,
}

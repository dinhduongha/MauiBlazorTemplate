using MauiBlazor.UI.Core.Interfaces;

namespace MeWe.UI.Mobile.Services;
public class PlatformService : IPlatformService
{
    public string GetPlatformName() => DeviceInfo.Current.Platform.ToString();
}

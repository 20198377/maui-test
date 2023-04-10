using Microsoft.JSInterop;
using System.Diagnostics;

namespace phis_ievents_offline.Data
{
    public interface ICameraInterop
    {
        Task CaptureAsync();
    }

    public class CameraInterop : InteropBase, ICameraInterop
    {
        public CameraInterop(IJSRuntime jsRuntime) : base($"./js/hello.js", jsRuntime)
        {
        }

        [JSInvokable]
        public async Task CaptureAsync()
        {
            try
            {

                var module = await Module;
                await module.InvokeVoidAsync("helloWorld", "true");
                await module.InvokeVoidAsync("capture");

                Debug.WriteLine("-");
            }
            catch (Exception ex)
            {

            }
        }
    }
}

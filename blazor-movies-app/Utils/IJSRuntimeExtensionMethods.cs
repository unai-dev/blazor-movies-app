using blazor_movies_app.Entities;
using Microsoft.JSInterop;

namespace blazor_movies_app.Utils
{
    public static class IJSRuntimeExtensionMethods
    {
        public async static ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            return await jSRuntime.InvokeAsync<bool>("confirm", message);
        }
    }
}

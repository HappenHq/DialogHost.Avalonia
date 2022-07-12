using Avalonia.ReactiveUI;
using Avalonia.Web.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Avalonia;
using ReactiveUI;
using System.Web;

namespace DialogHostDemo.Web
{
    public partial class App
    {
        protected override void OnParametersSet()
        {
            try
            {
                WebAppBuilder.Configure<DialogHostDemo.App>()
                    .UseReactiveUI()
                    .SetupWithSingleViewLifetime();

                // Blazor is currently single-threaded, and ReactiveUI should be smart enough to do the right thing
                // when invoked with RxApp.TaskpoolScheduler in Blazor, but it appears there are still some bugs
                // in there. We'll try to avoid them by overriding the RxApp.TaskpoolScheduler scheduler here.
                RxApp.TaskpoolScheduler = RxApp.MainThreadScheduler;
            }
            finally
            {

            }

            base.OnParametersSet();
        }
    }

}



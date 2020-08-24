using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace firstBlazorApp.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        [Inject] IJSRuntime js { get; set; }
        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }

        [JSInvokable]
        public void IncrementCount()
        {
            this.currentCount++;
            singleton.Value = this.currentCount;
            transient.Value = this.currentCount;
            currentCountStatic++;
        }

        public async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync(
                "dotNetInstanceInvocation",
                DotNetObjectReference.Create(this)
            );
        }
    }
}
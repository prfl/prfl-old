using System;
using System.Text.Json;
using System.Threading.Tasks;
using Profile.Models;
using Microsoft.JSInterop;
using System.Net.Http;

namespace Profile.Services
{
    public class VisitorClick
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly HttpClient _client;
        public VisitorClick(IJSRuntime jsRuntime, HttpClient client)
        {
            _jsRuntime = jsRuntime;
            _client = client;
        }
        
        public event Action OnChange;
        public Visitor OldVisitor { get; set; }
        public VisitorState VisitorState { get; set; }
        public Click Click { get; set; }

        public async Task SetVisitorAsync(string page, string userId)
        {
            // Check if Old visitor exists and assign if it does
            OldVisitor = await VisitorState.GetOldVisitorAsync();

            // If the user is a new visitor
            if(OldVisitor == null){
                //Create a new visitor
                await VisitorState.CreateVisitor(page);
            }

            NotifyClickChanged();
        }

        private void NotifyClickChanged() => OnChange?.Invoke();
    }
}

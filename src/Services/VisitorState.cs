using System;
using System.Text.Json;
using System.Threading.Tasks;
using Profile.Models;
using Microsoft.JSInterop;


namespace Profile.Services
{
    public class VisitorState
    {
        private readonly IJSRuntime _jsRuntime;
        public VisitorState(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public Visitor Visitor { get; set; }
        public Visitor OldVisitor { get; set; }
        public string Id { get; set; }
        public bool VisitorIsNew { get; set; }
        public static string SessionValue { get; set; }
        

        public event Action OnChange;

        public async Task SetVisitorAsync(string page)
        {
            

            // Check if there is already a visitor stored in local storage
            await GetOldVisitorAsync();

            // If no visitor is stored in local storage
            // Or the visitor was 1 hour ago
            // Created a new visitor
            if(OldVisitor == null) {
                await CreateVisitor(page, "");
            }

            NotifyStateChanged();
        }

        public async Task<Visitor> GetOldVisitorAsync() {
            
            var visitorId = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "prfl-visitorId");
            var visitedOn = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "prfl-visitedOn");
            var page = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "prfl-page");

            if(!String.IsNullOrEmpty(visitorId)) {
                OldVisitor = new Visitor(){
                VisitorId = visitorId,
                VisitedOn = DateTime.Now,
                Page = page,
            };

                VisitorIsNew = false;
            } 
            return OldVisitor;
        }

        // Create new visitor in local storage
        public async Task CreateVisitor(string page, string linkId = "") {
            
            // Set the visitor as New
            VisitorIsNew = true;

            Guid g = Guid.NewGuid();

            // Create new Visitor profile
            Id = g.ToString();
            Visitor = new Visitor(){
                VisitorId = Id,
                VisitedOn = DateTime.Now,
                Page = page,
            };

            await _jsRuntime.InvokeAsync<string>("setVisitor", new 
            { 
                key =  Visitor.Key, 
                visitorId = Visitor.VisitorId, 
                visitedOn = Visitor.VisitedOn, 
                page = page
            });
        }

        // Update existing visitor in session storage
        public Visitor UpdateOldVisitorAsync(DateTime visitedOn, string page) {
            OldVisitor.VisitedOn = DateTime.Now;
            OldVisitor.Page = page;
            return OldVisitor;
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

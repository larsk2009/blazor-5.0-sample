using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazoredDemo.Pages
{
    public partial class Index
    {

        [Inject]
        Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }

        string UserAgent { get; set; }
        string IPAddress { get; set; }
        string ServerUrl { get; set; }

        protected override async Task OnInitializedAsync()
        {

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                UserAgent = await localStorage.GetItemAsync<string>("UserAgent");
                ServerUrl = await localStorage.GetItemAsync<string>("ServerUrl");
                IPAddress = await localStorage.GetItemAsync<string>("IPAddress");
            }


            StateHasChanged();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.Modal.Services;
using BlazoredDemo.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazoredDemo.Pages
{
    public partial class Counter
    {

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; }

        [CascadingParameter]
        public IModalService Modal { get; set; }

        string ADMINISTRATION_ROLE = "Administrator";
        System.Security.Claims.ClaimsPrincipal CurrentUser;

        protected int currentCount = 0;


        protected override async Task OnInitializedAsync()
        {

            // Get the current logged in user
            if(authenticationStateTask != null)
                CurrentUser = (await authenticationStateTask).User;

        }

        private void IncrementCount()
        {
            currentCount++;
        }

        protected void ShowModal()
        {
            Modal.Show<Confirm>("Welcome to Blazored Modal");
        }
    }
}

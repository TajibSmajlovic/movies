using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Pages.Persons
{
    public partial class CreatePerson
    {
        [Inject] private NavigationManager navigationManager { get; set; }
    }
}
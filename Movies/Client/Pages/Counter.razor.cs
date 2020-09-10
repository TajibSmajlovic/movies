using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        [JSInvokable]
        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
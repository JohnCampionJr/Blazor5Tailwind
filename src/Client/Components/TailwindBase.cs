﻿using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

namespace Blazor5Tailwind.Client.Components
{
    public class TailwindBase : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Class { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; }
    }
}

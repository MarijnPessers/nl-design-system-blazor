﻿using Blazor.NLDesignSystem.Extensions;
using Microsoft.AspNetCore.Components;

namespace Blazor.NLDesignSystem.Components
{
    public partial class NldsNavigation
    {
        [Parameter]
        public Color? Color { get; set; }
        [Parameter]
        public bool IsSideNavigation { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private string DisplayColor => Color.GetDescription<StyleAttribute>();
        private bool UseColor => Color != null;
    }
}
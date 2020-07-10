﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Blazor.NLDesignSystem.Components.Form
{
    public partial class NldsInputHint
    {
        [CascadingParameter(Name = "InputIdentifier")]
        public string InputIdentifier { get; set; }

        /// <summary>
        /// Optional; if it is encapsulated in an input the cascading value (InputName) is taken over this value
        /// </summary>
        [Parameter]
        public string HintName { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private IDictionary<string, object> GetAttributes()
        {
            var attributes = new Dictionary<string, object>();

            var tagId = (!string.IsNullOrWhiteSpace(InputIdentifier) ? $"hint_{InputIdentifier}" : null) ?? HintName ?? string.Empty;
            if (tagId != string.Empty)
            {
                attributes["id"] = tagId;
            }

            return attributes;
        }
    }
}

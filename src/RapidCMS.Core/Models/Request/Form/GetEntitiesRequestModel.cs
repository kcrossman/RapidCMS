﻿using RapidCMS.Core.Abstractions.Data;
using RapidCMS.Core.Enums;

namespace RapidCMS.Core.Models.Request.Form
{
    public class GetEntitiesRequestModel
    {
        public UsageType UsageType { get; set; }
        public string CollectionAlias { get; set; } = default!;
        public string VariantAlias { get; set; } = default!;
        public IQuery Query { get; set; } = default!;
    }
}

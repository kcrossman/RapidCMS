﻿using System;
using System.Collections.Generic;
using RapidCMS.Core.Abstractions.Metadata;

namespace RapidCMS.Core.Abstractions.Data
{
    public interface IRelation
    {
        Type RelatedEntityType { get; }
        IPropertyMetadata Property { get; }
        IReadOnlyList<IElement> RelatedElements { get; }
        IReadOnlyList<T> RelatedElementIdsAs<T>();
    }
}

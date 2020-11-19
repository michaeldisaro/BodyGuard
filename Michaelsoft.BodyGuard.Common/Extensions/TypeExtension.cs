﻿using System;
using System.Linq;
using System.Reflection;
using Michaelsoft.BodyGuard.Common.Attributes;

namespace Michaelsoft.BodyGuard.Common.Extensions
{
    public static class TypeExtension
    {

        public static PropertyInfo[] GetNonExcludedProperty(this Type objectType)
        {
            return objectType.GetProperties()
                             .Where(p =>
                                        p.CustomAttributes
                                         .All(a => a.AttributeType != typeof(ExcludeFromForm)))
                             .ToArray();
        }

    }
}
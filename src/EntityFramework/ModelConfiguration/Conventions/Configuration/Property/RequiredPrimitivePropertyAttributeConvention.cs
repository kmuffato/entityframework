// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.ModelConfiguration.Conventions
{
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
    using System.Data.Entity.Utilities;
    using System.Reflection;

    /// <summary>
    ///     Convention to process instances of <see cref="RequiredAttribute" /> found on primitive properties in the model.
    /// </summary>
    public class RequiredPrimitivePropertyAttributeConvention
        : AttributeConfigurationConvention<PropertyInfo, PrimitivePropertyConfiguration, RequiredAttribute>
    {
        public override void Apply(
            PropertyInfo memberInfo, PrimitivePropertyConfiguration configuration,
            RequiredAttribute attribute)
        {
            Check.NotNull(memberInfo, "memberInfo");
            Check.NotNull(configuration, "configuration");
            Check.NotNull(attribute, "attribute");

            if (configuration.IsNullable == null)
            {
                configuration.IsNullable = false;
            }
        }
    }
}

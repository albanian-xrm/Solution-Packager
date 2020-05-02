using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;

namespace AlbanianXrm.SolutionPackager.Models
{
    [EntityLogicalName(EntityLogicalName)]
    internal partial class Solution : Entity
    {

        public Solution() :
                base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "solution";

        public string FriendlyName
        {
            get
            {
                return GetAttributeValue<string>(Fields.FriendlyName);
            }
            set
            {
                SetAttributeValue(Fields.FriendlyName, value);
            }
        }

        public Guid? SolutionId
        {
            get
            {
                return GetAttributeValue<Guid?>(Fields.SolutionId);
            }
            set
            {
                SetAttributeValue(Fields.SolutionId, value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
            }
        }

        public override Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                SolutionId = value;
            }
        }

        public string UniqueName
        {
            get
            {
                return GetAttributeValue<string>(Fields.UniqueName);
            }
            set
            {
                SetAttributeValue(Fields.UniqueName, value);
            }
        }

        public string Version
        {
            get
            {
                return this.GetAttributeValue<string>(Fields.Version);
            }
            set
            {
                this.SetAttributeValue(Fields.Version, value);
            }
        }

        public static class Fields
        {
            public const string FriendlyName = "friendlyname";

            public const string IsManaged = "ismanaged";

            public const string IsVisible = "isvisible";

            public const string SolutionId = "solutionid";

            public const string Id = "solutionid";

            public const string UniqueName = "uniquename";

            public const string Version = "version";
        }
    }
}

// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Internal
{
    [SpacetimeDB.Type]
    [DataContract]
    public sealed partial class RawSequenceDefV9
    {
        [DataMember(Name = "name")]
        public string? Name;
        [DataMember(Name = "column")]
        public ushort Column;
        [DataMember(Name = "start")]
        public I128? Start;
        [DataMember(Name = "min_value")]
        public I128? MinValue;
        [DataMember(Name = "max_value")]
        public I128? MaxValue;
        [DataMember(Name = "increment")]
        public I128 Increment;

        public RawSequenceDefV9(
            string? Name,
            ushort Column,
            I128? Start,
            I128? MinValue,
            I128? MaxValue,
            I128 Increment
        )
        {
            this.Name = Name;
            this.Column = Column;
            this.Start = Start;
            this.MinValue = MinValue;
            this.MaxValue = MaxValue;
            this.Increment = Increment;
        }

        public RawSequenceDefV9()
        {
        }
    }
}

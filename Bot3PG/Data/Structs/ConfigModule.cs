﻿using Discord;
using MongoDB.Bson.Serialization.Attributes;

namespace Bot3PG.Data.Structs
{
    public class ConfigModule
    {
        [Config("Whether this module is enabled. Modules are enabled by default.")]
        public virtual bool Enabled { get; set; } = true;

        public class SubModule : ConfigModule
        {
            private static bool _enabled = true;
            [Config("Whether this module is enabled. Modules are enabled by default.")]
            public override bool Enabled { get => base.Enabled && _enabled; set => _enabled = value; }
        }
    }
}
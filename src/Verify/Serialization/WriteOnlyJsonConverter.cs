﻿using System;
using Newtonsoft.Json;

namespace Verify
{
    public abstract class WriteOnlyJsonConverter :
        JsonConverter
    {
        public sealed override object ReadJson(JsonReader reader, Type type, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
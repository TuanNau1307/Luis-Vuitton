﻿using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace NowSaiGon.Helpers
{
    public static class ExtensionHelper
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }    
    }
}

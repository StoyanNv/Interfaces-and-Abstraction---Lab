﻿using System.Linq;

namespace HTTPServer.Server.Http
{
    using Common;
    using Contracts;
    using System.Collections.Generic;

    public class HttpSession : IHttpSession
    {
        private readonly IDictionary<string, object> values;

        public HttpSession(string id)
        {
            CoreValidator.ThrowIfNullOrEmpty(id, nameof(id));

            this.Id = id;
            this.values = new Dictionary<string, object>();
        }

        public string Id { get; private set; }

        public void Add(string key, object value)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));
            CoreValidator.ThrowIfNull(value, nameof(value));

            this.values[key] = value;
        }

        public void Clear() => this.values.Clear();

        public void Clear(string key)
        {
            var valuesToClear = this.values.Select(x => x.Key).Where(x => x != key);
            foreach (var value in valuesToClear)
            {
                this.values.Remove(value);
            }
        }


        public object Get(string key)
        {
            CoreValidator.ThrowIfNull(key, nameof(key));

            if (!this.values.ContainsKey(key))
            {
                return null;
            }

            return this.values[key];
        }

        public T Get<T>(string key)
            => (T)this.Get(key);

        public bool Contains(string key) => this.values.ContainsKey(key);
    }
}
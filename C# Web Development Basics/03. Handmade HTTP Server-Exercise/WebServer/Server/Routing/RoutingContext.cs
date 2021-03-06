﻿using WebServer.Server.Common;

namespace WebServer.Server.Routing
{
    using Contracts;
    using Handlers;
    using System.Collections.Generic;

    public class RoutingContext : IRoutingContext
    {
        public RoutingContext(RequestHandler handler, IEnumerable<string> parameters)
        {
            CoreValidator.ThrowIfNull(handler, nameof(handler));
            CoreValidator.ThrowIfNull(parameters, nameof(handler));

            this.Parameters = parameters;
            this.Handler = handler;
        }
        public IEnumerable<string> Parameters { get; private set; }
        public RequestHandler Handler { get; private set; }
    }
}
﻿namespace WebServer.Server.HTTP.Response
{
    using Enums;
    using Exceptions;
    using Server.Contracts;
    public class ViewResponse : HttpResponse
    {
        private readonly IView view;

        public ViewResponse(HttpStatusCode statusCode, IView view)
        {

            this.ValidateStatusCode(statusCode);
            this.view = view;
            this.StatusCode = statusCode;
        }

        private void ValidateStatusCode(HttpStatusCode statusCode)
        {
            var statusCodeNumber = (int)statusCode;
            if (statusCodeNumber > 299 && statusCodeNumber < 400)
            {
                throw new InvalidRequestException("View responses need a status code below 300 and above 400 (inclusive).");
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}{this.view.View()}";
        }
    }
}
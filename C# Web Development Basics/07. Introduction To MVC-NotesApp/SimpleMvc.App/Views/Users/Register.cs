﻿namespace SimpleMvc.App.Views.Users
{
    using SimpleMvc.Framework.Interfaces;
    using System.Text;

    public class Register : IRenderable
    {
        public string Render()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<a href =\"/home/index\">Home</a>");
            sb.AppendLine("<h3>Register new user</h3>");
            sb.AppendLine("<form action = \"register\" method=\"POST\"><br/>");
            sb.AppendLine("Username: <input type=\"text\" name=\"Username\"><br/>");
            sb.AppendLine("Password: <input type=\"password\" name=\"Password\"><br/>");
            sb.AppendLine("<input type=\"submit\" value=\"Register\">");
            sb.AppendLine("</form><br/>");

            return sb.ToString();
        }
    }
}
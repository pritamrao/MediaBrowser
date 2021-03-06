﻿
namespace MediaBrowser.Model.Connect
{
    public class ConnectAuthorization
    {
        public string ConnectUserId { get; set; }
        public string UserName { get; set; }
        public string ImageUrl { get; set; }
        public string Id { get; set; }
        public string[] ExcludedLibraries { get; set; }
        public bool EnableLiveTv { get; set; }
        public string[] ExcludedChannels { get; set; }

        public ConnectAuthorization()
        {
            ExcludedLibraries = new string[] { };
            ExcludedChannels = new string[] { };
        }
    }
}

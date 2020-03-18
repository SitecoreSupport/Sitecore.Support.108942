using Sitecore;
using Sitecore.Analytics.Media;
using Sitecore.Sites;
using System;

namespace Sitecore.Support.Analytics.Media
{
    [UsedImplicitly]
    public class MediaRequestEventHandler : Sitecore.Analytics.Media.MediaRequestEventHandler
    {
        public override void OnMediaRequest(object sender, EventArgs args)
        {
            SiteContext site = Context.Site;
            if (site == null || (int)site.DisplayMode == 0)
            {
                base.OnMediaRequest(sender, args);
            }
        }
    }
}


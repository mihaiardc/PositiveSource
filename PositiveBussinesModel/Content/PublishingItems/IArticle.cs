using System;
using System.Collections.Generic;
using PositiveBussinesModel.Members;

namespace PositiveBussinesModel.Content.PublishingItem
{
    public interface IArticle : IContentItem
    {
       string Content { get; set; }
    }
}
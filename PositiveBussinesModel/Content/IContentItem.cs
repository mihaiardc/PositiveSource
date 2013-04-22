using System;

namespace PositiveBussinesModel.Content
{
    public interface IContentItem
    {
        string Name { get; set; }
        string Description { get; set; }
        Guid ArticleId { set; get; }
        string PictureUrl { get; set; }
        DateTime CreatedDate { get; set; }
        string Content { get; set; }
    }
}
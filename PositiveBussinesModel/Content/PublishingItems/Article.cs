using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using PositiveBussinesModel.Members;
using PositiveBussinesModel.Social;
using PositiveBussinesModel.Files;
using PositiveBussinesModel.Content.PublishingTypes;

namespace PositiveBussinesModel.Content.PublishingItems
{
    public class Article : IContentItem
    {
        #region Contract Properties
        public string Name { get; set; }
        public string Description { get; set; }
        [ScriptIgnore]
        public virtual List<User> Users { get; set; }
        public Guid ArticleId { get; set; }
        public string PictureUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion
        public Article()
        {
            Comments = new List<Comment>();
            Documents = new List<File>();
            Users = new List<User>();
        }
        public string Content { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<File> Documents { get; set; }
        public bool IsFeatured { get; set; }
        public PublishingType PublishingType { get; set; }
     
    }
}
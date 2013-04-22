using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PositiveBussinesModel.Content.PublishingItems;
using PositiveBussinesModel.Social;
using PositiveBussinesModel.Content.PublishingItems;
using PositiveBussinesModel.Members;

namespace BussinesModelTests
{
    [TestClass]
    public class ArticleTest
    {
        [TestMethod]
        public void NoListOfOjbectAreNullonNew()
        {
            Article articol = new Article();            
            articol.Comments.Add(new Comment() { CommentContent = "ce tampenie fratica asa ceva",Title="O abureala cretina", User = new User() { Nume = "Mihai" } });
            articol.Comments[0].Replies.Add(new Comment() { CommentContent = "Esti idiot" });
            articol.Comments.ForEach(p => Console.WriteLine(p.CommentContent));
            articol.Comments.ForEach(p => p.Replies.ForEach(t=>Console.WriteLine(t.CommentContent)));
            Assert.IsTrue(articol.Comments !=null && articol.Comments[0].Replies !=null);           
        }
    }
}

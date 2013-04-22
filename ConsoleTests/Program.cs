using System.Web.UI.WebControls;
using PositiveBussinesModel.Content.PublishingItems;
using PositiveBussinesModel.Members;
using PositiveBussinesModel.Social;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTests
{
    

    class Program
    {
       
        static void Main(string[] args)
        {
            Article articol = new Article();
            articol.Comments.Add(new Comment() { CommentContent = "ce tampenie fratica asa ceva",Title="O abureala cretina", User = new User() { Nume = "Mihai" } });
            articol.Comments[0].Replies.Add(new Comment() { CommentContent = "Esti idiot" });
            articol.Comments.ForEach(p => Console.WriteLine(p.CommentContent));
            articol.Comments.ForEach(p => p.Replies.ForEach(t=>Console.WriteLine(t.CommentContent)));
           
        }
    }
   
}

using System.Collections.Generic;
using WebApplication.Models.NewsViewModels;

namespace WebApplication.Managers
{
    public static class NewsManager
    {
        public static List<Article> GetNews()
        {
            List<Article> news =  new List<Article>();
            Article a = new Article()
            {
                Title = "Title",
                Content = "Here is a test article",
                ArticleID = 1
            };

            news.Add(a);
            Article b = new Article();
            b.Title = "Title 1";
            b.Content = "Here is another test article";
            b.ArticleID = 2;
            news.Add(b);
            Article c = new Article();
            c.Title = "Title 2";
            c.Content = "Here is final test article";
            c.ArticleID = 3;
            news.Add(c);

            return news;
        }
    }
}
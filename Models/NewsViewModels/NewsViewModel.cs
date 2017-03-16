using System.Collections.Generic;

namespace WebApplication.Models.NewsViewModels
{
    public class NewsViewModel
    {
        public NewsViewModel(List<Article> articles)
        {
            Articles = articles;
        }
        public List<Article> Articles { get; set; }
    }
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ArticleID {get;set;}
    }
}
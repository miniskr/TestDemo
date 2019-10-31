using System;
using System.Collections.Generic;
using System.Text;

namespace QueueDemo
{
    public class Document
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Document(string title,string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }
}

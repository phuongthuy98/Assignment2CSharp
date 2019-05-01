using System;
using System.Collections.Generic;
using System.Text;
using Assignment2;

namespace Assigment2
{
    class News:INews
    {
        int Id;
        String Title;
        String PublishDate;
        String Author;
        String Content;
        float AverageRate;
        int[] RateList = new int[3];

        public News(int id, string title, string publishDate, string author, string content, float averageRate, int[] rateList)
        {
            Id = id;
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
            AverageRate = averageRate;
            RateList = rateList;
        }

        public News()
        {
        }

        public void Display()
        {
            Console.WriteLine("Title:" +this.Title +"PublishDate: "+this.PublishDate+" Author: "+this.Author+" Content: "+this.Content+" AverageRate :"+this.AverageRate);
        }
        public double Calculate()
        {
            foreach (var item in RateList)
            {
                this.AverageRate += item;
            }
            return this.AverageRate;
        }

        internal void add(News @new)
        {
            throw new NotImplementedException();
        }

        internal void add(int id, string title, string publishDate, string author, string content, float diemTBcong, object p)
        {
            throw new NotImplementedException();
        }
    }
}
﻿using carsharing.Models;

namespace carsharing.ViewModels
{
    public class ResultsViewModel
    {
        public SearchBar SearchBar;

        public FilterPost FilterPost;

        public String ErrorMessage;

        public double NumberOfDays;
        public Renter? Renter { get; set; }
        public Owner? Owner { get; set; }
        public String? Label { get; set; }
        public CreatePost? CreatePost { get; set; }
        public Post? Post { get; set; }

        public IQueryable<Post> Posts { get; set; } = null!;

        public ResultsViewModel(IQueryable<Post> post, double numberOfDays, String errorMessage = "")
        {
            this.SearchBar = new SearchBar();
            this.FilterPost = new FilterPost();
            this.Posts = post;
            this.NumberOfDays = numberOfDays;
            this.ErrorMessage = errorMessage;
        }


    }

}

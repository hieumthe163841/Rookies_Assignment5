﻿namespace Assignment5.WebApp.Helpers
{
    public class PagingModel
    {
        public int Currentpage { get; set; }
        public int Countpages { get; set; }

        public Func<int?, string> GenerateUrl { get; set; }
    }
}

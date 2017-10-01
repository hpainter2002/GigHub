﻿using GigHub15.Models;
using System.Collections.Generic;

namespace GigHub15.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { set; get; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
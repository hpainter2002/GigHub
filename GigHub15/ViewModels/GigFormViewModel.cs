﻿using System;
using GigHub15.Models;
using System.Collections.Generic;

namespace GigHub15.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { set; get; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime
        {
            get { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
        }
    }
}
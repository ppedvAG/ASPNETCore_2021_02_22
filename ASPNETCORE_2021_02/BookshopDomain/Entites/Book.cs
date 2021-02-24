﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookshopDomain.Entites
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Published { get; set; }


        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
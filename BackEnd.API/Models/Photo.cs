﻿using System;

namespace BackEnd.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }

        // Adding this to the Photos, means when user is deleted all its photos will be deleted. NAVIGATION PROPERTY
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
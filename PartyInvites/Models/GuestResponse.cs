﻿/*
 Guest Response Model
 */
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name{ get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone{ get; set; }

        [Required(ErrorMessage = "Please provide whether you'll attend or not.")]
        public bool? WillAttend{ get; set; }
    }
}
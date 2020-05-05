using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Lab01.Models
{
    public class FriendModel
    {
        public int ID { get; set; }

        [Required]
        [Range(0,200)]
        [Display(Name ="Friend ID.")]
        public int FriendId { get; set; }



        [Required]
        [Display(Name = "Friend Name")]
        public string Ime { get; set; }

        [Required]
        [Display(Name = "Place")]
        public string MestoZiveenje { get; set; }
    }
}
﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Models.Core
{
    [Table("UserSubscription")]
    public class UserSubscription
    {
        //composite key
        [Required]
        [Key, Column(Order = 1)]
        public int SubscriptionId { get; set; }

        [Required]
        [Key, Column(Order = 2)]
        [MaxLength(128)]
        public string UserId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }


    }
}
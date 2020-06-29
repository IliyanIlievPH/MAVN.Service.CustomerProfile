﻿using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace MAVN.Service.CustomerProfile.Client.Models.Requests
{
    /// <summary>
    /// Represents a partner contact data.
    /// </summary>
    [PublicAPI]
    public class PartnerContactUpdateRequestModel
    {
        /// <summary>
        /// The location identifier.
        /// </summary>
        [Required]
        public string LocationId { get; set; }

        /// <summary>
        /// The contact first name.
        [MaxLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// The contact last name.
        /// </summary>
        [MaxLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// The contact phone number.
        /// </summary>
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The contact phone number.
        /// </summary>
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}

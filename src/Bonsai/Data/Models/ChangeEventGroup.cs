﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Bonsai.Data.Models
{
    /// <summary>
    /// The log of an entity's modification.
    /// </summary>
    public class ChangeEventGroup
    {
        /// <summary>
        /// Changeset grouping key generated by the database view.
        /// </summary>
        [Key]
        public string GroupKey { get; set; }

        /// <summary>
        /// Comma-separated list of changeset IDs.
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// Date of the first changeset in the group.
        /// </summary>
        public DateTimeOffset Date { get; set; }
    }
}

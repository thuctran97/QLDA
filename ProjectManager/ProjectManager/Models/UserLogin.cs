//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class UserLogin
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="Please provide Account",AllowEmptyStrings =false)]
        public string Account { get; set; }
        [Required(ErrorMessage = "Please provide Password", AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RoleType
    {


        [Required(ErrorMessage = "Please enter required field")]
        public int RoleTypeID { get; set; }


        [Required(ErrorMessage = "Please enter required field")]
        public string RoleType_Disc { get; set; }
    }
}

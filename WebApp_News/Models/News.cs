//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp_News.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public long ID_News { get; set; }
        public string Title_News { get; set; }
        public string SortText { get; set; }
        public Nullable<int> ID_FK_NewsType { get; set; }
    }
}

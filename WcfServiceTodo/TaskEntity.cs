//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceTodo
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskEntity
    {
        public int id { get; set; }
        public string title { get; set; }
        public string datedue { get; set; }
        public string datedone { get; set; }
        public string tags { get; set; }
        public string author { get; set; }
        public string executor { get; set; }
    }
}

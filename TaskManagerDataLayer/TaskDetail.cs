//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManagerDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskDetail
    {
        public int Task_ID { get; set; }
        public int Parent_ID { get; set; }
        public string Task { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Priority { get; set; }
    
        public virtual ParentTaskDetail ParentTaskDetail { get; set; }
    }
}

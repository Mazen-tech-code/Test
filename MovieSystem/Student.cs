//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int student_ID { get; set; }
        public string student_Name { get; set; }
        public string student_Password { get; set; }
        public string student_Email { get; set; }
        public string student_address { get; set; }
        public Nullable<int> student_Age { get; set; }
        public Nullable<int> dep_ID { get; set; }
    
        public virtual Department Department { get; set; }
    }
}

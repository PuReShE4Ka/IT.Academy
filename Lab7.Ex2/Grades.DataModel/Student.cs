
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Grades.DataModel
{

using System;
    using System.Collections.Generic;
    
public partial class Student
{

    public Student()
    {

        this.Grades = new HashSet<Grade>();

    }


    public System.Guid UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string ImageName { get; set; }

    public Nullable<System.Guid> TeacherUserId { get; set; }



    public virtual ICollection<Grade> Grades { get; set; }

    public virtual User User { get; set; }

    public virtual Teacher Teacher { get; set; }

}

}

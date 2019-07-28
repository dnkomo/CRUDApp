﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StudentEntities : DbContext
    {
        public StudentEntities()
            : base("name=StudentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<student> student { get; set; }
    
        public virtual ObjectResult<sp_ViewAllStudent_Result> sp_ViewAllStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ViewAllStudent_Result>("sp_ViewAllStudent");
        }
    
        public virtual int sp_insertupdate_student(Nullable<int> id, string firstName, string lastName, string homeAddress, Nullable<long> phoneNumber, ObjectParameter idout)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var homeAddressParameter = homeAddress != null ?
                new ObjectParameter("homeAddress", homeAddress) :
                new ObjectParameter("homeAddress", typeof(string));
    
            var phoneNumberParameter = phoneNumber.HasValue ?
                new ObjectParameter("phoneNumber", phoneNumber) :
                new ObjectParameter("phoneNumber", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertupdate_student", idParameter, firstNameParameter, lastNameParameter, homeAddressParameter, phoneNumberParameter, idout);
        }
    
        public virtual ObjectResult<sp_viewStudentById_Result> sp_viewStudentById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_viewStudentById_Result>("sp_viewStudentById", idParameter);
        }
    
        public virtual int sp_deleteStudentByID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteStudentByID", idParameter);
        }
    }
}

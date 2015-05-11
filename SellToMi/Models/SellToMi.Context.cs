﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SellToMi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DB_77381_txttoadEntities : DbContext
    {
        public DB_77381_txttoadEntities()
            : base("name=DB_77381_txttoadEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TxtAd> TxtAd { get; set; }
        public DbSet<TxtAdCategory> TxtAdCategory { get; set; }
        public DbSet<TxtAdInfo> TxtAdInfo { get; set; }
        public DbSet<TxtAdPhoto> TxtAdPhoto { get; set; }
        public DbSet<vwFullAdItem> vwFullAdItem { get; set; }
    
        public virtual ObjectResult<getListofItems_Result> getListofItems(Nullable<int> cat, Nullable<int> startnumber, Nullable<int> lastnumber, string searchText, string city, string state, string zipCodes)
        {
            var catParameter = cat.HasValue ?
                new ObjectParameter("cat", cat) :
                new ObjectParameter("cat", typeof(int));
    
            var startnumberParameter = startnumber.HasValue ?
                new ObjectParameter("startnumber", startnumber) :
                new ObjectParameter("startnumber", typeof(int));
    
            var lastnumberParameter = lastnumber.HasValue ?
                new ObjectParameter("lastnumber", lastnumber) :
                new ObjectParameter("lastnumber", typeof(int));
    
            var searchTextParameter = searchText != null ?
                new ObjectParameter("SearchText", searchText) :
                new ObjectParameter("SearchText", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipCodesParameter = zipCodes != null ?
                new ObjectParameter("ZipCodes", zipCodes) :
                new ObjectParameter("ZipCodes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getListofItems_Result>("getListofItems", catParameter, startnumberParameter, lastnumberParameter, searchTextParameter, cityParameter, stateParameter, zipCodesParameter);
        }
    
        public virtual ObjectResult<GetSubCategories_Result> GetSubCategories(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSubCategories_Result>("GetSubCategories", categoryIdParameter);
        }
    
        public virtual ObjectResult<GetFullAd_Result> GetFullAd(Nullable<int> adId)
        {
            var adIdParameter = adId.HasValue ?
                new ObjectParameter("AdId", adId) :
                new ObjectParameter("AdId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetFullAd_Result>("GetFullAd", adIdParameter);
        }
    }
}

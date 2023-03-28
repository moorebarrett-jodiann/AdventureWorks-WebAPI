﻿using WebApplication1.Models;
namespace WebApplication1.EntityMethods
{
    public  static class CustomerMethods
    {
        public static IResult GetCustomers(AdventureWorksLt2019Context db,int maxResults = 100)
        {
            return Results.Ok(db.Customers.Take(maxResults).ToList());
        }
    }
}
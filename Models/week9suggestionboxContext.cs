using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace week9suggestionbox.Models
{
    public class week9suggestionboxContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public week9suggestionboxContext() : base("name=week9suggestionboxContext")
        {
        }

        public System.Data.Entity.DbSet<week9suggestionbox.Models.Suggestionmodel> Suggestionmodels { get; set; }
    }
}

using PhotoSharing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhotoSharing.Data
{
    public class PhotoSharingContext : DbContext
    {
        public PhotoSharingContext():base(@"Data Source=.;Initial Catalog=PhotoSharing;Integrated Security=True")
        {
        }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
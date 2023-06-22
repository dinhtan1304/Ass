using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC_Assignment12.Exercise1
{
    public class VideoContext:DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.EntityConfigurations
{
   public  class CourseConfiguration: EntityTypeConfiguration<course>
    {
       public CourseConfiguration()
        {
            /*
             * we will put all the data we have for a seperate entity
             * I mean course is a seperate thing so for this we will use all thing in a seperate class for convinence
             * in big enterprices we have a lot of codes so we have to manage them as accordingly to get rid of errors
             */ 
        }
    }
}

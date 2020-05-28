
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirst
{
    /* 
     * Section 5 
     * Overriding Code-First Conventions
     * 
     * Lecture 36 
     * Data Annotations
     * 
     * Table Names:
     * Plular form of class names
     * 
     * for example:
     *  class name = course:
     *  then table name sould be courses
     *  
     *  If name of the table is different that we should mention it seperately and if it is existing in another schema that we should write the name of the schema also.
     *  
     *  
     *  Name of Columns:
     *  Name
     *  ID
     *  Color
     *  Class ect........
     *  
     *  Same is the case with column as we use with the table name.
     *  If name of the column is different that we should mention it seperately and if it is existing in another schema that we should write the name of the schema also.
     *  
     *  
     *  Primary Key:
     *  A property Name ID or ClassName ID
     *  
     *  
     *  Composite Keys:
     *  [key]
     *  [Column( order= 1)]
     *  public int orderID {get; ste;}
     *  
     *  [key]
     *    [Column( order= 2)]
     *    public int orderID {get; ste;}
     *    
     *    
     *  Nulls:
     *  A column is nullable if property is nullable like in database
     *  
     *  [Required]
     *  public string Name {get; set;}
     *  
     *  // Required does nt stop from assogning the null value but at runtime it throws exception error
     *    
     *    
     *    Lengths of Strings:
     *    MAX
     *    [MaxLength(255)]
     *    public string Name {get; set;}
     *    
     *    
     *  Index:
     *  [Index(IsUnique = true)]
     *  public string Name {get; set;}
     *  
     *  Foreign Keys:
     *  public class course
     *  {
     *      [ForeignKey("AutorId")]
     *      public int AuthorId {get; set;}
     *      public Author Author {get; set;}
     *  }
     *    
     */


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

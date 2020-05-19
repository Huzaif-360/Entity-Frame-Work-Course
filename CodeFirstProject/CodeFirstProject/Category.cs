using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstProject
{
    //Lecture 27
    //Migrations: Modifying an Existing Class
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /*Add a Migrations
         * Adding a new Property 
         * As already discussed that we shoudld add only small changes and then we should use migrations to make the database upto dated.
         * Using this we can easily update the database created already in our existing database
        */
        public Category category { get; set; }
        public DateTime? DatePublished { get; set; }
        public int Level { get; set; }

    }
}

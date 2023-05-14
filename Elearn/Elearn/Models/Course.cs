﻿namespace Elearn.Models
{
    public class Course:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<CourseImage> CourseImages { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}

namespace Architecture.ViewModel
{
    public class CourseViewModel
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
    }
}

//Viewmodels used to combine two models
//only for data that you need in the view 
//sends the data to the view 

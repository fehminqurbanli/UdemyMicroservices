using Microsoft.AspNetCore.Http;

namespace FreeCourse.Web.Models.Catalogs
{
    public class CourseCreateInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public string UserId { get; set; }
        public FeatureViewModel FeatureViewModel { get; set; }
        public string CategoryId { get; set; }
        public IFormFile PhotoFormFile { get; set; }
    }
}

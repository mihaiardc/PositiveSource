using System;

namespace PositiveBussinesModel.Files
{
    public class File 
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
    }
}

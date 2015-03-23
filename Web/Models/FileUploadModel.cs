using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class FileUploadModel
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FileDateUploaded { get; set; }

      
    }
}
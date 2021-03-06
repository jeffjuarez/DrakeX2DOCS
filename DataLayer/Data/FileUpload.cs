﻿using Repository;
using System;

namespace DataLayer.Data
{
    public partial class FileUpload : BaseEntity
    {
        public int FileUploadID { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime FileDateUploaded { get; set; }
    }
}

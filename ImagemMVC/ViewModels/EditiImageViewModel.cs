using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagemMVC.ViewModels
{
    public class EditiImageViewModel:UploadImageViewModel
    {
        public int Id { get; set; }
        public string ImagemExistente { get; set; }
    }
}

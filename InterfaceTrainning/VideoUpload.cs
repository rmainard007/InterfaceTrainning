using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTrainning
{
    class VideoUpload : IActivity
    {
        public void execute()
        {
            Console.WriteLine("Video File Uploaded.");
        }
    }
}

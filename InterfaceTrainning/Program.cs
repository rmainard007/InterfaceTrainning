using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTrainning
{
    class Program
    {
        static void Main(string[] args)
        {
            var _myWork = new Workflow();

            _myWork.CreateNewActivity(new VideoUpload());
            _myWork.CreateNewActivity(new WebEncode());
            _myWork.CreateNewActivity(new EmailOwner());
            _myWork.CreateNewActivity(new StatusUpdate());

            _myWork.Run();
        }
    }
}
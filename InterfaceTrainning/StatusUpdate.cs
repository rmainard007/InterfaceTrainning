using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTrainning
{
    class StatusUpdate : IActivity
    {
        public void execute()
        {
            Console.WriteLine("Video status: Processing");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTrainning
{
    class Workflow
    {
        private IList<IActivity> _activity;

        public Workflow()
        {
            _activity = new List<IActivity>();
        }

        public void Run()
        {
            foreach(var activity in _activity)
            {
                activity.execute();
            }
        }

        public void CreateNewActivity(IActivity activity)
        {
            _activity.Add(activity);
        }


    }
}

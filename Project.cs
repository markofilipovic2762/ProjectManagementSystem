using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    [Serializable]
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FolderPath { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProjectType { get; set; }
        public int MaxNumberOfResults { get; set; }
        public bool EnableNotifications { get; set; }

    }
}

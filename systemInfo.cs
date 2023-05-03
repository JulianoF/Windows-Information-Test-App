using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsStatusTestAPP
{
    public class systemInfo
    {
        bool showName;
        bool showVersion;
        bool showType;
        bool showSpeed;
        bool showRam;
        bool showDrive;
        public systemInfo()
        {
            showName = false;
            showVersion = false;
            showType = false;
            showSpeed = false;
            showRam = false;
            showDrive = false;
        }

        public void setName(bool value)
        {
            if (value)
            {
                showName = true;
            }
            else
            {
                showName= false;
            }
        }

        public void getSysInfo()
        {
            if (showName)
            {
                Console.WriteLine(Environment.MachineName.ToString());
            }
            
        }
    }
}

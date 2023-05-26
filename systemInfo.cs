using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WindowsStatusTestAPP
{
    public class systemInfo
    {
        private bool showName;
        private bool showVersion;
        private bool showType;
        private bool showSpeed;
        private bool showRam;
        private bool showDrive;
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

        public void setVersion(bool value)
        {
            if (value)
            {
                showVersion = true;
            }
            else
            {
                showVersion = false;
            }
        }
        public void setType(bool value)
        {
            if (value)
            {
                showType = true;
            }
            else
            {
                showType = false;
            }
        }
        public void setSpeed(bool value)
        {
            if (value)
            {
                showSpeed = true;
            }
            else
            {
                showSpeed = false;
            }
        }
        public void setRam(bool value)
        {
            if (value)
            {
                showRam = true;
            }
            else
            {
                showRam = false;
            }
        }
        public void setDrive(bool value)
        {
            if (value)
            {
                showDrive = true;
            }
            else
            {
                showDrive = false;
            }
        }

        public String getSysInfo()
        {
            StringBuilder output = new StringBuilder();
            if (showName)
            {
                output.AppendLine("System Information");
                output.AppendLine("****************************************************");
                ManagementClass systemClass = new ManagementClass("Win32_SystemOperatingSystem");
                ManagementObjectCollection systemCollection = systemClass.GetInstances();
                PropertyDataCollection myProperties = systemClass.Properties;
                foreach (var obj in systemCollection)
                {
                    foreach (var myProperty in myProperties)
                    {
                        output.AppendLine(myProperty.Name + ": " + obj.Properties[myProperty.Name].Value);
                    }
                }
                output.AppendLine("-------------------------------------------------------------------");
                output.AppendLine("");
                systemCollection.Dispose();
                systemClass.Dispose();

            }

            if (showVersion)
            {
                output.AppendLine("OS Information");
                output.AppendLine("****************************************************");
                ManagementClass enviroClass = new ManagementClass("Win32_OperatingSystem");
                ManagementObjectCollection enviroCollection = enviroClass.GetInstances();
                PropertyDataCollection myProperties = enviroClass.Properties;
                foreach (var obj in enviroCollection)
                {
                    foreach (var myProperty in myProperties)
                    {
                        output.AppendLine(myProperty.Name + ": " + obj.Properties[myProperty.Name].Value);
                    }
                }
                output.AppendLine("-------------------------------------------------------------------");
                output.AppendLine("");
                enviroCollection.Dispose();
                enviroClass.Dispose();
            }

            if (showType)
            {
                output.AppendLine("Processor Information");
                output.AppendLine("****************************************************");
                ManagementClass processorClass = new ManagementClass("Win32_Processor");
                ManagementObjectCollection processorCollection = processorClass.GetInstances();
                PropertyDataCollection myProperties = processorClass.Properties;
                foreach (var obj in processorCollection)
                {
                    foreach (var myProperty in myProperties)
                    {
                        output.AppendLine(myProperty.Name +": " + obj.Properties[myProperty.Name].Value);                  
                    }
                }
                output.AppendLine("-------------------------------------------------------------------");
                output.AppendLine("");
                processorCollection.Dispose();
                processorClass.Dispose();

            }

            if (showSpeed)
            {
                
            }

            if (showRam)
            {
                output.AppendLine("RAM Information");
                output.AppendLine("****************************************************");
                ManagementClass ramClass = new ManagementClass("Win32_PhysicalMemory");
                ManagementObjectCollection ramCollection = ramClass.GetInstances();
                PropertyDataCollection myProperties = ramClass.Properties;
                foreach (var obj in ramCollection)
                {
                    foreach (var myProperty in myProperties)
                    {
                        output.AppendLine(myProperty.Name + ": " + obj.Properties[myProperty.Name].Value);
                    }
                }
                output.AppendLine("-------------------------------------------------------------------");
                output.AppendLine("");
                ramCollection.Dispose();
                ramClass.Dispose();
            }

            if (showDrive)
            {
                output.AppendLine("Drive Information");
                output.AppendLine("****************************************************");
                ManagementClass driveClass = new ManagementClass("Win32_Volume");
                ManagementObjectCollection driveCollection = driveClass.GetInstances();
                PropertyDataCollection myProperties = driveClass.Properties;
                foreach (var obj in driveCollection)
                {
                    foreach (var myProperty in myProperties)
                    {
                        output.AppendLine(myProperty.Name + ": " + obj.Properties[myProperty.Name].Value);
                    }
                }
                output.AppendLine("-------------------------------------------------------------------");
                output.AppendLine("");
                driveCollection.Dispose();
                driveClass.Dispose();
            }

            return output.ToString();
        }
    }
}

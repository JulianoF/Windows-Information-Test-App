﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //output.AppendLine("Desktop Name:   " + Environment.MachineName.ToString());
            }

            if (showVersion)
            {
                //output.AppendLine("OS Version:   " + Environment.OSVersion.ToString());
            }

            if (showType)
            {
                
            }

            if (showSpeed)
            {
                
            }

            if (showRam)
            {

            }

            if (showDrive)
            {

            }

            return output.ToString();
        }
    }
}
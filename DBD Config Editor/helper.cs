﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBD_Config_Editor
{
    internal class helper
    {

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public bool IsValidBase64(string input)
        {
            try
            {
                Base64Encode(input);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DoReadOnly(bool var)
        {
            FileInfo fI = new FileInfo(MainForm.sPathToUse+@"\GameUserSettings.ini");

            if (var)
            {
                if (!fI.IsReadOnly)
                {
                    fI.IsReadOnly = true;
                    fI = new FileInfo(MainForm.sPathToUse+@"\Engine.ini");
                    fI.IsReadOnly = true;
                }
            }
            else
            {
                fI.IsReadOnly = false;
                fI = new FileInfo(MainForm.sPathToUse+@"\Engine.ini");
                if (fI.IsReadOnly)
                    fI.IsReadOnly = false;
            }
        }
    }
}

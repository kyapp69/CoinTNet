﻿using CoinTNet.Common;
using CoinTNet.Common.Constants;
using System;
using System.Windows.Forms;

namespace CoinTNet.UI.Common
{
    /// <summary>
    /// Helper for error display
    /// </summary>
    class ErrorHelper
    {
        /// <summary>
        /// Displays an error message
        /// </summary>
        /// <param name="errMsg"></param>
        public static void DisplayErrorMessage(string errMsg)
        {
            MessageBox.Show(errMsg, ApplicationConstants.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Logs an error and display a message informing the user that the application is going to crash
        /// </summary>
        /// <param name="ex"></param>
        public static void HandleApplicationError(Exception ex)
        {
            Logger.Log(ex, "Application crash");
            DisplayErrorMessage("The application is about to crash. Error:\n" + ex.ToString());
        }
    }
}
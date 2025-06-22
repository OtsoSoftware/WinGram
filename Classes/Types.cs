using System.Drawing;
using System.Windows.Forms;
using System;
using TL;

namespace WinGram
{
    /// <summary>
    /// Predefined constants, types, enums
    /// </summary>
    public static class Types
    {
        public static readonly string dateFormat = "yyyy'.'MM'.'dd";
        public static readonly string dateTimeFormat = "yyyy'.'MM'.'dd' 'HH':'mm";
        public static readonly string dateTimeSecondsFormat = "yyyy'.'MM'.'dd' 'HH':'mm':'ss";



        public enum ChatType { All, Dialog, Group, Channel, Bot, Favourite };


    }

}

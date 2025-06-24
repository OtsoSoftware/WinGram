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

		public enum MediaType { Unknown, Photo, Audio, Voice, Video, Sticker, Document, Executable };

        public static MediaType GetMediaTypeFromExtension(string fileName)
        {
            fileName = fileName.ToLower();

            if (fileName.EndsWith(".webp")) return MediaType.Sticker;
            else if (fileName.EndsWith(".mp4") || fileName.EndsWith(".webm") || fileName.EndsWith(".avi") || fileName.EndsWith(".mov") || fileName.EndsWith(".mkv")) return MediaType.Video;
            else if (fileName.EndsWith(".mp3") || fileName.EndsWith(".wav") || fileName.EndsWith(".flac") || fileName.EndsWith(".ogg")) return MediaType.Audio;
            else if (fileName.EndsWith(".opus") || fileName.EndsWith(".m4a")) return MediaType.Voice;
            else if (fileName.EndsWith(".jpg") || fileName.EndsWith(".jpeg") || fileName.EndsWith(".png") || fileName.EndsWith(".bmp") || fileName.EndsWith(".gif") || fileName.EndsWith(".tiff") || fileName.EndsWith(".heic")) return MediaType.Photo;
            else if (fileName.EndsWith(".pdf") || fileName.EndsWith(".doc") || fileName.EndsWith(".docx") || fileName.EndsWith(".xls") || fileName.EndsWith(".xlsx") || fileName.EndsWith(".ppt") || fileName.EndsWith(".pptx") || fileName.EndsWith(".txt") || fileName.EndsWith(".rtf")) return MediaType.Document;
            else if (fileName.EndsWith(".exe") || fileName.EndsWith(".ahk")|| fileName.EndsWith(".msi") || fileName.EndsWith(".bat") || fileName.EndsWith(".sh") || fileName.EndsWith(".apk") || fileName.EndsWith(".app")) return MediaType.Executable;
            else return MediaType.Unknown;
        }
    }

}

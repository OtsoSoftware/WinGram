using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using TL;
using WinGram.Properties;
using WTelegram;
using static WinGram.Stor;

namespace WinGram
{
	/// <summary>
	/// We better obviously don't download each media each time from Telegram servers. 
	/// So let's cache all the urine on our hard drive :P
	/// </summary>
	internal static class Cache
	{
		/// <summary>
		/// Starts a background listener which, on media-related updates, 
		/// will steal a newer file onto disk or will delete a removed file respectfully
		/// </summary>
		public static void Start_MediaHomelessMan()
		{
			new Thread(() => 
			{
				Account.OnUpdateReceived += ((Update update) =>
				{
					try
					{

					}
					catch (Exception ex)
					{
						new MsgBox(ex.Message, "Could not download updated media!").ShowDialog();
					}

					return Task.CompletedTask;
				});
			}).Start();
		}


		private static void ShitToCache(Image img, long id)
		{
			string expectedLocation = Path.Combine(cacheFolder, $"{id}{imageExt}");
			try { File.Delete(expectedLocation); } catch { }
			img.Save(expectedLocation);
		}

		private static Image EatFromCache(long id)
		{
			string expectedLocation = Path.Combine(cacheFolder, $"{id}{imageExt}");

			if (File.Exists(expectedLocation))
			{
				return Image.FromFile(expectedLocation);
			}
			else
			{
				throw new FileNotFoundException();
			}
		}

		/// <returns>Path to file located locally</returns>
		private static string EatFromDownloads(string fileName, long id)
		{
			string expectedLocation = Path.GetFullPath(Path.Combine(downloadsFolder, $"{id}_{fileName}"));

			if (File.Exists(expectedLocation))
			{
				return expectedLocation;
			}
			else
			{
				throw new FileNotFoundException();
			}
		}

		public static async Task<Image> GrabPhotoAsync(Photo photo)
		{
			try //try locally first
			{
				return EatFromCache(photo.ID);
			}
			catch (FileNotFoundException) //download, then!
			{
				return await StealPhotoAsync(photo);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="document"></param>
		/// <returns>Path to the document obtained on the computer</returns>
		public static async Task<string> GrabFileAsync(Document document)
		{
			try //try locally first
			{
				return EatFromDownloads(document.Filename, document.ID);
			}
			catch (FileNotFoundException) //download, then!
			{
				return await StealFileAsync(document);
			}
		}

		public static async Task<Image> GrabAvatarAsync(IPeerInfo peer)
		{
			try //try locally first
			{
				return EatFromCache(peer.ID);
			}
			catch (FileNotFoundException) //download, then!
			{
				return await StealAvatarAsync(peer);
			}
		}

		private static async Task<Image> StealPhotoAsync(Photo photo)
		{
			if (photo == null)
				return null;

			using (Stream suka = new MemoryStream())
			{
				Storage_FileType type = await Account.client.DownloadFileAsync(photo, suka, photo.LargestPhotoSize);
				suka.Position = 0;
				if (type is not Storage_FileType.unknown and not Storage_FileType.partial)
				{
					using (Image img = Image.FromStream(suka))
					{
						ShitToCache(img, photo.ID);
						return new Bitmap(img);
					}
				}
				else
				{
					return Resources.asterisk;
				}
			}
		}

		private static async Task<string> StealFileAsync(Document document)
		{
			if (document == null)
				return null;

			string fileName = document.Filename;
			string expectedDownloadLocation = Path.GetFullPath(Path.Combine(downloadsFolder, $"{document.ID}_{fileName}"));
			CancellationTokenSource cts = new();

			using (FileStream fileStream = File.Create(expectedDownloadLocation))
			{
				Console.WriteLine("Downloading " + fileName);

				string mimeType = await Account.client.DownloadFileAsync(document, fileStream, progress: (p, t) => cts.Token.ThrowIfCancellationRequested());
				
				Console.WriteLine("Download finished");

				//if (type is not Storage_FileType.unknown and not Storage_FileType.partial)
				//{

					return expectedDownloadLocation;
				//}
				//else
				//{
				//    return Resources.asterisk;
				//}
			}
		}

		private static async Task<Image> StealAvatarAsync(IPeerInfo peer, bool shakal = false)
		{
			if (peer == null)
				return null;

			using (Stream suka = new MemoryStream())
			{
				await Account.client.DownloadProfilePhotoAsync(peer, suka, false, shakal);
				suka.Position = 0;
				using (Image img = Image.FromStream(suka))
				{
					ShitToCache(img, peer.ID);
					return new Bitmap(img);
				}
			}
		}

	}
}

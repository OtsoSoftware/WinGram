using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL;
using WinGram.Properties;
using WTelegram;

namespace WinGram
{
	public static class Account
	{
		public static WTelegram.Client client;

		public static Image MyAvatar = Resources.person;

		public static UpdateManager UpdatesManager;

		public static event Func<Update, Task> OnUpdateReceived;

		public static void StartUpdatesManager()
		{
			UpdatesManager = client.WithUpdateManager(HandleUpdates);
		}

		private static Task HandleUpdates(Update update)
		{
			// Broadcast to all subscribers
			if (OnUpdateReceived != null)
			{
				var handlers = OnUpdateReceived.GetInvocationList();
				var tasks = handlers.Select(d => ((Func<Update, Task>)d)(update));
				return Task.WhenAll(tasks);
			}

			return Task.CompletedTask;
		}

	}
}

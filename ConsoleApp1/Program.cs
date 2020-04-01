using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace ConsoleApp1
{
	class Program
	{
		private static TelegramBotClient client;
		static void Main(string[] args)
		{
			// token, который вернул BotFather
			client = new TelegramBotClient("1138042209:AAGpitLTlMTE5uM6DUquVXjOE-Wq3m9LfO8");
			client.OnMessage += BotOnMessageReceived;

			client.StartReceiving();
			client.OnMessage += BotOnMessageReceived;
			Console.ReadLine();
			client.StopReceiving();
		}
		private static void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
		{
			var message = messageEventArgs.Message;
			if (message?.Type == Telegram.Bot.Types.Enums.MessageType.Text)
			{
				Console.WriteLine(message.Text);
			}
		}
	}
}
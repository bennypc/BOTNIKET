using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext.Attributes;

namespace BOTNIKET
{
	class Commands
	{
		static string[] fileData = File.ReadAllLines(@"aniketmsg.txt");
		static int lineCount = fileData.Count();
		static Random random = new Random();

		[Command("about")]
		public async Task About(CommandContext ctx)
		{
			await ctx.RespondAsync("Developed by bennypc#4763");
		}


		[Command("msg")]
		public async Task Msg(CommandContext ctx)
		{
			var randomLine = random.Next(0, lineCount - 1);

			string RandomLine = fileData[randomLine];

			await ctx.Channel.SendMessageAsync(RandomLine).ConfigureAwait(false);
		}

		[Command("hello")]
		public async Task Insult(CommandContext ctx)
		{
			await ctx.Channel.SendMessageAsync("FUCK YOU " + ctx.Message.Author.Mention).ConfigureAwait(false);

		}

		[Command("flushed")]
		public async Task Flushed(CommandContext ctx)
		{
			await ctx.Channel.SendMessageAsync("i need simran where is she <@278933743333277696> COME HERE PLEASEEEEE").ConfigureAwait(false);
		}

		[Command("add")]
		public async Task Add(CommandContext ctx, int numberOne, int numberTwo)
		{
			await ctx.Channel.SendMessageAsync((numberOne + numberTwo).ToString()).ConfigureAwait(false);
		}

		[Command("subtract")]
		public async Task Subtract(CommandContext ctx, int numberOne, int numberTwo)
		{
			await ctx.Channel.SendMessageAsync((numberOne - numberTwo).ToString()).ConfigureAwait(false);
		}

		[Command("multiply")]
		public async Task Multiply(CommandContext ctx, int numberOne, int numberTwo)
		{
			await ctx.Channel.SendMessageAsync((numberOne * numberTwo).ToString()).ConfigureAwait(false);
		}

		[Command("divide")]
		public async Task Divide(CommandContext ctx, float numberOne, float numberTwo)
		{
			await ctx.Channel.SendMessageAsync((numberOne / numberTwo).ToString()).ConfigureAwait(false);
		}
	}
}

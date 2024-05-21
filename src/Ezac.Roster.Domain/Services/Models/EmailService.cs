using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Search;
using MailKit.Security;
using MailKit;

namespace Ezac.Roster.Domain.Services.Models
{
	public class EmailService
	{
		private readonly IConfiguration _configuration;

		public EmailService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public async Task SendEmailAsync(string to, string subject, string body)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("de Zweefvliegers", _configuration["Smtp:User"]));
			message.To.Add(new MailboxAddress(to,to));
			message.Subject = subject;

			message.Body = new TextPart("plain")
			{
				Text = body
			};

			using (var client = new MailKit.Net.Smtp.SmtpClient())
			{
				await client.ConnectAsync(
					_configuration["Smtp:Host"],
					int.Parse(_configuration["Smtp:Port"]),
					MailKit.Security.SecureSocketOptions.StartTls
				);

				await client.AuthenticateAsync(_configuration["Smtp:User"], _configuration["Smtp:Password"]);
				await client.SendAsync(message);
				await client.DisconnectAsync(true);
			}
		}
	}
}

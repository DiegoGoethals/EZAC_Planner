using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services
{
	public class LogInBooLService
	{
		private bool _isLoggedIn = false;

		public bool IsLoggedIn
		{
			get => _isLoggedIn;
			set
			{
				if (_isLoggedIn != value)
				{
					_isLoggedIn = value;
					OnLoggedInChanged?.Invoke(value);
				}
			}
		}
		

		public event Action<bool> OnLoggedInChanged;
	}
}

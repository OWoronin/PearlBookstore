﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlBookstore.Shared
{
	public class RegistrationData
	{
		public string Name { get; set; }		
		public string Surname { get; set; }	
		public string Login { get; set; }	
		public string Password { get; set; }	
		public int Role { get; set; }
	}
}
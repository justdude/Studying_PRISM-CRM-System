﻿using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Events.Events
{
	public class ComboChangeEvent : PubSubEvent<object> 
	{
		public object SelectedItem { get; set; }
	}
}

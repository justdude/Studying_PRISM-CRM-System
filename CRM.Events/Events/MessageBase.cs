﻿using Microsoft.Practices.Prism.PubSubEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Events.Events
{
	public class MessageBase : PubSubEvent<object> 
	{
		//public Action<object> Event { get; set; }
	}
}

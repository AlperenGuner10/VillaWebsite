﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.DTO.Dtos.MessageDtos
{
	public class ResultMessageDto
	{
		public int MessageId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string MessageContent { get; set; }
		public DateTime MessageDate { get; set; }
	}
}

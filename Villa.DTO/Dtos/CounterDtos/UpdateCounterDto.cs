﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.DTO.Dtos.CounterDtos
{
	public class UpdateCounterDto
	{
		public int CounterId { get; set; }
		public string Title { get; set; }
		public string Count { get; set; }
	}
}

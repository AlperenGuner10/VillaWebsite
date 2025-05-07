using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.DTO.Dtos.FeatureDtos
{
	public class ResultFeatureDto
	{
		public int FeatureId { get; set; }
		public string Title { get; set; }
		public string Subtitle { get; set; }
		public string ImageUrl { get; set; }
		public string Square { get; set; }
		public string Contract { get; set; }
		public string Safety { get; set; }
	}
}

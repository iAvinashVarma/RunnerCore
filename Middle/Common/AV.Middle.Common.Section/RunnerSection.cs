using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace AV.Middle.Common.Section
{
	public class RunnerSection
	{
		[JsonIgnore]
		[JsonProperty(PropertyName = "postRunner")]
		public PostRunner PostRunner { get; set; }

		[JsonRequired]
		[JsonProperty(PropertyName = "runner")]
		public Runner Runner { get; set; }

		[JsonIgnore]
		[JsonProperty(PropertyName = "preRunner")]
		public PreRunner PreRunner { get; set; }
	}

	public class PostRunner
	{
		[JsonProperty(PropertyName = "add")]
		public List<Add> Add { get; set; }
	}

	public class PreRunner
	{
		[JsonProperty(PropertyName = "add")]
		public List<Add> Add { get; set; }
	}

	public class Runner
	{
		[JsonProperty(PropertyName = "add")]
		public List<Add> Add { get; set; }
	}

	public class Add
	{
		[JsonRequired]
		[JsonProperty(PropertyName = "process")]
		public string Process { get; set; }

		[JsonRequired]
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[DefaultValue(false)]
		[JsonProperty(PropertyName = "enable")]
		public bool Enable { get; set; }

		[DefaultValue(0)]
		[JsonProperty(PropertyName = "sequence")]
		public int Sequence { get; set; }
	}
}
﻿using System.Runtime.Serialization;
using Elasticsearch.Net;


namespace Nest
{
	[StringEnum]
	public enum RollupMetric
	{
		[EnumMember(Value = "min")] Min,
		[EnumMember(Value = "max")] Max,
		[EnumMember(Value = "sum")] Sum,
		[EnumMember(Value = "avg")] Average,
		[EnumMember(Value = "value_count")] ValueCount
	}
}

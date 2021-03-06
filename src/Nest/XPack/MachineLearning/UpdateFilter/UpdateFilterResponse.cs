﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	/// <summary>
	/// The response from updating a machine learning filter.
	/// </summary>
	public class UpdateFilterResponse : ResponseBase
	{
		[DataMember(Name = "description")]
		public string Description { get; internal set; }

		[DataMember(Name = "filter_id")]
		public string FilterId { get; internal set; }

		[DataMember(Name = "items")]
		public IReadOnlyCollection<string> Items { get; internal set; } = EmptyReadOnly<string>.Collection;
	}
}

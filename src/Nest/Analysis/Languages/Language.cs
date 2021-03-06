﻿using Elasticsearch.Net;


namespace Nest
{
	/// <summary>
	/// Language types used for language analyzers
	/// </summary>
	[StringEnum]
	public enum Language
	{
		Arabic,
		Armenian,
		Basque,
		Brazilian,
		Bulgarian,
		Catalan,
		Chinese,
		Cjk,
		Czech,
		Danish,
		Dutch,
		English,
		/// <summary>Available in Elasticsearch 7.6.0+</summary>
		Estonian,
		Finnish,
		French,
		Galician,
		German,
		Greek,
		Hindi,
		Hungarian,
		Indonesian,
		Irish,
		Italian,
		Latvian,
		Norwegian,
		Persian,
		Portuguese,
		Romanian,
		Russian,
		Sorani,
		Spanish,
		Swedish,
		Turkish,
		Thai
	}
}

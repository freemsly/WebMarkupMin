﻿using System.Collections.Generic;

using WebMarkupMin.AspNet.Common.Compressors;

namespace WebMarkupMin.AspNetCore1
{
	/// <summary>
	/// HTTP compression options
	/// </summary>
	public sealed class HttpCompressionOptions
	{
		/// <summary>
		/// Gets or sets a list of HTTP compressor factories
		/// </summary>
		public IList<ICompressorFactory> CompressorFactories
		{
			get;
			set;
		}


		/// <summary>
		/// Constructs a instance of HTTP compression options
		/// </summary>
		public HttpCompressionOptions()
		{
			CompressorFactories = new List<ICompressorFactory>
			{
				new DeflateCompressorFactory(),
				new GZipCompressorFactory()
			};
		}
	}
}
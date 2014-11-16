﻿using Sitecore.Data;
using Synthesis.FieldTypes.Interfaces;

namespace Synthesis.Testing
{
	public abstract class TestFieldType : IFieldType
	{
		public abstract bool HasValue { get; }

		public ID Id
		{
			get { return ID.Null; }
		}
	}
}
using System;
using JetBrains.Annotations;

namespace NLogInjector
{
	[MeansImplicitUse, AttributeUsage(AttributeTargets.Field)]
	public class InjectLogger : Attribute
	{
		
	}
}
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Domain.Models.Extensions
{
    public static class EnumExtensions
	{
		public static string GetDescription(this Enum @enum)
		{
			var attribute =
				@enum.GetType()
					.GetTypeInfo()
					.GetMember(@enum.ToString())
					.FirstOrDefault(member => member.MemberType == MemberTypes.Field)
					.GetCustomAttributes(typeof(DescriptionAttribute), false)
					.SingleOrDefault()
					as DescriptionAttribute;

			return attribute?.Description ?? @enum.ToString();
		}
	}
}

﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace L23_C02_asp_net_core_app_final.Validation
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class DifferentValueAttribute: ValidationAttribute
	{
		public string OtherProperty { get; set; }

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			PropertyInfo otherPropertyInfo = validationContext.ObjectType.GetProperty(OtherProperty);
			if (otherPropertyInfo == null)
			{
				return new ValidationResult($"Cannot find the property with name \"{OtherProperty}\"");
			}

			object otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);
			if (Equals(value, otherPropertyValue))
			{
				return new ValidationResult($"{validationContext.MemberName} shouldn't be the same as {OtherProperty}.");
			}	

			return ValidationResult.Success;
		}


	}
}

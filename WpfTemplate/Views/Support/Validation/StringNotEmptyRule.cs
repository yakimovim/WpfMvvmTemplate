﻿using System.Globalization;
using System.Windows.Controls;
using WpfTemplate.Properties;

namespace WpfTemplate.Views.Support.Validation
{
    public class StringNotEmptyRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var text = value as string;

            return string.IsNullOrWhiteSpace(text)
                ? new ValidationResult(false, Resources.NameCantBeEmpty)
                : new ValidationResult(true, null);
        }
    }
}

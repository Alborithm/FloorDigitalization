using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace FloorDigitalization.Helpers;

public class PropertyByNameConverter : IMultiValueConverter
{
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values.Count != 2)
            return null;

        var target = values[0];
        var propertyName = values[1] as string;

        if (target == null || string.IsNullOrWhiteSpace(propertyName))
            return null;

        var prop = target.GetType().GetProperty(propertyName);
        return prop?.GetValue(target);
    }

    public object? ConvertBack(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        // TwoWay support
        var newValue = values[0];
        var target = values[1];
        var propertyName = parameter as string;

        if (target != null && propertyName != null)
        {
            var prop = target.GetType().GetProperty(propertyName);
            prop?.SetValue(target, newValue);
        }

        return AvaloniaProperty.UnsetValue;
    }
}

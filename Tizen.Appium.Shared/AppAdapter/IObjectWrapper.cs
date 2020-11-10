using System;
using System.Collections.Generic;
using System.Reflection;

namespace Tizen.Appium
{
    public interface IObjectWrapper
    {
        string Id { get; }

        Geometry Geometry { get; }

        string Text { get; }

        bool IsFocused { get; }

        bool IsShown { get; }

        Type Type { get; }

        event EventHandler Deleted;

        bool HasProperty(string propertyName);

        object GetPropertyValue(string propertyName);

        IEnumerable<PropertyInfo> GetAllProperties();

        bool SetPropertyValue(string propertyName, object value);

        bool ContainsText(string text);

        bool EqualsTo(object obj);
    }
}

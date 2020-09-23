using System;
using System.Collections.Generic;

namespace Tizen.Appium
{
    public interface IObjectWrapper
    {
        string Id { get; }

        Geometry Geometry { get; }

        string Text { get; }

        bool IsFocused { get; }

        bool IsShown { get; }

        event EventHandler Deleted;

        bool HasProperty(string propertyName);

        object GetPropertyValue(string propertyName);

        IEnumerable<string> GetPropertyNames();

        bool SetPropertyValue(string propertyName, object value);

        bool ContainsText(string text);

        bool EqualsTo(object obj);
    }
}

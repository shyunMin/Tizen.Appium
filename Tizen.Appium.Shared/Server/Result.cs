using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Tizen.Appium
{
    public class Result
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        public Result()
        {
            Status = 0;
            Value = String.Empty;
        }

        public class Element
        {
            [JsonProperty("ELEMENT")]
            public string Id { get; set; }

            public Element(string id = "")
            {
                Id = id;
            }
        }

        //public class PropertyInfo
        //{
        //    [JsonProperty("property")]
        //    public string Name { get; set; }

        //    public PropertyInfo(string name)
        //    {
        //        Name = name;
        //    }
        //}

        public class ElementInfo
        {
            [JsonProperty("elementId")]
            public string ElementId { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            public ElementInfo(string id, Type type)
            {
                ElementId = id;
                Type = type?.ToString() ?? "";
            }

            public override string ToString()
            {
                return "ElementId=" + ElementId + ", Type=" + Type;
            }
        }

        public class PropertyInfo
        {
            [JsonProperty("property")]
            public string Name { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }

            public PropertyInfo(string name, object value)
            {
                Name = name;
                Value = (value != null) ? value.ToString() : "";
            }

            public override string ToString()
            {
                return "Name=" + Name + ", Value=" + Value;
            }
        }

        public class Size
        {
            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; }

            public Size(int width = 0, int height = 0)
            {
                Width = width;
                Height = height;
            }
            public override string ToString()
            {
                return "Width=" + Width + ", Height=" + Height;
            }
        }
        public class Location
        {
            [JsonProperty("x")]
            public int X { get; set; }

            [JsonProperty("y")]
            public int Y { get; set; }

            public Location(int x = 0, int y = 0)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return "X=" + X + ", Y=" + Y;
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

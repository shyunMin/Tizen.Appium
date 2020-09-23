using System.Collections.Generic;

namespace Tizen.Appium
{
    public class GetAttributeNamesCommand : ICommand
    {
        public string Command => Commands.GetAttributeNames;

        public Result Run(Request req, IObjectList objectList, IInputGenerator inputGen)
        {
            Log.Debug("Run: GetAllAttributes");

            var elementId = req.Params.ElementId;
            var propertyName = req.Params.Attribute;

            var result = new Result();
            var list =  objectList.Get(elementId)?.GetPropertyNames();

            result.Value = list;
            return result;
        }
    }
}

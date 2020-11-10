using System.Collections.Generic;

namespace Tizen.Appium
{
    public class GetAllAttributesCommand : ICommand
    {
        public string Command => Commands.GetAllAttributes;

        public Result Run(Request req, IObjectList objectList, IInputGenerator inputGen)
        {
            Log.Debug("Run: GetAllAttributes");

            var elementId = req.Params.ElementId;
            var propertyName = req.Params.Attribute;

            var result = new Result();
            var list =  objectList.Get(elementId)?.GetAllProperties();

            result.Value = list;
            return result;
        }
    }
}

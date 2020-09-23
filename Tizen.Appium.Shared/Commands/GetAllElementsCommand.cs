using System.Collections.Generic;

namespace Tizen.Appium
{
    public class GetAllElementsCommand : ICommand
    {
        public string Command => Commands.GetAllElements;

        public Result Run(Request req, IObjectList objectList, IInputGenerator inputGen)
        {
            Log.Debug("Run: GetAllElements");

            var result = new Result();
            List<Result.Element> list = new List<Result.Element>();
            var elementIds = objectList.GetAllElements();

            foreach (var id in elementIds)
            {
                list.Add(new Result.Element(id));
            }

            result.Value = list;
            return result;
        }
    }
}

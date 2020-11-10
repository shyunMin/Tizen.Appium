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
            List<Result.ElementInfo> list = new List<Result.ElementInfo>();
            var elements = objectList.GetAllElements();

            foreach (var element in elements)
            {
                list.Add(new Result.ElementInfo(element.Id, element.Type));
            }

            result.Value = list;
            return result;
        }
    }
}

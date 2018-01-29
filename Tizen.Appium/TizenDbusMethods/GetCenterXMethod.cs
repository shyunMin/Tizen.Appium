using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using Tizen.Appium.Dbus;

namespace Tizen.Appium
{
    public class GetCenterXMethod : IDbusMethod
    {
        public string Name => MethodNames.GetCenterX;

        public string Signature => "s";

        public string ReturnSignature => "i";

        public string[] Args => new string[] { Params.ElementId };

        public Arguments Run(Arguments args)
        {
            Log.Debug(TizenAppium.Tag, "#### GetCenterX");

            var elementId = (string)args[Params.ElementId];
            var ret = new Arguments();

            var ve = ElementUtils.GetTestableElement(elementId) as VisualElement;
            if (ve == null)
            {
                Log.Debug(TizenAppium.Tag, "#### Not Found Element");
                ret.SetArgument(Params.Return, -1);
                return ret;
            }

            var nativeView = Platform.GetOrCreateRenderer(ve).NativeView;
            var x = nativeView.Geometry.X + (nativeView.Geometry.Width / 2);

            ret.SetArgument(Params.Return, x);

            return ret;
        }
    }
}

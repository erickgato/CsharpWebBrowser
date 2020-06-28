using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpWebView
{
    public static class Extensions
    {
        public static T Clone<T>(this T controlToClone)
                where T: Control
        {
            PropertyInfo[] propriedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            T Instance = Activator.CreateInstance<T>();
            foreach(PropertyInfo Propriedade in propriedades)
            {
                if (Propriedade.CanWrite)
                {
                    if (Propriedade.Name != "WindowTarget")
                        Propriedade.SetValue(Instance, Propriedade.GetValue(controlToClone, null), null);
                }
            }
            return Instance;
        }
    }
}

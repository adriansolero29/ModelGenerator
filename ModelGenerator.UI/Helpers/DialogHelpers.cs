using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelGenerator.UI.Helpers
{
    public static class DialogHelpers
    {
        public static Form ShowDialog<T>(IServiceProvider provider)
        {
            return provider.GetService(typeof(T)) as Form;
        }
    }
}

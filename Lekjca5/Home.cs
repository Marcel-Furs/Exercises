using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja5
{
    internal class Home
    {
        public event Action OnWindowOpen;

        public void OpenWindow()
        {
            OnWindowOpen?.Invoke();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomMdTest
{
    public class MyMasterDetailPage : MasterDetailPage
    {
        public static readonly BindableProperty DrawerWidthProperty = BindableProperty.Create<MyMasterDetailPage, int>(p => p.DrawerWidth, default(int));

        public int DrawerWidth
        {
            get { return (int)GetValue(DrawerWidthProperty); }
            set { SetValue(DrawerWidthProperty, value); }
        }
    }
}

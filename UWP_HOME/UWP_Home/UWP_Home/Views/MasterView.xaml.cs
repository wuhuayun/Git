using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP_Home.Models;
// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UWP_Home.Views
{
    public sealed partial class MasterView : Page
    {
        public List<HelloWorld> aa { get; } = new List<HelloWorld>();
        public MasterView()
        {
            this.InitializeComponent();         
                 gethello();
            this.DataContext = this;
        }
        public void gethello() {          
            aa.Add(new HelloWorld { Title = "中国", ImagePath = "http://www.pp3.cn/uploads/allimg/111110/15563RI9-7.jpg" });
            aa.Add(new HelloWorld{ Title = "美国", ImagePath = "http://www.pp3.cn/uploads/allimg/111110/15594T106-10.jpg" });
            aa.Add(new HelloWorld { Title = "荷兰", ImagePath = "http://img5.imgtn.bdimg.com/it/u=1024114254,2934610037&fm=206&gp=0.jpg" });

        }
       
    }

}

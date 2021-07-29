using System;
using System.Collections.Generic;
using System.Linq;
using New.View;
using Xamarin.Forms;

namespace New
{
    public partial class MainShell
    {
        public MainShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("articleview", typeof(ArticleView));
        }
    }
}
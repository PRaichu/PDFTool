using DSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFToolPlug
{
    public partial class tableBtnTemplate : DSkinGridListCellTemplate
    {
        public tableBtnTemplate()
        {
            InitializeComponent();
        }

        public tableBtnTemplate(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

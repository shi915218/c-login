using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GovDocSearch.cc.topware.form.comp
{
    public partial class DataLabel : Label
    {
        public Dictionary<string, object> data { get; set; }
        public DataLabel()
        {
            InitializeComponent();
        }

        public DataLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string getAttr(string key)
        {
            return data["name"].ToString();
        }
        public string getAttrType(string key)
        {
            return data["type"].ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.EventArguments;
using View;

namespace ProjectSecurity
{
    public partial class SettingCaeserCoder : Form, ISetting
    {
        public event EventHandler<ApplySettingEventArgs> ApplySetting = delegate { };

        public SettingCaeserCoder()
        {
            InitializeComponent();
        }
        
        private void btnOkClick(object sender, EventArgs e)
        {
            var key1 = Convert.ToInt32(textBoxKey1.Text);
            var key2 = Convert.ToInt32(textBoxKey2.Text);
            ApplySetting(this, new ApplySettingEventArgs(key1, key2));
        }
    }
}

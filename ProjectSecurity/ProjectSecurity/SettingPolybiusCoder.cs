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
    public partial class SettingPolybiusCoder : Form, ISetting
    {
        public event EventHandler<ApplySettingEventArgs> ApplySetting = delegate { };

        public SettingPolybiusCoder(string passwordKey)
        {
            InitializeComponent();
            textBoxPasswordKey.Text = passwordKey;
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            ApplySetting(this, new ApplySettingEventArgs(textBoxPasswordKey.Text));
        }
    }
}

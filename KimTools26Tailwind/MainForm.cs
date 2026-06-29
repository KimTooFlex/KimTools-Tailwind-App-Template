using System;
using KimTools.WinForms;

namespace KimTools26Tailwind
{
    public partial class MainForm : KtWindow
    {
        public MainForm() => InitializeComponent();

        /// <summary>
        /// Handles the CheckedChanged event of the ktRadioButtonLightMode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ktRadioButtonLightMode_CheckedChanged(object sender, System.EventArgs e)
            => KtColor.LightMode(ktRadioButtonLightMode.Checked);


    }
}

using Crash;
using System.Drawing;
using System.Windows.Forms;

namespace CrashEdit
{
    public sealed class OldSLSTDeltaBox : UserControl
    {
        private ListBox lstValues;

        public OldSLSTDeltaBox(OldSLSTDelta slstitem)
        {
            lstValues = new ListBox
            {
                Dock = DockStyle.Fill
            };
            lstValues.BackColor = Color.FromArgb(30, 30, 30);
            lstValues.ForeColor = Color.FromArgb(220, 220, 220);
            lstValues.BorderStyle = BorderStyle.None;
            lstValues.Items.Add(string.Format("Type: {0}",1));
            lstValues.Items.Add(string.Format("Remove Nodes: {0}",slstitem.RemoveNodes.Count));
            lstValues.Items.Add(string.Format("Add Nodes: {0}",slstitem.AddNodes.Count));
            lstValues.Items.Add(string.Format("Swap Nodes: {0}",slstitem.SwapNodes.Count));
            Controls.Add(lstValues);
        }
    }
}

using System.Windows.Forms;

namespace OverrideControls
{
    public class ToolStripOverride : ToolStripProfessionalRenderer
    {
        public ToolStripOverride() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
    }
}

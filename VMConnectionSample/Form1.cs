using System;
using System.Windows.Forms;

namespace VMConnectionSample
{
    public partial class Form1 : Form
    {
        private AxMSTSCLib.AxMsRdpClient9NotSafeForScripting rdpClient;

        public Form1()
        {
            InitializeComponent();

            // Add the RDP client control.
            rdpClient = new AxMSTSCLib.AxMsRdpClient9NotSafeForScripting()
            {
                Location = labelPlaceholder.Location,
                Size = labelPlaceholder.Size,
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom
            };
            Controls.Add(rdpClient);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHostServer.Text)) return;
            if (string.IsNullOrWhiteSpace(textBoxVmId.Text)) return;

            // Authentication settings.
            rdpClient.AdvancedSettings9.EnableCredSspSupport = true;
            SetRdpClientCredentialsDelegation(true);
            rdpClient.AdvancedSettings9.NegotiateSecurityLayer = false;

            // Screen size settings.
            if (checkBoxEnableEnhancedSession.Checked)
            {
                rdpClient.DesktopWidth = decimal.ToInt32(numericUpDownScreenWidth.Value);
                rdpClient.DesktopHeight = decimal.ToInt32(numericUpDownScreenHeight.Value);
            }

            // Smart sizing settings.
            rdpClient.AdvancedSettings9.SmartSizing = checkBoxEnableSmartSizing.Checked;

            // Set the host server.
            rdpClient.Server = textBoxHostServer.Text;

            // VMM settings.
            rdpClient.AdvancedSettings9.AuthenticationServiceClass = "Microsoft Virtual Console Service";
            rdpClient.AdvancedSettings9.RDPPort = 2179;

            // Set the information of the connection destination VM.
            SetPcb(textBoxVmId.Text, checkBoxEnableEnhancedSession.Checked);

            // Connect to the VM.
            rdpClient.Connect();
        }

        private void SetRdpClientCredentialsDelegation(bool enable)
        {
            MSTSCLib.IMsRdpExtendedSettings settings = (MSTSCLib.IMsRdpExtendedSettings)rdpClient.GetOcx();
            object value = enable;
            settings.set_Property("DisableCredentialsDelegation", ref value);
        }

        private void SetPcb(string vmIdGuid, bool isEnableEnhancedSession)
        {
            const string PcbEnhancedSessionString = "EnhancedMode=1";

            if (isEnableEnhancedSession)
            {
                rdpClient.AdvancedSettings9.PCB = string.Format("{0};{1}", vmIdGuid, PcbEnhancedSessionString);
            }
            else
            {
                rdpClient.AdvancedSettings9.PCB = vmIdGuid;
            }
        }
    }
}

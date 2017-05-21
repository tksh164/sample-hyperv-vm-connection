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

            // Assign event handlers.
            AssignEventHandlers();

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

        private void AssignEventHandlers()
        {
            rdpClient.OnConnecting += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnConnecting" + Environment.NewLine;
            };

            rdpClient.OnConnected += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnConnected" + Environment.NewLine;
            };

            rdpClient.OnLoginComplete += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnLoginComplete" + Environment.NewLine;
            };

            rdpClient.OnDisconnected += (object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e) =>
            {
                textBoxLogMessage.Text += "OnDisconnected" + Environment.NewLine;
            };

            rdpClient.OnEnterFullScreenMode += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnEnterFullScreenMode" + Environment.NewLine;
            };

            rdpClient.OnLeaveFullScreenMode += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnLeaveFullScreenMode" + Environment.NewLine;
            };

            rdpClient.OnChannelReceivedData += (object sender, AxMSTSCLib.IMsTscAxEvents_OnChannelReceivedDataEvent e) =>
            {
                textBoxLogMessage.Text += "OnChannelReceivedData" + Environment.NewLine;
            };

            rdpClient.OnRequestGoFullScreen += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnRequestGoFullScreen" + Environment.NewLine;
            };

            rdpClient.OnRequestLeaveFullScreen += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnRequestLeaveFullScreen" + Environment.NewLine;
            };

            rdpClient.OnFatalError += (object sender, AxMSTSCLib.IMsTscAxEvents_OnFatalErrorEvent e) =>
            {
                textBoxLogMessage.Text += "OnFatalError" + Environment.NewLine;
            };

            rdpClient.OnWarning += (object sender, AxMSTSCLib.IMsTscAxEvents_OnWarningEvent e) =>
            {
                textBoxLogMessage.Text += "OnWarning" + Environment.NewLine;
            };

            rdpClient.OnRemoteDesktopSizeChange += (object sender, AxMSTSCLib.IMsTscAxEvents_OnRemoteDesktopSizeChangeEvent e) =>
            {
                textBoxLogMessage.Text += "OnRemoteDesktopSizeChange" + Environment.NewLine;
            };

            rdpClient.OnIdleTimeoutNotification += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnIdleTimeoutNotification" + Environment.NewLine;
            };

            rdpClient.OnRequestContainerMinimize += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnRequestContainerMinimize" + Environment.NewLine;
            };

            rdpClient.OnConfirmClose += (object sender, AxMSTSCLib.IMsTscAxEvents_OnConfirmCloseEvent e) =>
            {
                textBoxLogMessage.Text += "OnConfirmClose" + Environment.NewLine;
            };

            rdpClient.OnReceivedTSPublicKey += (object sender, AxMSTSCLib.IMsTscAxEvents_OnReceivedTSPublicKeyEvent e) =>
            {
                textBoxLogMessage.Text += "OnReceivedTSPublicKey" + Environment.NewLine;
            };

            rdpClient.OnAutoReconnecting += (object sender, AxMSTSCLib.IMsTscAxEvents_OnAutoReconnectingEvent e) =>
            {
                textBoxLogMessage.Text += "OnAutoReconnecting" + Environment.NewLine;
            };

            rdpClient.OnAuthenticationWarningDisplayed += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnAuthenticationWarningDisplayed" + Environment.NewLine;
            };

            rdpClient.OnAuthenticationWarningDismissed += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnAuthenticationWarningDismissed" + Environment.NewLine;
            };

            rdpClient.OnRemoteProgramResult += (object sender, AxMSTSCLib.IMsTscAxEvents_OnRemoteProgramResultEvent e) =>
            {
                textBoxLogMessage.Text += "OnRemoteProgramResult" + Environment.NewLine;
            };

            rdpClient.OnRemoteProgramDisplayed += (object sender, AxMSTSCLib.IMsTscAxEvents_OnRemoteProgramDisplayedEvent e) =>
            {
                textBoxLogMessage.Text += "OnRemoteProgramDisplayed" + Environment.NewLine;
            };

            rdpClient.OnRemoteWindowDisplayed += (object sender, AxMSTSCLib.IMsTscAxEvents_OnRemoteWindowDisplayedEvent e) =>
            {
                textBoxLogMessage.Text += "OnRemoteWindowDisplayed" + Environment.NewLine;
            };

            rdpClient.OnLogonError += (object sender, AxMSTSCLib.IMsTscAxEvents_OnLogonErrorEvent e) =>
            {
                textBoxLogMessage.Text += "OnLogonError" + Environment.NewLine;
            };

            rdpClient.OnFocusReleased += (object sender, AxMSTSCLib.IMsTscAxEvents_OnFocusReleasedEvent e) =>
            {
                textBoxLogMessage.Text += "OnFocusReleased" + Environment.NewLine;
            };

            rdpClient.OnUserNameAcquired += (object sender, AxMSTSCLib.IMsTscAxEvents_OnUserNameAcquiredEvent e) =>
            {
                textBoxLogMessage.Text += "OnUserNameAcquired" + Environment.NewLine;
            };

            rdpClient.OnMouseInputModeChanged += (object sender, AxMSTSCLib.IMsTscAxEvents_OnMouseInputModeChangedEvent e) =>
            {
                textBoxLogMessage.Text += "OnMouseInputModeChanged" + Environment.NewLine;
            };

            rdpClient.OnServiceMessageReceived += (object sender, AxMSTSCLib.IMsTscAxEvents_OnServiceMessageReceivedEvent e) =>
            {
                textBoxLogMessage.Text += "OnServiceMessageReceived" + Environment.NewLine;
            };

            rdpClient.OnConnectionBarPullDown += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnConnectionBarPullDown" + Environment.NewLine;
            };

            rdpClient.OnNetworkStatusChanged += (object sender, AxMSTSCLib.IMsTscAxEvents_OnNetworkStatusChangedEvent e) =>
            {
                textBoxLogMessage.Text += "OnNetworkStatusChanged" + Environment.NewLine;
            };

            rdpClient.OnDevicesButtonPressed += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnDevicesButtonPressed" + Environment.NewLine;
            };

            rdpClient.OnAutoReconnected += (sender, e) =>
            {
                textBoxLogMessage.Text += "OnAutoReconnected" + Environment.NewLine;
            };

            rdpClient.OnAutoReconnecting2 += (object sender, AxMSTSCLib.IMsTscAxEvents_OnAutoReconnecting2Event e) =>
            {
                textBoxLogMessage.Text += "OnAutoReconnecting2" + Environment.NewLine;
            };
        }
    }
}

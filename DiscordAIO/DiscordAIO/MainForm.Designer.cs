namespace DiscordAIO
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.xylosTabControl1 = new XylosTabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.comboScraperSSL = new XylosCombobox();
            this.label71 = new System.Windows.Forms.Label();
            this.lblScraperLastUpdated = new System.Windows.Forms.Label();
            this.lblScraperProxiesFetched = new System.Windows.Forms.Label();
            this.btnScraperSaveProxies = new XylosButton();
            this.btnScraperCopyToClipboard = new XylosButton();
            this.btnScraperFetch = new XylosButton();
            this.label43 = new System.Windows.Forms.Label();
            this.txtScraperTimeout = new XylosTextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.comboScraperAnonymity = new XylosCombobox();
            this.label41 = new System.Windows.Forms.Label();
            this.comboScraperCountry = new XylosCombobox();
            this.label40 = new System.Windows.Forms.Label();
            this.comboScraperType = new XylosCombobox();
            this.label39 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTokenCheckerVerified = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboCheckerType = new XylosCombobox();
            this.txtCheckerTimeout = new XylosTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCheckerRetries = new System.Windows.Forms.Label();
            this.chkCheckerUseProxies = new XylosCheckBox();
            this.btnTokenCheckerStop = new XylosButton();
            this.btnTokenCheckerStart = new XylosButton();
            this.txtTokenCheckerThreads = new XylosTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTokenCheckerInvalid = new System.Windows.Forms.Label();
            this.lblTokenCheckerUnverified = new System.Windows.Forms.Label();
            this.lblTokenCheckerProxies = new System.Windows.Forms.Label();
            this.lblTokenCheckerTokens = new System.Windows.Forms.Label();
            this.btnTokenCheckerLoadProxies = new XylosButton();
            this.btnCheckerLoadTokens = new XylosButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label49 = new System.Windows.Forms.Label();
            this.txtJoinerDelay = new XylosTextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboJoinerType = new XylosCombobox();
            this.txtJoinerTimeout = new XylosTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblUsersJoined = new System.Windows.Forms.Label();
            this.txtJoinerCode = new XylosTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnJoinerStop = new XylosButton();
            this.btnJoinerStart = new XylosButton();
            this.chkJoinerUseProxies = new XylosCheckBox();
            this.txtJoinerThreads = new XylosTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnJoinerLoadProxies = new XylosButton();
            this.btnJoinerLoadTokens = new XylosButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label50 = new System.Windows.Forms.Label();
            this.txtLeaverDelay = new XylosTextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.comboLeaverType = new XylosCombobox();
            this.txtLeaverTimeout = new XylosTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblUsersLeft = new System.Windows.Forms.Label();
            this.txtLeaverServer = new XylosTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLeaverStop = new XylosButton();
            this.btnLeaverStart = new XylosButton();
            this.chkLeaverUseProxies = new XylosCheckBox();
            this.txtLeaverThreads = new XylosTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLeaverLoadProxies = new XylosButton();
            this.btnLeaverLoadTokens = new XylosButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label53 = new System.Windows.Forms.Label();
            this.txtSpammerDelay = new XylosTextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.comboSpammerType = new XylosCombobox();
            this.txtSpammerTimeout = new XylosTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblMessagesSent = new System.Windows.Forms.Label();
            this.txtSpammerChannel = new XylosTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpammerMessages = new XylosTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSpammerLoadMessages = new XylosButton();
            this.chkSpammerUseProxies = new XylosCheckBox();
            this.btnSpammerStop = new XylosButton();
            this.btnSpammerStart = new XylosButton();
            this.txtSpammerThreads = new XylosTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpammerLoadProxies = new XylosButton();
            this.btnSpammerLoadTokens = new XylosButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label54 = new System.Windows.Forms.Label();
            this.txtDMDelay = new XylosTextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.lblDMSent = new System.Windows.Forms.Label();
            this.btnDMLoadMessages = new XylosButton();
            this.txtDMUserId = new XylosTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboDMType = new XylosCombobox();
            this.txtDMTimeout = new XylosTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.btnDMStop = new XylosButton();
            this.btnDMStart = new XylosButton();
            this.chkDMUseProxies = new XylosCheckBox();
            this.txtDMThreads = new XylosTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.btnDMLoadProxies = new XylosButton();
            this.btnDMLoadTokens = new XylosButton();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.label70 = new System.Windows.Forms.Label();
            this.txtNicknameServer = new XylosTextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.txtNicknameDelay = new XylosTextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.lblChanged = new System.Windows.Forms.Label();
            this.txtNickname = new XylosTextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.comboNicknameType = new XylosCombobox();
            this.txtNicknameTimeout = new XylosTextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.btnNicknameStop = new XylosButton();
            this.btnNicknameStart = new XylosButton();
            this.chkNicknameUseProxies = new XylosCheckBox();
            this.txtNicknameThreads = new XylosTextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.btnNicknameLoadProxies = new XylosButton();
            this.btnNicknameLoadTokens = new XylosButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label56 = new System.Windows.Forms.Label();
            this.txtFriendDelay = new XylosTextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.lblRemoved = new System.Windows.Forms.Label();
            this.lblAdded = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboFriendType = new XylosCombobox();
            this.txtFriendTimeout = new XylosTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.radioRemoveFriend = new XylosRadioButton();
            this.radioAddFriend = new XylosRadioButton();
            this.txtFriendUser = new XylosTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFriendStop = new XylosButton();
            this.btnFriendStart = new XylosButton();
            this.chkFriendUseProxies = new XylosCheckBox();
            this.txtFriendThreads = new XylosTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFriendLoadProxies = new XylosButton();
            this.btnFriendLoadTokens = new XylosButton();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lblReactionRemoved = new System.Windows.Forms.Label();
            this.radioRemoveReaction = new XylosRadioButton();
            this.radioAddReaction = new XylosRadioButton();
            this.label58 = new System.Windows.Forms.Label();
            this.txtReactionDelay = new XylosTextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.lblReactionAdded = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.comboReactionType = new XylosCombobox();
            this.txtReactionTimeout = new XylosTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtReactionEmoji = new XylosTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtReactionMessage = new XylosTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReactionChannel = new XylosTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReactionStop = new XylosButton();
            this.btnReactionStart = new XylosButton();
            this.chkReactionUseProxies = new XylosCheckBox();
            this.txtReactionThreads = new XylosTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnReactionLoadProxies = new XylosButton();
            this.btnReactionLoadTokens = new XylosButton();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label60 = new System.Windows.Forms.Label();
            this.txtTypingDelay = new XylosTextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.lblTyping = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.comboTypingType = new XylosCombobox();
            this.txtTypingTimeout = new XylosTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtTypingChannel = new XylosTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTypingStop = new XylosButton();
            this.btnTypingStart = new XylosButton();
            this.chkTypingUseProxies = new XylosCheckBox();
            this.txtTypingThreads = new XylosTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTypingLoadProxies = new XylosButton();
            this.btnTypingLoadTokens = new XylosButton();
            this.xylosTabControl1.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // xylosTabControl1
            // 
            this.xylosTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.xylosTabControl1.Controls.Add(this.tabPage9);
            this.xylosTabControl1.Controls.Add(this.tabPage1);
            this.xylosTabControl1.Controls.Add(this.tabPage4);
            this.xylosTabControl1.Controls.Add(this.tabPage5);
            this.xylosTabControl1.Controls.Add(this.tabPage2);
            this.xylosTabControl1.Controls.Add(this.tabPage3);
            this.xylosTabControl1.Controls.Add(this.tabPage10);
            this.xylosTabControl1.Controls.Add(this.tabPage6);
            this.xylosTabControl1.Controls.Add(this.tabPage7);
            this.xylosTabControl1.Controls.Add(this.tabPage8);
            this.xylosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xylosTabControl1.FirstHeaderBorder = false;
            this.xylosTabControl1.ItemSize = new System.Drawing.Size(40, 180);
            this.xylosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xylosTabControl1.Multiline = true;
            this.xylosTabControl1.Name = "xylosTabControl1";
            this.xylosTabControl1.SelectedIndex = 0;
            this.xylosTabControl1.Size = new System.Drawing.Size(413, 484);
            this.xylosTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.xylosTabControl1.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.White;
            this.tabPage9.Controls.Add(this.comboScraperSSL);
            this.tabPage9.Controls.Add(this.label71);
            this.tabPage9.Controls.Add(this.lblScraperLastUpdated);
            this.tabPage9.Controls.Add(this.lblScraperProxiesFetched);
            this.tabPage9.Controls.Add(this.btnScraperSaveProxies);
            this.tabPage9.Controls.Add(this.btnScraperCopyToClipboard);
            this.tabPage9.Controls.Add(this.btnScraperFetch);
            this.tabPage9.Controls.Add(this.label43);
            this.tabPage9.Controls.Add(this.txtScraperTimeout);
            this.tabPage9.Controls.Add(this.label42);
            this.tabPage9.Controls.Add(this.comboScraperAnonymity);
            this.tabPage9.Controls.Add(this.label41);
            this.tabPage9.Controls.Add(this.comboScraperCountry);
            this.tabPage9.Controls.Add(this.label40);
            this.tabPage9.Controls.Add(this.comboScraperType);
            this.tabPage9.Controls.Add(this.label39);
            this.tabPage9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage9.Location = new System.Drawing.Point(184, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(225, 476);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Proxy Scraper";
            // 
            // comboScraperSSL
            // 
            this.comboScraperSSL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboScraperSSL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboScraperSSL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboScraperSSL.EnabledCalc = true;
            this.comboScraperSSL.FormattingEnabled = true;
            this.comboScraperSSL.ItemHeight = 20;
            this.comboScraperSSL.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboScraperSSL.Location = new System.Drawing.Point(81, 105);
            this.comboScraperSSL.Name = "comboScraperSSL";
            this.comboScraperSSL.Size = new System.Drawing.Size(130, 26);
            this.comboScraperSSL.TabIndex = 80;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(6, 110);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(28, 15);
            this.label71.TabIndex = 79;
            this.label71.Text = "SSL:";
            // 
            // lblScraperLastUpdated
            // 
            this.lblScraperLastUpdated.AutoSize = true;
            this.lblScraperLastUpdated.Location = new System.Drawing.Point(78, 218);
            this.lblScraperLastUpdated.Name = "lblScraperLastUpdated";
            this.lblScraperLastUpdated.Size = new System.Drawing.Size(113, 15);
            this.lblScraperLastUpdated.TabIndex = 78;
            this.lblScraperLastUpdated.Text = "Last Updated: Never";
            // 
            // lblScraperProxiesFetched
            // 
            this.lblScraperProxiesFetched.AutoSize = true;
            this.lblScraperProxiesFetched.Location = new System.Drawing.Point(78, 198);
            this.lblScraperProxiesFetched.Name = "lblScraperProxiesFetched";
            this.lblScraperProxiesFetched.Size = new System.Drawing.Size(100, 15);
            this.lblScraperProxiesFetched.TabIndex = 77;
            this.lblScraperProxiesFetched.Text = "Proxies fetched: 0";
            // 
            // btnScraperSaveProxies
            // 
            this.btnScraperSaveProxies.EnabledCalc = true;
            this.btnScraperSaveProxies.Location = new System.Drawing.Point(81, 236);
            this.btnScraperSaveProxies.Name = "btnScraperSaveProxies";
            this.btnScraperSaveProxies.Size = new System.Drawing.Size(130, 23);
            this.btnScraperSaveProxies.TabIndex = 76;
            this.btnScraperSaveProxies.Text = "Save Proxies";
            this.btnScraperSaveProxies.Click += new XylosButton.ClickEventHandler(this.btnScraperSaveProxies_Click);
            // 
            // btnScraperCopyToClipboard
            // 
            this.btnScraperCopyToClipboard.EnabledCalc = true;
            this.btnScraperCopyToClipboard.Location = new System.Drawing.Point(81, 265);
            this.btnScraperCopyToClipboard.Name = "btnScraperCopyToClipboard";
            this.btnScraperCopyToClipboard.Size = new System.Drawing.Size(130, 23);
            this.btnScraperCopyToClipboard.TabIndex = 75;
            this.btnScraperCopyToClipboard.Text = "Copy to Clipboard";
            this.btnScraperCopyToClipboard.Click += new XylosButton.ClickEventHandler(this.btnScraperCopyToClipboard_Click);
            // 
            // btnScraperFetch
            // 
            this.btnScraperFetch.EnabledCalc = true;
            this.btnScraperFetch.Location = new System.Drawing.Point(81, 172);
            this.btnScraperFetch.Name = "btnScraperFetch";
            this.btnScraperFetch.Size = new System.Drawing.Size(130, 23);
            this.btnScraperFetch.TabIndex = 74;
            this.btnScraperFetch.Text = "Fetch";
            this.btnScraperFetch.Click += new XylosButton.ClickEventHandler(this.btnScraperFetch_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(188, 143);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(23, 15);
            this.label43.TabIndex = 73;
            this.label43.Text = "ms";
            // 
            // txtScraperTimeout
            // 
            this.txtScraperTimeout.EnabledCalc = true;
            this.txtScraperTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtScraperTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtScraperTimeout.Location = new System.Drawing.Point(81, 137);
            this.txtScraperTimeout.MaxLength = 32767;
            this.txtScraperTimeout.MultiLine = false;
            this.txtScraperTimeout.Name = "txtScraperTimeout";
            this.txtScraperTimeout.ReadOnly = false;
            this.txtScraperTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtScraperTimeout.TabIndex = 72;
            this.txtScraperTimeout.Text = "5000";
            this.txtScraperTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtScraperTimeout.UseSystemPasswordChar = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 143);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(54, 15);
            this.label42.TabIndex = 46;
            this.label42.Text = "Timeout:";
            // 
            // comboScraperAnonymity
            // 
            this.comboScraperAnonymity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboScraperAnonymity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboScraperAnonymity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboScraperAnonymity.EnabledCalc = true;
            this.comboScraperAnonymity.FormattingEnabled = true;
            this.comboScraperAnonymity.ItemHeight = 20;
            this.comboScraperAnonymity.Items.AddRange(new object[] {
            "All",
            "Elite",
            "Anonymous",
            "Transparent"});
            this.comboScraperAnonymity.Location = new System.Drawing.Point(81, 73);
            this.comboScraperAnonymity.Name = "comboScraperAnonymity";
            this.comboScraperAnonymity.Size = new System.Drawing.Size(130, 26);
            this.comboScraperAnonymity.TabIndex = 45;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 78);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(69, 15);
            this.label41.TabIndex = 44;
            this.label41.Text = "Anonymity:";
            // 
            // comboScraperCountry
            // 
            this.comboScraperCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboScraperCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboScraperCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboScraperCountry.EnabledCalc = true;
            this.comboScraperCountry.FormattingEnabled = true;
            this.comboScraperCountry.ItemHeight = 20;
            this.comboScraperCountry.Items.AddRange(new object[] {
            "All",
            "AL",
            "AM",
            "AR",
            "AU",
            "BD",
            "BG",
            "BR",
            "BW",
            "CA",
            "CL",
            "CN",
            "CO",
            "CZ",
            "DE",
            "EC",
            "ES",
            "FR",
            "GB",
            "GE",
            "HU",
            "ID",
            "IN",
            "IQ",
            "IR",
            "IT",
            "JP",
            "KE",
            "KH",
            "KZ",
            "MN",
            "MX",
            "NG",
            "NL",
            "NP",
            "PE",
            "PH",
            "PK",
            "PL",
            "RS",
            "RU",
            "SG",
            "TH",
            "TR",
            "UA",
            "US",
            "VE",
            "VN",
            "YE",
            "ZA"});
            this.comboScraperCountry.Location = new System.Drawing.Point(81, 41);
            this.comboScraperCountry.Name = "comboScraperCountry";
            this.comboScraperCountry.Size = new System.Drawing.Size(130, 26);
            this.comboScraperCountry.TabIndex = 43;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 46);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 15);
            this.label40.TabIndex = 42;
            this.label40.Text = "Country:";
            // 
            // comboScraperType
            // 
            this.comboScraperType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboScraperType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboScraperType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboScraperType.EnabledCalc = true;
            this.comboScraperType.FormattingEnabled = true;
            this.comboScraperType.ItemHeight = 20;
            this.comboScraperType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboScraperType.Location = new System.Drawing.Point(81, 9);
            this.comboScraperType.Name = "comboScraperType";
            this.comboScraperType.Size = new System.Drawing.Size(130, 26);
            this.comboScraperType.TabIndex = 41;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 14);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(34, 15);
            this.label39.TabIndex = 40;
            this.label39.Text = "Type:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblTokenCheckerVerified);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.comboCheckerType);
            this.tabPage1.Controls.Add(this.txtCheckerTimeout);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.lblCheckerRetries);
            this.tabPage1.Controls.Add(this.chkCheckerUseProxies);
            this.tabPage1.Controls.Add(this.btnTokenCheckerStop);
            this.tabPage1.Controls.Add(this.btnTokenCheckerStart);
            this.tabPage1.Controls.Add(this.txtTokenCheckerThreads);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblTokenCheckerInvalid);
            this.tabPage1.Controls.Add(this.lblTokenCheckerUnverified);
            this.tabPage1.Controls.Add(this.lblTokenCheckerProxies);
            this.tabPage1.Controls.Add(this.lblTokenCheckerTokens);
            this.tabPage1.Controls.Add(this.btnTokenCheckerLoadProxies);
            this.tabPage1.Controls.Add(this.btnCheckerLoadTokens);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(225, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Token Checker";
            // 
            // lblTokenCheckerVerified
            // 
            this.lblTokenCheckerVerified.AutoSize = true;
            this.lblTokenCheckerVerified.Location = new System.Drawing.Point(63, 287);
            this.lblTokenCheckerVerified.Name = "lblTokenCheckerVerified";
            this.lblTokenCheckerVerified.Size = new System.Drawing.Size(97, 15);
            this.lblTokenCheckerVerified.TabIndex = 41;
            this.lblTokenCheckerVerified.Text = "Verified Tokens: 0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(173, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 15);
            this.label20.TabIndex = 40;
            this.label20.Text = "ms";
            // 
            // comboCheckerType
            // 
            this.comboCheckerType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCheckerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCheckerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCheckerType.Enabled = false;
            this.comboCheckerType.EnabledCalc = true;
            this.comboCheckerType.FormattingEnabled = true;
            this.comboCheckerType.ItemHeight = 20;
            this.comboCheckerType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboCheckerType.Location = new System.Drawing.Point(66, 96);
            this.comboCheckerType.Name = "comboCheckerType";
            this.comboCheckerType.Size = new System.Drawing.Size(130, 26);
            this.comboCheckerType.TabIndex = 39;
            // 
            // txtCheckerTimeout
            // 
            this.txtCheckerTimeout.EnabledCalc = false;
            this.txtCheckerTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCheckerTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtCheckerTimeout.Location = new System.Drawing.Point(66, 128);
            this.txtCheckerTimeout.MaxLength = 32767;
            this.txtCheckerTimeout.MultiLine = false;
            this.txtCheckerTimeout.Name = "txtCheckerTimeout";
            this.txtCheckerTimeout.ReadOnly = false;
            this.txtCheckerTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtCheckerTimeout.TabIndex = 38;
            this.txtCheckerTimeout.Text = "5000";
            this.txtCheckerTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCheckerTimeout.UseSystemPasswordChar = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 15);
            this.label19.TabIndex = 37;
            this.label19.Text = "Timeout:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "Type:";
            // 
            // lblCheckerRetries
            // 
            this.lblCheckerRetries.AutoSize = true;
            this.lblCheckerRetries.Location = new System.Drawing.Point(63, 347);
            this.lblCheckerRetries.Name = "lblCheckerRetries";
            this.lblCheckerRetries.Size = new System.Drawing.Size(54, 15);
            this.lblCheckerRetries.TabIndex = 34;
            this.lblCheckerRetries.Text = "Retries: 0";
            // 
            // chkCheckerUseProxies
            // 
            this.chkCheckerUseProxies.Checked = false;
            this.chkCheckerUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCheckerUseProxies.EnabledCalc = true;
            this.chkCheckerUseProxies.Location = new System.Drawing.Point(66, 72);
            this.chkCheckerUseProxies.Name = "chkCheckerUseProxies";
            this.chkCheckerUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkCheckerUseProxies.TabIndex = 33;
            this.chkCheckerUseProxies.Text = "Use Proxies?";
            this.chkCheckerUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkCheckerUseProxies_CheckedChanged);
            // 
            // btnTokenCheckerStop
            // 
            this.btnTokenCheckerStop.EnabledCalc = false;
            this.btnTokenCheckerStop.Location = new System.Drawing.Point(66, 221);
            this.btnTokenCheckerStop.Name = "btnTokenCheckerStop";
            this.btnTokenCheckerStop.Size = new System.Drawing.Size(130, 23);
            this.btnTokenCheckerStop.TabIndex = 32;
            this.btnTokenCheckerStop.Text = "Stop";
            this.btnTokenCheckerStop.Click += new XylosButton.ClickEventHandler(this.btnTokenCheckerStop_Click);
            // 
            // btnTokenCheckerStart
            // 
            this.btnTokenCheckerStart.EnabledCalc = true;
            this.btnTokenCheckerStart.Location = new System.Drawing.Point(66, 192);
            this.btnTokenCheckerStart.Name = "btnTokenCheckerStart";
            this.btnTokenCheckerStart.Size = new System.Drawing.Size(130, 23);
            this.btnTokenCheckerStart.TabIndex = 31;
            this.btnTokenCheckerStart.Text = "Start";
            this.btnTokenCheckerStart.Click += new XylosButton.ClickEventHandler(this.btnTokenCheckerStart_Click);
            // 
            // txtTokenCheckerThreads
            // 
            this.txtTokenCheckerThreads.EnabledCalc = true;
            this.txtTokenCheckerThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTokenCheckerThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtTokenCheckerThreads.Location = new System.Drawing.Point(66, 8);
            this.txtTokenCheckerThreads.MaxLength = 32767;
            this.txtTokenCheckerThreads.MultiLine = false;
            this.txtTokenCheckerThreads.Name = "txtTokenCheckerThreads";
            this.txtTokenCheckerThreads.ReadOnly = false;
            this.txtTokenCheckerThreads.Size = new System.Drawing.Size(130, 29);
            this.txtTokenCheckerThreads.TabIndex = 30;
            this.txtTokenCheckerThreads.Text = "10";
            this.txtTokenCheckerThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTokenCheckerThreads.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Threads:";
            // 
            // lblTokenCheckerInvalid
            // 
            this.lblTokenCheckerInvalid.AutoSize = true;
            this.lblTokenCheckerInvalid.Location = new System.Drawing.Point(63, 327);
            this.lblTokenCheckerInvalid.Name = "lblTokenCheckerInvalid";
            this.lblTokenCheckerInvalid.Size = new System.Drawing.Size(93, 15);
            this.lblTokenCheckerInvalid.TabIndex = 28;
            this.lblTokenCheckerInvalid.Text = "Invalid Tokens: 0";
            // 
            // lblTokenCheckerUnverified
            // 
            this.lblTokenCheckerUnverified.AutoSize = true;
            this.lblTokenCheckerUnverified.Location = new System.Drawing.Point(63, 307);
            this.lblTokenCheckerUnverified.Name = "lblTokenCheckerUnverified";
            this.lblTokenCheckerUnverified.Size = new System.Drawing.Size(112, 15);
            this.lblTokenCheckerUnverified.TabIndex = 27;
            this.lblTokenCheckerUnverified.Text = "Unverified Tokens: 0";
            // 
            // lblTokenCheckerProxies
            // 
            this.lblTokenCheckerProxies.AutoSize = true;
            this.lblTokenCheckerProxies.Location = new System.Drawing.Point(63, 267);
            this.lblTokenCheckerProxies.Name = "lblTokenCheckerProxies";
            this.lblTokenCheckerProxies.Size = new System.Drawing.Size(99, 15);
            this.lblTokenCheckerProxies.TabIndex = 26;
            this.lblTokenCheckerProxies.Text = "Loaded Proxies: 0";
            // 
            // lblTokenCheckerTokens
            // 
            this.lblTokenCheckerTokens.AutoSize = true;
            this.lblTokenCheckerTokens.Location = new System.Drawing.Point(63, 247);
            this.lblTokenCheckerTokens.Name = "lblTokenCheckerTokens";
            this.lblTokenCheckerTokens.Size = new System.Drawing.Size(97, 15);
            this.lblTokenCheckerTokens.TabIndex = 25;
            this.lblTokenCheckerTokens.Text = "Loaded Tokens: 0";
            // 
            // btnTokenCheckerLoadProxies
            // 
            this.btnTokenCheckerLoadProxies.EnabledCalc = false;
            this.btnTokenCheckerLoadProxies.Location = new System.Drawing.Point(66, 163);
            this.btnTokenCheckerLoadProxies.Name = "btnTokenCheckerLoadProxies";
            this.btnTokenCheckerLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnTokenCheckerLoadProxies.TabIndex = 1;
            this.btnTokenCheckerLoadProxies.Text = "Load Proxies";
            this.btnTokenCheckerLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnTokenCheckerLoadProxies_Click);
            // 
            // btnCheckerLoadTokens
            // 
            this.btnCheckerLoadTokens.EnabledCalc = true;
            this.btnCheckerLoadTokens.Location = new System.Drawing.Point(66, 43);
            this.btnCheckerLoadTokens.Name = "btnCheckerLoadTokens";
            this.btnCheckerLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnCheckerLoadTokens.TabIndex = 0;
            this.btnCheckerLoadTokens.Text = "Load Tokens";
            this.btnCheckerLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnCheckerLoadTokens_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.label49);
            this.tabPage4.Controls.Add(this.txtJoinerDelay);
            this.tabPage4.Controls.Add(this.label48);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.comboJoinerType);
            this.tabPage4.Controls.Add(this.txtJoinerTimeout);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.lblUsersJoined);
            this.tabPage4.Controls.Add(this.txtJoinerCode);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.btnJoinerStop);
            this.tabPage4.Controls.Add(this.btnJoinerStart);
            this.tabPage4.Controls.Add(this.chkJoinerUseProxies);
            this.tabPage4.Controls.Add(this.txtJoinerThreads);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnJoinerLoadProxies);
            this.tabPage4.Controls.Add(this.btnJoinerLoadTokens);
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(225, 476);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Guild Joiner";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(189, 233);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(23, 15);
            this.label49.TabIndex = 82;
            this.label49.Text = "ms";
            // 
            // txtJoinerDelay
            // 
            this.txtJoinerDelay.EnabledCalc = true;
            this.txtJoinerDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJoinerDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtJoinerDelay.Location = new System.Drawing.Point(82, 227);
            this.txtJoinerDelay.MaxLength = 32767;
            this.txtJoinerDelay.MultiLine = false;
            this.txtJoinerDelay.Name = "txtJoinerDelay";
            this.txtJoinerDelay.ReadOnly = false;
            this.txtJoinerDelay.Size = new System.Drawing.Size(105, 29);
            this.txtJoinerDelay.TabIndex = 81;
            this.txtJoinerDelay.Text = "100";
            this.txtJoinerDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJoinerDelay.UseSystemPasswordChar = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 233);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(39, 15);
            this.label48.TabIndex = 80;
            this.label48.Text = "Delay:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(189, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 15);
            this.label21.TabIndex = 79;
            this.label21.Text = "ms";
            // 
            // comboJoinerType
            // 
            this.comboJoinerType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboJoinerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboJoinerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJoinerType.Enabled = false;
            this.comboJoinerType.EnabledCalc = true;
            this.comboJoinerType.FormattingEnabled = true;
            this.comboJoinerType.ItemHeight = 20;
            this.comboJoinerType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboJoinerType.Location = new System.Drawing.Point(82, 96);
            this.comboJoinerType.Name = "comboJoinerType";
            this.comboJoinerType.Size = new System.Drawing.Size(130, 26);
            this.comboJoinerType.TabIndex = 78;
            // 
            // txtJoinerTimeout
            // 
            this.txtJoinerTimeout.EnabledCalc = false;
            this.txtJoinerTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJoinerTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtJoinerTimeout.Location = new System.Drawing.Point(82, 128);
            this.txtJoinerTimeout.MaxLength = 32767;
            this.txtJoinerTimeout.MultiLine = false;
            this.txtJoinerTimeout.Name = "txtJoinerTimeout";
            this.txtJoinerTimeout.ReadOnly = false;
            this.txtJoinerTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtJoinerTimeout.TabIndex = 77;
            this.txtJoinerTimeout.Text = "5000";
            this.txtJoinerTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJoinerTimeout.UseSystemPasswordChar = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 15);
            this.label22.TabIndex = 76;
            this.label22.Text = "Timeout:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 15);
            this.label23.TabIndex = 75;
            this.label23.Text = "Type:";
            // 
            // lblUsersJoined
            // 
            this.lblUsersJoined.AutoSize = true;
            this.lblUsersJoined.Location = new System.Drawing.Point(79, 317);
            this.lblUsersJoined.Name = "lblUsersJoined";
            this.lblUsersJoined.Size = new System.Drawing.Size(84, 15);
            this.lblUsersJoined.TabIndex = 74;
            this.lblUsersJoined.Text = "Users Joined: 0";
            // 
            // txtJoinerCode
            // 
            this.txtJoinerCode.EnabledCalc = true;
            this.txtJoinerCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJoinerCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtJoinerCode.Location = new System.Drawing.Point(82, 192);
            this.txtJoinerCode.MaxLength = 32767;
            this.txtJoinerCode.MultiLine = false;
            this.txtJoinerCode.Name = "txtJoinerCode";
            this.txtJoinerCode.ReadOnly = false;
            this.txtJoinerCode.Size = new System.Drawing.Size(130, 29);
            this.txtJoinerCode.TabIndex = 73;
            this.txtJoinerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJoinerCode.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 72;
            this.label10.Text = "Invite Code:";
            // 
            // btnJoinerStop
            // 
            this.btnJoinerStop.EnabledCalc = false;
            this.btnJoinerStop.Location = new System.Drawing.Point(82, 291);
            this.btnJoinerStop.Name = "btnJoinerStop";
            this.btnJoinerStop.Size = new System.Drawing.Size(130, 23);
            this.btnJoinerStop.TabIndex = 71;
            this.btnJoinerStop.Text = "Stop";
            this.btnJoinerStop.Click += new XylosButton.ClickEventHandler(this.btnJoinerStop_Click);
            // 
            // btnJoinerStart
            // 
            this.btnJoinerStart.EnabledCalc = true;
            this.btnJoinerStart.Location = new System.Drawing.Point(82, 262);
            this.btnJoinerStart.Name = "btnJoinerStart";
            this.btnJoinerStart.Size = new System.Drawing.Size(130, 23);
            this.btnJoinerStart.TabIndex = 70;
            this.btnJoinerStart.Text = "Start";
            this.btnJoinerStart.Click += new XylosButton.ClickEventHandler(this.btnJoinerStart_Click);
            // 
            // chkJoinerUseProxies
            // 
            this.chkJoinerUseProxies.Checked = false;
            this.chkJoinerUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkJoinerUseProxies.EnabledCalc = true;
            this.chkJoinerUseProxies.Location = new System.Drawing.Point(82, 72);
            this.chkJoinerUseProxies.Name = "chkJoinerUseProxies";
            this.chkJoinerUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkJoinerUseProxies.TabIndex = 68;
            this.chkJoinerUseProxies.Text = "Use Proxies?";
            this.chkJoinerUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkJoinerUseProxies_CheckedChanged);
            // 
            // txtJoinerThreads
            // 
            this.txtJoinerThreads.EnabledCalc = true;
            this.txtJoinerThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJoinerThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtJoinerThreads.Location = new System.Drawing.Point(82, 8);
            this.txtJoinerThreads.MaxLength = 32767;
            this.txtJoinerThreads.MultiLine = false;
            this.txtJoinerThreads.Name = "txtJoinerThreads";
            this.txtJoinerThreads.ReadOnly = false;
            this.txtJoinerThreads.Size = new System.Drawing.Size(130, 29);
            this.txtJoinerThreads.TabIndex = 67;
            this.txtJoinerThreads.Text = "1";
            this.txtJoinerThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJoinerThreads.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 66;
            this.label8.Text = "Threads:";
            // 
            // btnJoinerLoadProxies
            // 
            this.btnJoinerLoadProxies.EnabledCalc = false;
            this.btnJoinerLoadProxies.Location = new System.Drawing.Point(82, 163);
            this.btnJoinerLoadProxies.Name = "btnJoinerLoadProxies";
            this.btnJoinerLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnJoinerLoadProxies.TabIndex = 65;
            this.btnJoinerLoadProxies.Text = "Load Proxies";
            this.btnJoinerLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnJoinerLoadProxies_Click);
            // 
            // btnJoinerLoadTokens
            // 
            this.btnJoinerLoadTokens.EnabledCalc = true;
            this.btnJoinerLoadTokens.Location = new System.Drawing.Point(82, 43);
            this.btnJoinerLoadTokens.Name = "btnJoinerLoadTokens";
            this.btnJoinerLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnJoinerLoadTokens.TabIndex = 64;
            this.btnJoinerLoadTokens.Text = "Load Tokens";
            this.btnJoinerLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnJoinerLoadTokens_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.label50);
            this.tabPage5.Controls.Add(this.txtLeaverDelay);
            this.tabPage5.Controls.Add(this.label51);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.comboLeaverType);
            this.tabPage5.Controls.Add(this.txtLeaverTimeout);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.lblUsersLeft);
            this.tabPage5.Controls.Add(this.txtLeaverServer);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.btnLeaverStop);
            this.tabPage5.Controls.Add(this.btnLeaverStart);
            this.tabPage5.Controls.Add(this.chkLeaverUseProxies);
            this.tabPage5.Controls.Add(this.txtLeaverThreads);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.btnLeaverLoadProxies);
            this.tabPage5.Controls.Add(this.btnLeaverLoadTokens);
            this.tabPage5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(225, 476);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Guild Leaver";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(177, 233);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(23, 15);
            this.label50.TabIndex = 92;
            this.label50.Text = "ms";
            // 
            // txtLeaverDelay
            // 
            this.txtLeaverDelay.EnabledCalc = true;
            this.txtLeaverDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLeaverDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtLeaverDelay.Location = new System.Drawing.Point(68, 227);
            this.txtLeaverDelay.MaxLength = 32767;
            this.txtLeaverDelay.MultiLine = false;
            this.txtLeaverDelay.Name = "txtLeaverDelay";
            this.txtLeaverDelay.ReadOnly = false;
            this.txtLeaverDelay.Size = new System.Drawing.Size(105, 29);
            this.txtLeaverDelay.TabIndex = 91;
            this.txtLeaverDelay.Text = "100";
            this.txtLeaverDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLeaverDelay.UseSystemPasswordChar = false;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 233);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(39, 15);
            this.label51.TabIndex = 90;
            this.label51.Text = "Delay:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(177, 134);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 15);
            this.label24.TabIndex = 89;
            this.label24.Text = "ms";
            // 
            // comboLeaverType
            // 
            this.comboLeaverType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboLeaverType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLeaverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLeaverType.Enabled = false;
            this.comboLeaverType.EnabledCalc = true;
            this.comboLeaverType.FormattingEnabled = true;
            this.comboLeaverType.ItemHeight = 20;
            this.comboLeaverType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboLeaverType.Location = new System.Drawing.Point(68, 96);
            this.comboLeaverType.Name = "comboLeaverType";
            this.comboLeaverType.Size = new System.Drawing.Size(130, 26);
            this.comboLeaverType.TabIndex = 88;
            // 
            // txtLeaverTimeout
            // 
            this.txtLeaverTimeout.EnabledCalc = false;
            this.txtLeaverTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLeaverTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtLeaverTimeout.Location = new System.Drawing.Point(68, 128);
            this.txtLeaverTimeout.MaxLength = 32767;
            this.txtLeaverTimeout.MultiLine = false;
            this.txtLeaverTimeout.Name = "txtLeaverTimeout";
            this.txtLeaverTimeout.ReadOnly = false;
            this.txtLeaverTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtLeaverTimeout.TabIndex = 87;
            this.txtLeaverTimeout.Text = "5000";
            this.txtLeaverTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLeaverTimeout.UseSystemPasswordChar = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 134);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 15);
            this.label25.TabIndex = 86;
            this.label25.Text = "Timeout:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 101);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 15);
            this.label26.TabIndex = 85;
            this.label26.Text = "Type:";
            // 
            // lblUsersLeft
            // 
            this.lblUsersLeft.AutoSize = true;
            this.lblUsersLeft.Location = new System.Drawing.Point(65, 317);
            this.lblUsersLeft.Name = "lblUsersLeft";
            this.lblUsersLeft.Size = new System.Drawing.Size(70, 15);
            this.lblUsersLeft.TabIndex = 84;
            this.lblUsersLeft.Text = "Users Left: 0";
            // 
            // txtLeaverServer
            // 
            this.txtLeaverServer.EnabledCalc = true;
            this.txtLeaverServer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLeaverServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtLeaverServer.Location = new System.Drawing.Point(68, 192);
            this.txtLeaverServer.MaxLength = 32767;
            this.txtLeaverServer.MultiLine = false;
            this.txtLeaverServer.Name = "txtLeaverServer";
            this.txtLeaverServer.ReadOnly = false;
            this.txtLeaverServer.Size = new System.Drawing.Size(130, 29);
            this.txtLeaverServer.TabIndex = 83;
            this.txtLeaverServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLeaverServer.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 82;
            this.label12.Text = "Server ID:";
            // 
            // btnLeaverStop
            // 
            this.btnLeaverStop.EnabledCalc = false;
            this.btnLeaverStop.Location = new System.Drawing.Point(68, 291);
            this.btnLeaverStop.Name = "btnLeaverStop";
            this.btnLeaverStop.Size = new System.Drawing.Size(130, 23);
            this.btnLeaverStop.TabIndex = 81;
            this.btnLeaverStop.Text = "Stop";
            this.btnLeaverStop.Click += new XylosButton.ClickEventHandler(this.btnLeaverStop_Click);
            // 
            // btnLeaverStart
            // 
            this.btnLeaverStart.EnabledCalc = true;
            this.btnLeaverStart.Location = new System.Drawing.Point(68, 262);
            this.btnLeaverStart.Name = "btnLeaverStart";
            this.btnLeaverStart.Size = new System.Drawing.Size(130, 23);
            this.btnLeaverStart.TabIndex = 80;
            this.btnLeaverStart.Text = "Start";
            this.btnLeaverStart.Click += new XylosButton.ClickEventHandler(this.btnLeaverStart_Click);
            // 
            // chkLeaverUseProxies
            // 
            this.chkLeaverUseProxies.Checked = false;
            this.chkLeaverUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLeaverUseProxies.EnabledCalc = true;
            this.chkLeaverUseProxies.Location = new System.Drawing.Point(68, 72);
            this.chkLeaverUseProxies.Name = "chkLeaverUseProxies";
            this.chkLeaverUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkLeaverUseProxies.TabIndex = 79;
            this.chkLeaverUseProxies.Text = "Use Proxies?";
            this.chkLeaverUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkLeaverUseProxies_CheckedChanged);
            // 
            // txtLeaverThreads
            // 
            this.txtLeaverThreads.EnabledCalc = true;
            this.txtLeaverThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLeaverThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtLeaverThreads.Location = new System.Drawing.Point(68, 8);
            this.txtLeaverThreads.MaxLength = 32767;
            this.txtLeaverThreads.MultiLine = false;
            this.txtLeaverThreads.Name = "txtLeaverThreads";
            this.txtLeaverThreads.ReadOnly = false;
            this.txtLeaverThreads.Size = new System.Drawing.Size(130, 29);
            this.txtLeaverThreads.TabIndex = 78;
            this.txtLeaverThreads.Text = "1";
            this.txtLeaverThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLeaverThreads.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 77;
            this.label13.Text = "Threads:";
            // 
            // btnLeaverLoadProxies
            // 
            this.btnLeaverLoadProxies.EnabledCalc = false;
            this.btnLeaverLoadProxies.Location = new System.Drawing.Point(68, 163);
            this.btnLeaverLoadProxies.Name = "btnLeaverLoadProxies";
            this.btnLeaverLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnLeaverLoadProxies.TabIndex = 76;
            this.btnLeaverLoadProxies.Text = "Load Proxies";
            this.btnLeaverLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnLeaverLoadProxies_Click);
            // 
            // btnLeaverLoadTokens
            // 
            this.btnLeaverLoadTokens.EnabledCalc = true;
            this.btnLeaverLoadTokens.Location = new System.Drawing.Point(68, 43);
            this.btnLeaverLoadTokens.Name = "btnLeaverLoadTokens";
            this.btnLeaverLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnLeaverLoadTokens.TabIndex = 75;
            this.btnLeaverLoadTokens.Text = "Load Tokens";
            this.btnLeaverLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnLeaverLoadTokens_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Controls.Add(this.txtSpammerDelay);
            this.tabPage2.Controls.Add(this.label52);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.comboSpammerType);
            this.tabPage2.Controls.Add(this.txtSpammerTimeout);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.lblMessagesSent);
            this.tabPage2.Controls.Add(this.txtSpammerChannel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtSpammerMessages);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnSpammerLoadMessages);
            this.tabPage2.Controls.Add(this.chkSpammerUseProxies);
            this.tabPage2.Controls.Add(this.btnSpammerStop);
            this.tabPage2.Controls.Add(this.btnSpammerStart);
            this.tabPage2.Controls.Add(this.txtSpammerThreads);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnSpammerLoadProxies);
            this.tabPage2.Controls.Add(this.btnSpammerLoadTokens);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(225, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server Spammer";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(171, 342);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(23, 15);
            this.label53.TabIndex = 75;
            this.label53.Text = "ms";
            // 
            // txtSpammerDelay
            // 
            this.txtSpammerDelay.EnabledCalc = true;
            this.txtSpammerDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpammerDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtSpammerDelay.Location = new System.Drawing.Point(66, 336);
            this.txtSpammerDelay.MaxLength = 32767;
            this.txtSpammerDelay.MultiLine = false;
            this.txtSpammerDelay.Name = "txtSpammerDelay";
            this.txtSpammerDelay.ReadOnly = false;
            this.txtSpammerDelay.Size = new System.Drawing.Size(105, 29);
            this.txtSpammerDelay.TabIndex = 74;
            this.txtSpammerDelay.Text = "100";
            this.txtSpammerDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSpammerDelay.UseSystemPasswordChar = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(63, 318);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(39, 15);
            this.label52.TabIndex = 72;
            this.label52.Text = "Delay:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(170, 163);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 15);
            this.label27.TabIndex = 71;
            this.label27.Text = "ms";
            // 
            // comboSpammerType
            // 
            this.comboSpammerType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboSpammerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSpammerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpammerType.Enabled = false;
            this.comboSpammerType.EnabledCalc = true;
            this.comboSpammerType.FormattingEnabled = true;
            this.comboSpammerType.ItemHeight = 20;
            this.comboSpammerType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboSpammerType.Location = new System.Drawing.Point(66, 125);
            this.comboSpammerType.Name = "comboSpammerType";
            this.comboSpammerType.Size = new System.Drawing.Size(130, 26);
            this.comboSpammerType.TabIndex = 70;
            // 
            // txtSpammerTimeout
            // 
            this.txtSpammerTimeout.EnabledCalc = false;
            this.txtSpammerTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpammerTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtSpammerTimeout.Location = new System.Drawing.Point(66, 157);
            this.txtSpammerTimeout.MaxLength = 32767;
            this.txtSpammerTimeout.MultiLine = false;
            this.txtSpammerTimeout.Name = "txtSpammerTimeout";
            this.txtSpammerTimeout.ReadOnly = false;
            this.txtSpammerTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtSpammerTimeout.TabIndex = 69;
            this.txtSpammerTimeout.Text = "5000";
            this.txtSpammerTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSpammerTimeout.UseSystemPasswordChar = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 163);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 15);
            this.label28.TabIndex = 68;
            this.label28.Text = "Timeout:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 130);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 15);
            this.label29.TabIndex = 67;
            this.label29.Text = "Type:";
            // 
            // lblMessagesSent
            // 
            this.lblMessagesSent.AutoSize = true;
            this.lblMessagesSent.Location = new System.Drawing.Point(63, 426);
            this.lblMessagesSent.Name = "lblMessagesSent";
            this.lblMessagesSent.Size = new System.Drawing.Size(96, 15);
            this.lblMessagesSent.TabIndex = 66;
            this.lblMessagesSent.Text = "Messages Sent: 0";
            // 
            // txtSpammerChannel
            // 
            this.txtSpammerChannel.EnabledCalc = true;
            this.txtSpammerChannel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpammerChannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtSpammerChannel.Location = new System.Drawing.Point(66, 286);
            this.txtSpammerChannel.MaxLength = 32767;
            this.txtSpammerChannel.MultiLine = false;
            this.txtSpammerChannel.Name = "txtSpammerChannel";
            this.txtSpammerChannel.ReadOnly = false;
            this.txtSpammerChannel.Size = new System.Drawing.Size(130, 29);
            this.txtSpammerChannel.TabIndex = 45;
            this.txtSpammerChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSpammerChannel.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Channel ID:";
            // 
            // txtSpammerMessages
            // 
            this.txtSpammerMessages.EnabledCalc = true;
            this.txtSpammerMessages.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpammerMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtSpammerMessages.Location = new System.Drawing.Point(66, 236);
            this.txtSpammerMessages.MaxLength = 32767;
            this.txtSpammerMessages.MultiLine = false;
            this.txtSpammerMessages.Name = "txtSpammerMessages";
            this.txtSpammerMessages.ReadOnly = false;
            this.txtSpammerMessages.Size = new System.Drawing.Size(130, 29);
            this.txtSpammerMessages.TabIndex = 43;
            this.txtSpammerMessages.Text = "∞";
            this.txtSpammerMessages.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSpammerMessages.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Messages to send:";
            // 
            // btnSpammerLoadMessages
            // 
            this.btnSpammerLoadMessages.EnabledCalc = true;
            this.btnSpammerLoadMessages.Location = new System.Drawing.Point(66, 72);
            this.btnSpammerLoadMessages.Name = "btnSpammerLoadMessages";
            this.btnSpammerLoadMessages.Size = new System.Drawing.Size(130, 23);
            this.btnSpammerLoadMessages.TabIndex = 41;
            this.btnSpammerLoadMessages.Text = "Load Messages";
            this.btnSpammerLoadMessages.Click += new XylosButton.ClickEventHandler(this.btnSpammerLoadMessages_Click);
            // 
            // chkSpammerUseProxies
            // 
            this.chkSpammerUseProxies.Checked = false;
            this.chkSpammerUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSpammerUseProxies.EnabledCalc = true;
            this.chkSpammerUseProxies.Location = new System.Drawing.Point(66, 101);
            this.chkSpammerUseProxies.Name = "chkSpammerUseProxies";
            this.chkSpammerUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkSpammerUseProxies.TabIndex = 40;
            this.chkSpammerUseProxies.Text = "Use Proxies?";
            this.chkSpammerUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkSpammerUseProxies_CheckedChanged);
            // 
            // btnSpammerStop
            // 
            this.btnSpammerStop.EnabledCalc = false;
            this.btnSpammerStop.Location = new System.Drawing.Point(66, 400);
            this.btnSpammerStop.Name = "btnSpammerStop";
            this.btnSpammerStop.Size = new System.Drawing.Size(130, 23);
            this.btnSpammerStop.TabIndex = 39;
            this.btnSpammerStop.Text = "Stop";
            this.btnSpammerStop.Click += new XylosButton.ClickEventHandler(this.btnSpammerStop_Click);
            // 
            // btnSpammerStart
            // 
            this.btnSpammerStart.EnabledCalc = true;
            this.btnSpammerStart.Location = new System.Drawing.Point(66, 371);
            this.btnSpammerStart.Name = "btnSpammerStart";
            this.btnSpammerStart.Size = new System.Drawing.Size(130, 23);
            this.btnSpammerStart.TabIndex = 38;
            this.btnSpammerStart.Text = "Start";
            this.btnSpammerStart.Click += new XylosButton.ClickEventHandler(this.btnSpammerStart_Click);
            // 
            // txtSpammerThreads
            // 
            this.txtSpammerThreads.EnabledCalc = true;
            this.txtSpammerThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpammerThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtSpammerThreads.Location = new System.Drawing.Point(66, 8);
            this.txtSpammerThreads.MaxLength = 32767;
            this.txtSpammerThreads.MultiLine = false;
            this.txtSpammerThreads.Name = "txtSpammerThreads";
            this.txtSpammerThreads.ReadOnly = false;
            this.txtSpammerThreads.Size = new System.Drawing.Size(130, 29);
            this.txtSpammerThreads.TabIndex = 37;
            this.txtSpammerThreads.Text = "10";
            this.txtSpammerThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSpammerThreads.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Threads:";
            // 
            // btnSpammerLoadProxies
            // 
            this.btnSpammerLoadProxies.EnabledCalc = false;
            this.btnSpammerLoadProxies.Location = new System.Drawing.Point(66, 192);
            this.btnSpammerLoadProxies.Name = "btnSpammerLoadProxies";
            this.btnSpammerLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnSpammerLoadProxies.TabIndex = 35;
            this.btnSpammerLoadProxies.Text = "Load Proxies";
            this.btnSpammerLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnSpammerLoadProxies_Click);
            // 
            // btnSpammerLoadTokens
            // 
            this.btnSpammerLoadTokens.EnabledCalc = true;
            this.btnSpammerLoadTokens.Location = new System.Drawing.Point(66, 43);
            this.btnSpammerLoadTokens.Name = "btnSpammerLoadTokens";
            this.btnSpammerLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnSpammerLoadTokens.TabIndex = 34;
            this.btnSpammerLoadTokens.Text = "Load Tokens";
            this.btnSpammerLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnSpammerLoadTokens_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label54);
            this.tabPage3.Controls.Add(this.txtDMDelay);
            this.tabPage3.Controls.Add(this.label55);
            this.tabPage3.Controls.Add(this.lblDMSent);
            this.tabPage3.Controls.Add(this.btnDMLoadMessages);
            this.tabPage3.Controls.Add(this.txtDMUserId);
            this.tabPage3.Controls.Add(this.label47);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.comboDMType);
            this.tabPage3.Controls.Add(this.txtDMTimeout);
            this.tabPage3.Controls.Add(this.label44);
            this.tabPage3.Controls.Add(this.label45);
            this.tabPage3.Controls.Add(this.btnDMStop);
            this.tabPage3.Controls.Add(this.btnDMStart);
            this.tabPage3.Controls.Add(this.chkDMUseProxies);
            this.tabPage3.Controls.Add(this.txtDMThreads);
            this.tabPage3.Controls.Add(this.label46);
            this.tabPage3.Controls.Add(this.btnDMLoadProxies);
            this.tabPage3.Controls.Add(this.btnDMLoadTokens);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(225, 476);
            this.tabPage3.TabIndex = 9;
            this.tabPage3.Text = "DM Spammer";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(173, 262);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(23, 15);
            this.label54.TabIndex = 108;
            this.label54.Text = "ms";
            // 
            // txtDMDelay
            // 
            this.txtDMDelay.EnabledCalc = true;
            this.txtDMDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDMDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtDMDelay.Location = new System.Drawing.Point(66, 256);
            this.txtDMDelay.MaxLength = 32767;
            this.txtDMDelay.MultiLine = false;
            this.txtDMDelay.Name = "txtDMDelay";
            this.txtDMDelay.ReadOnly = false;
            this.txtDMDelay.Size = new System.Drawing.Size(105, 29);
            this.txtDMDelay.TabIndex = 107;
            this.txtDMDelay.Text = "100";
            this.txtDMDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDMDelay.UseSystemPasswordChar = false;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 262);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(39, 15);
            this.label55.TabIndex = 106;
            this.label55.Text = "Delay:";
            // 
            // lblDMSent
            // 
            this.lblDMSent.AutoSize = true;
            this.lblDMSent.Location = new System.Drawing.Point(63, 346);
            this.lblDMSent.Name = "lblDMSent";
            this.lblDMSent.Size = new System.Drawing.Size(96, 15);
            this.lblDMSent.TabIndex = 105;
            this.lblDMSent.Text = "Messages Sent: 0";
            // 
            // btnDMLoadMessages
            // 
            this.btnDMLoadMessages.EnabledCalc = true;
            this.btnDMLoadMessages.Location = new System.Drawing.Point(66, 72);
            this.btnDMLoadMessages.Name = "btnDMLoadMessages";
            this.btnDMLoadMessages.Size = new System.Drawing.Size(130, 23);
            this.btnDMLoadMessages.TabIndex = 104;
            this.btnDMLoadMessages.Text = "Load Messages";
            this.btnDMLoadMessages.Click += new XylosButton.ClickEventHandler(this.btnDMLoadMessages_Click);
            // 
            // txtDMUserId
            // 
            this.txtDMUserId.EnabledCalc = true;
            this.txtDMUserId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDMUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtDMUserId.Location = new System.Drawing.Point(66, 221);
            this.txtDMUserId.MaxLength = 32767;
            this.txtDMUserId.MultiLine = false;
            this.txtDMUserId.Name = "txtDMUserId";
            this.txtDMUserId.ReadOnly = false;
            this.txtDMUserId.Size = new System.Drawing.Size(130, 29);
            this.txtDMUserId.TabIndex = 103;
            this.txtDMUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDMUserId.UseSystemPasswordChar = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 227);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 15);
            this.label47.TabIndex = 102;
            this.label47.Text = "User ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(173, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 15);
            this.label17.TabIndex = 101;
            this.label17.Text = "ms";
            // 
            // comboDMType
            // 
            this.comboDMType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDMType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboDMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDMType.Enabled = false;
            this.comboDMType.EnabledCalc = true;
            this.comboDMType.FormattingEnabled = true;
            this.comboDMType.ItemHeight = 20;
            this.comboDMType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboDMType.Location = new System.Drawing.Point(66, 125);
            this.comboDMType.Name = "comboDMType";
            this.comboDMType.Size = new System.Drawing.Size(130, 26);
            this.comboDMType.TabIndex = 100;
            // 
            // txtDMTimeout
            // 
            this.txtDMTimeout.EnabledCalc = false;
            this.txtDMTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDMTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtDMTimeout.Location = new System.Drawing.Point(66, 157);
            this.txtDMTimeout.MaxLength = 32767;
            this.txtDMTimeout.MultiLine = false;
            this.txtDMTimeout.Name = "txtDMTimeout";
            this.txtDMTimeout.ReadOnly = false;
            this.txtDMTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtDMTimeout.TabIndex = 99;
            this.txtDMTimeout.Text = "5000";
            this.txtDMTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDMTimeout.UseSystemPasswordChar = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 163);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(54, 15);
            this.label44.TabIndex = 98;
            this.label44.Text = "Timeout:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 130);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(34, 15);
            this.label45.TabIndex = 97;
            this.label45.Text = "Type:";
            // 
            // btnDMStop
            // 
            this.btnDMStop.EnabledCalc = false;
            this.btnDMStop.Location = new System.Drawing.Point(66, 320);
            this.btnDMStop.Name = "btnDMStop";
            this.btnDMStop.Size = new System.Drawing.Size(130, 23);
            this.btnDMStop.TabIndex = 96;
            this.btnDMStop.Text = "Stop";
            this.btnDMStop.Click += new XylosButton.ClickEventHandler(this.btnDMStop_Click);
            // 
            // btnDMStart
            // 
            this.btnDMStart.EnabledCalc = true;
            this.btnDMStart.Location = new System.Drawing.Point(66, 291);
            this.btnDMStart.Name = "btnDMStart";
            this.btnDMStart.Size = new System.Drawing.Size(130, 23);
            this.btnDMStart.TabIndex = 95;
            this.btnDMStart.Text = "Start";
            this.btnDMStart.Click += new XylosButton.ClickEventHandler(this.btnDMStart_Click);
            // 
            // chkDMUseProxies
            // 
            this.chkDMUseProxies.Checked = false;
            this.chkDMUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDMUseProxies.EnabledCalc = true;
            this.chkDMUseProxies.Location = new System.Drawing.Point(66, 101);
            this.chkDMUseProxies.Name = "chkDMUseProxies";
            this.chkDMUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkDMUseProxies.TabIndex = 94;
            this.chkDMUseProxies.Text = "Use Proxies?";
            this.chkDMUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkDMUseProxies_CheckedChanged);
            // 
            // txtDMThreads
            // 
            this.txtDMThreads.EnabledCalc = true;
            this.txtDMThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDMThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtDMThreads.Location = new System.Drawing.Point(66, 8);
            this.txtDMThreads.MaxLength = 32767;
            this.txtDMThreads.MultiLine = false;
            this.txtDMThreads.Name = "txtDMThreads";
            this.txtDMThreads.ReadOnly = false;
            this.txtDMThreads.Size = new System.Drawing.Size(130, 29);
            this.txtDMThreads.TabIndex = 93;
            this.txtDMThreads.Text = "1";
            this.txtDMThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDMThreads.UseSystemPasswordChar = false;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 14);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(51, 15);
            this.label46.TabIndex = 92;
            this.label46.Text = "Threads:";
            // 
            // btnDMLoadProxies
            // 
            this.btnDMLoadProxies.EnabledCalc = false;
            this.btnDMLoadProxies.Location = new System.Drawing.Point(66, 192);
            this.btnDMLoadProxies.Name = "btnDMLoadProxies";
            this.btnDMLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnDMLoadProxies.TabIndex = 91;
            this.btnDMLoadProxies.Text = "Load Proxies";
            this.btnDMLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnDMLoadProxies_Click);
            // 
            // btnDMLoadTokens
            // 
            this.btnDMLoadTokens.EnabledCalc = true;
            this.btnDMLoadTokens.Location = new System.Drawing.Point(66, 43);
            this.btnDMLoadTokens.Name = "btnDMLoadTokens";
            this.btnDMLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnDMLoadTokens.TabIndex = 90;
            this.btnDMLoadTokens.Text = "Load Tokens";
            this.btnDMLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnDMLoadTokens_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.White;
            this.tabPage10.Controls.Add(this.label70);
            this.tabPage10.Controls.Add(this.txtNicknameServer);
            this.tabPage10.Controls.Add(this.label64);
            this.tabPage10.Controls.Add(this.label62);
            this.tabPage10.Controls.Add(this.txtNicknameDelay);
            this.tabPage10.Controls.Add(this.label63);
            this.tabPage10.Controls.Add(this.lblChanged);
            this.tabPage10.Controls.Add(this.txtNickname);
            this.tabPage10.Controls.Add(this.label65);
            this.tabPage10.Controls.Add(this.label66);
            this.tabPage10.Controls.Add(this.comboNicknameType);
            this.tabPage10.Controls.Add(this.txtNicknameTimeout);
            this.tabPage10.Controls.Add(this.label67);
            this.tabPage10.Controls.Add(this.label68);
            this.tabPage10.Controls.Add(this.btnNicknameStop);
            this.tabPage10.Controls.Add(this.btnNicknameStart);
            this.tabPage10.Controls.Add(this.chkNicknameUseProxies);
            this.tabPage10.Controls.Add(this.txtNicknameThreads);
            this.tabPage10.Controls.Add(this.label69);
            this.tabPage10.Controls.Add(this.btnNicknameLoadProxies);
            this.tabPage10.Controls.Add(this.btnNicknameLoadTokens);
            this.tabPage10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage10.Location = new System.Drawing.Point(184, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(225, 476);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "Nickname Changer";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(73, 259);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(137, 30);
            this.label70.TabIndex = 130;
            this.label70.Text = "Note: Leaving this blank \r\nwill reset the nicknames";
            // 
            // txtNicknameServer
            // 
            this.txtNicknameServer.EnabledCalc = true;
            this.txtNicknameServer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNicknameServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtNicknameServer.Location = new System.Drawing.Point(76, 192);
            this.txtNicknameServer.MaxLength = 32767;
            this.txtNicknameServer.MultiLine = false;
            this.txtNicknameServer.Name = "txtNicknameServer";
            this.txtNicknameServer.ReadOnly = false;
            this.txtNicknameServer.Size = new System.Drawing.Size(130, 29);
            this.txtNicknameServer.TabIndex = 129;
            this.txtNicknameServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNicknameServer.UseSystemPasswordChar = false;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 198);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(56, 15);
            this.label64.TabIndex = 128;
            this.label64.Text = "Server ID:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(183, 298);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(23, 15);
            this.label62.TabIndex = 127;
            this.label62.Text = "ms";
            // 
            // txtNicknameDelay
            // 
            this.txtNicknameDelay.EnabledCalc = true;
            this.txtNicknameDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNicknameDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtNicknameDelay.Location = new System.Drawing.Point(76, 292);
            this.txtNicknameDelay.MaxLength = 32767;
            this.txtNicknameDelay.MultiLine = false;
            this.txtNicknameDelay.Name = "txtNicknameDelay";
            this.txtNicknameDelay.ReadOnly = false;
            this.txtNicknameDelay.Size = new System.Drawing.Size(105, 29);
            this.txtNicknameDelay.TabIndex = 126;
            this.txtNicknameDelay.Text = "100";
            this.txtNicknameDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNicknameDelay.UseSystemPasswordChar = false;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 298);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(39, 15);
            this.label63.TabIndex = 125;
            this.label63.Text = "Delay:";
            // 
            // lblChanged
            // 
            this.lblChanged.AutoSize = true;
            this.lblChanged.Location = new System.Drawing.Point(73, 382);
            this.lblChanged.Name = "lblChanged";
            this.lblChanged.Size = new System.Drawing.Size(67, 15);
            this.lblChanged.TabIndex = 124;
            this.lblChanged.Text = "Changed: 0";
            // 
            // txtNickname
            // 
            this.txtNickname.EnabledCalc = true;
            this.txtNickname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNickname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtNickname.Location = new System.Drawing.Point(76, 227);
            this.txtNickname.MaxLength = 32767;
            this.txtNickname.MultiLine = false;
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.ReadOnly = false;
            this.txtNickname.Size = new System.Drawing.Size(130, 29);
            this.txtNickname.TabIndex = 122;
            this.txtNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNickname.UseSystemPasswordChar = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 233);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(64, 15);
            this.label65.TabIndex = 121;
            this.label65.Text = "Nickname:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(183, 134);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(23, 15);
            this.label66.TabIndex = 120;
            this.label66.Text = "ms";
            // 
            // comboNicknameType
            // 
            this.comboNicknameType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboNicknameType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboNicknameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNicknameType.Enabled = false;
            this.comboNicknameType.EnabledCalc = true;
            this.comboNicknameType.FormattingEnabled = true;
            this.comboNicknameType.ItemHeight = 20;
            this.comboNicknameType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboNicknameType.Location = new System.Drawing.Point(76, 96);
            this.comboNicknameType.Name = "comboNicknameType";
            this.comboNicknameType.Size = new System.Drawing.Size(130, 26);
            this.comboNicknameType.TabIndex = 119;
            // 
            // txtNicknameTimeout
            // 
            this.txtNicknameTimeout.EnabledCalc = false;
            this.txtNicknameTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNicknameTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtNicknameTimeout.Location = new System.Drawing.Point(76, 128);
            this.txtNicknameTimeout.MaxLength = 32767;
            this.txtNicknameTimeout.MultiLine = false;
            this.txtNicknameTimeout.Name = "txtNicknameTimeout";
            this.txtNicknameTimeout.ReadOnly = false;
            this.txtNicknameTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtNicknameTimeout.TabIndex = 118;
            this.txtNicknameTimeout.Text = "5000";
            this.txtNicknameTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNicknameTimeout.UseSystemPasswordChar = false;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(6, 134);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(54, 15);
            this.label67.TabIndex = 117;
            this.label67.Text = "Timeout:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 101);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(34, 15);
            this.label68.TabIndex = 116;
            this.label68.Text = "Type:";
            // 
            // btnNicknameStop
            // 
            this.btnNicknameStop.EnabledCalc = false;
            this.btnNicknameStop.Location = new System.Drawing.Point(76, 356);
            this.btnNicknameStop.Name = "btnNicknameStop";
            this.btnNicknameStop.Size = new System.Drawing.Size(130, 23);
            this.btnNicknameStop.TabIndex = 115;
            this.btnNicknameStop.Text = "Stop";
            this.btnNicknameStop.Click += new XylosButton.ClickEventHandler(this.btnNicknameStop_Click);
            // 
            // btnNicknameStart
            // 
            this.btnNicknameStart.EnabledCalc = true;
            this.btnNicknameStart.Location = new System.Drawing.Point(76, 327);
            this.btnNicknameStart.Name = "btnNicknameStart";
            this.btnNicknameStart.Size = new System.Drawing.Size(130, 23);
            this.btnNicknameStart.TabIndex = 114;
            this.btnNicknameStart.Text = "Start";
            this.btnNicknameStart.Click += new XylosButton.ClickEventHandler(this.btnNicknameStart_Click);
            // 
            // chkNicknameUseProxies
            // 
            this.chkNicknameUseProxies.Checked = false;
            this.chkNicknameUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNicknameUseProxies.EnabledCalc = true;
            this.chkNicknameUseProxies.Location = new System.Drawing.Point(76, 72);
            this.chkNicknameUseProxies.Name = "chkNicknameUseProxies";
            this.chkNicknameUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkNicknameUseProxies.TabIndex = 113;
            this.chkNicknameUseProxies.Text = "Use Proxies?";
            this.chkNicknameUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkNicknameUseProxies_CheckedChanged);
            // 
            // txtNicknameThreads
            // 
            this.txtNicknameThreads.EnabledCalc = true;
            this.txtNicknameThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNicknameThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtNicknameThreads.Location = new System.Drawing.Point(76, 8);
            this.txtNicknameThreads.MaxLength = 32767;
            this.txtNicknameThreads.MultiLine = false;
            this.txtNicknameThreads.Name = "txtNicknameThreads";
            this.txtNicknameThreads.ReadOnly = false;
            this.txtNicknameThreads.Size = new System.Drawing.Size(130, 29);
            this.txtNicknameThreads.TabIndex = 112;
            this.txtNicknameThreads.Text = "1";
            this.txtNicknameThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNicknameThreads.UseSystemPasswordChar = false;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 14);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(51, 15);
            this.label69.TabIndex = 111;
            this.label69.Text = "Threads:";
            // 
            // btnNicknameLoadProxies
            // 
            this.btnNicknameLoadProxies.EnabledCalc = false;
            this.btnNicknameLoadProxies.Location = new System.Drawing.Point(76, 163);
            this.btnNicknameLoadProxies.Name = "btnNicknameLoadProxies";
            this.btnNicknameLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnNicknameLoadProxies.TabIndex = 110;
            this.btnNicknameLoadProxies.Text = "Load Proxies";
            this.btnNicknameLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnNicknameLoadProxies_Click);
            // 
            // btnNicknameLoadTokens
            // 
            this.btnNicknameLoadTokens.EnabledCalc = true;
            this.btnNicknameLoadTokens.Location = new System.Drawing.Point(76, 43);
            this.btnNicknameLoadTokens.Name = "btnNicknameLoadTokens";
            this.btnNicknameLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnNicknameLoadTokens.TabIndex = 109;
            this.btnNicknameLoadTokens.Text = "Load Tokens";
            this.btnNicknameLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnNicknameLoadTokens_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.label56);
            this.tabPage6.Controls.Add(this.txtFriendDelay);
            this.tabPage6.Controls.Add(this.label57);
            this.tabPage6.Controls.Add(this.lblRemoved);
            this.tabPage6.Controls.Add(this.lblAdded);
            this.tabPage6.Controls.Add(this.label30);
            this.tabPage6.Controls.Add(this.comboFriendType);
            this.tabPage6.Controls.Add(this.txtFriendTimeout);
            this.tabPage6.Controls.Add(this.label31);
            this.tabPage6.Controls.Add(this.label32);
            this.tabPage6.Controls.Add(this.radioRemoveFriend);
            this.tabPage6.Controls.Add(this.radioAddFriend);
            this.tabPage6.Controls.Add(this.txtFriendUser);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.btnFriendStop);
            this.tabPage6.Controls.Add(this.btnFriendStart);
            this.tabPage6.Controls.Add(this.chkFriendUseProxies);
            this.tabPage6.Controls.Add(this.txtFriendThreads);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.btnFriendLoadProxies);
            this.tabPage6.Controls.Add(this.btnFriendLoadTokens);
            this.tabPage6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage6.Location = new System.Drawing.Point(184, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(225, 476);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Friend Spammer";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(170, 281);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(23, 15);
            this.label56.TabIndex = 106;
            this.label56.Text = "ms";
            // 
            // txtFriendDelay
            // 
            this.txtFriendDelay.EnabledCalc = true;
            this.txtFriendDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFriendDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtFriendDelay.Location = new System.Drawing.Point(66, 275);
            this.txtFriendDelay.MaxLength = 32767;
            this.txtFriendDelay.MultiLine = false;
            this.txtFriendDelay.Name = "txtFriendDelay";
            this.txtFriendDelay.ReadOnly = false;
            this.txtFriendDelay.Size = new System.Drawing.Size(105, 29);
            this.txtFriendDelay.TabIndex = 105;
            this.txtFriendDelay.Text = "100";
            this.txtFriendDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendDelay.UseSystemPasswordChar = false;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 281);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(39, 15);
            this.label57.TabIndex = 104;
            this.label57.Text = "Delay:";
            // 
            // lblRemoved
            // 
            this.lblRemoved.AutoSize = true;
            this.lblRemoved.Location = new System.Drawing.Point(63, 385);
            this.lblRemoved.Name = "lblRemoved";
            this.lblRemoved.Size = new System.Drawing.Size(69, 15);
            this.lblRemoved.TabIndex = 103;
            this.lblRemoved.Text = "Removed: 0";
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.Location = new System.Drawing.Point(63, 365);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(54, 15);
            this.lblAdded.TabIndex = 102;
            this.lblAdded.Text = "Added: 0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(170, 134);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 15);
            this.label30.TabIndex = 101;
            this.label30.Text = "ms";
            // 
            // comboFriendType
            // 
            this.comboFriendType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboFriendType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboFriendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFriendType.Enabled = false;
            this.comboFriendType.EnabledCalc = true;
            this.comboFriendType.FormattingEnabled = true;
            this.comboFriendType.ItemHeight = 20;
            this.comboFriendType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboFriendType.Location = new System.Drawing.Point(66, 96);
            this.comboFriendType.Name = "comboFriendType";
            this.comboFriendType.Size = new System.Drawing.Size(130, 26);
            this.comboFriendType.TabIndex = 100;
            // 
            // txtFriendTimeout
            // 
            this.txtFriendTimeout.EnabledCalc = false;
            this.txtFriendTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFriendTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtFriendTimeout.Location = new System.Drawing.Point(66, 128);
            this.txtFriendTimeout.MaxLength = 32767;
            this.txtFriendTimeout.MultiLine = false;
            this.txtFriendTimeout.Name = "txtFriendTimeout";
            this.txtFriendTimeout.ReadOnly = false;
            this.txtFriendTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtFriendTimeout.TabIndex = 99;
            this.txtFriendTimeout.Text = "5000";
            this.txtFriendTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendTimeout.UseSystemPasswordChar = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 134);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 15);
            this.label31.TabIndex = 98;
            this.label31.Text = "Timeout:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 101);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 15);
            this.label32.TabIndex = 97;
            this.label32.Text = "Type:";
            // 
            // radioRemoveFriend
            // 
            this.radioRemoveFriend.Checked = false;
            this.radioRemoveFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioRemoveFriend.EnabledCalc = true;
            this.radioRemoveFriend.Location = new System.Drawing.Point(66, 216);
            this.radioRemoveFriend.Name = "radioRemoveFriend";
            this.radioRemoveFriend.Size = new System.Drawing.Size(130, 18);
            this.radioRemoveFriend.TabIndex = 96;
            this.radioRemoveFriend.Text = "Remove Friend";
            // 
            // radioAddFriend
            // 
            this.radioAddFriend.Checked = true;
            this.radioAddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioAddFriend.EnabledCalc = true;
            this.radioAddFriend.Location = new System.Drawing.Point(66, 192);
            this.radioAddFriend.Name = "radioAddFriend";
            this.radioAddFriend.Size = new System.Drawing.Size(130, 18);
            this.radioAddFriend.TabIndex = 95;
            this.radioAddFriend.Text = "Add Friend";
            // 
            // txtFriendUser
            // 
            this.txtFriendUser.EnabledCalc = true;
            this.txtFriendUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFriendUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtFriendUser.Location = new System.Drawing.Point(66, 240);
            this.txtFriendUser.MaxLength = 32767;
            this.txtFriendUser.MultiLine = false;
            this.txtFriendUser.Name = "txtFriendUser";
            this.txtFriendUser.ReadOnly = false;
            this.txtFriendUser.Size = new System.Drawing.Size(130, 29);
            this.txtFriendUser.TabIndex = 93;
            this.txtFriendUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendUser.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 92;
            this.label5.Text = "User ID:";
            // 
            // btnFriendStop
            // 
            this.btnFriendStop.EnabledCalc = false;
            this.btnFriendStop.Location = new System.Drawing.Point(66, 339);
            this.btnFriendStop.Name = "btnFriendStop";
            this.btnFriendStop.Size = new System.Drawing.Size(130, 23);
            this.btnFriendStop.TabIndex = 91;
            this.btnFriendStop.Text = "Stop";
            this.btnFriendStop.Click += new XylosButton.ClickEventHandler(this.btnFriendStop_Click);
            // 
            // btnFriendStart
            // 
            this.btnFriendStart.EnabledCalc = true;
            this.btnFriendStart.Location = new System.Drawing.Point(66, 310);
            this.btnFriendStart.Name = "btnFriendStart";
            this.btnFriendStart.Size = new System.Drawing.Size(130, 23);
            this.btnFriendStart.TabIndex = 90;
            this.btnFriendStart.Text = "Start";
            this.btnFriendStart.Click += new XylosButton.ClickEventHandler(this.btnFriendStart_Click);
            // 
            // chkFriendUseProxies
            // 
            this.chkFriendUseProxies.Checked = false;
            this.chkFriendUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFriendUseProxies.EnabledCalc = true;
            this.chkFriendUseProxies.Location = new System.Drawing.Point(66, 72);
            this.chkFriendUseProxies.Name = "chkFriendUseProxies";
            this.chkFriendUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkFriendUseProxies.TabIndex = 89;
            this.chkFriendUseProxies.Text = "Use Proxies?";
            this.chkFriendUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkFriendUseProxies_CheckedChanged);
            // 
            // txtFriendThreads
            // 
            this.txtFriendThreads.EnabledCalc = true;
            this.txtFriendThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFriendThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtFriendThreads.Location = new System.Drawing.Point(66, 8);
            this.txtFriendThreads.MaxLength = 32767;
            this.txtFriendThreads.MultiLine = false;
            this.txtFriendThreads.Name = "txtFriendThreads";
            this.txtFriendThreads.ReadOnly = false;
            this.txtFriendThreads.Size = new System.Drawing.Size(130, 29);
            this.txtFriendThreads.TabIndex = 88;
            this.txtFriendThreads.Text = "1";
            this.txtFriendThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendThreads.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 87;
            this.label11.Text = "Threads:";
            // 
            // btnFriendLoadProxies
            // 
            this.btnFriendLoadProxies.EnabledCalc = false;
            this.btnFriendLoadProxies.Location = new System.Drawing.Point(66, 163);
            this.btnFriendLoadProxies.Name = "btnFriendLoadProxies";
            this.btnFriendLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnFriendLoadProxies.TabIndex = 86;
            this.btnFriendLoadProxies.Text = "Load Proxies";
            this.btnFriendLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnFriendLoadProxies_Click);
            // 
            // btnFriendLoadTokens
            // 
            this.btnFriendLoadTokens.EnabledCalc = true;
            this.btnFriendLoadTokens.Location = new System.Drawing.Point(66, 43);
            this.btnFriendLoadTokens.Name = "btnFriendLoadTokens";
            this.btnFriendLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnFriendLoadTokens.TabIndex = 85;
            this.btnFriendLoadTokens.Text = "Load Tokens";
            this.btnFriendLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnFriendLoadTokens_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.lblReactionRemoved);
            this.tabPage7.Controls.Add(this.radioRemoveReaction);
            this.tabPage7.Controls.Add(this.radioAddReaction);
            this.tabPage7.Controls.Add(this.label58);
            this.tabPage7.Controls.Add(this.txtReactionDelay);
            this.tabPage7.Controls.Add(this.label59);
            this.tabPage7.Controls.Add(this.lblReactionAdded);
            this.tabPage7.Controls.Add(this.label33);
            this.tabPage7.Controls.Add(this.comboReactionType);
            this.tabPage7.Controls.Add(this.txtReactionTimeout);
            this.tabPage7.Controls.Add(this.label34);
            this.tabPage7.Controls.Add(this.label35);
            this.tabPage7.Controls.Add(this.txtReactionEmoji);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.txtReactionMessage);
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Controls.Add(this.txtReactionChannel);
            this.tabPage7.Controls.Add(this.label9);
            this.tabPage7.Controls.Add(this.btnReactionStop);
            this.tabPage7.Controls.Add(this.btnReactionStart);
            this.tabPage7.Controls.Add(this.chkReactionUseProxies);
            this.tabPage7.Controls.Add(this.txtReactionThreads);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.btnReactionLoadProxies);
            this.tabPage7.Controls.Add(this.btnReactionLoadTokens);
            this.tabPage7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage7.Location = new System.Drawing.Point(184, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(225, 476);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Reaction Spammer";
            // 
            // lblReactionRemoved
            // 
            this.lblReactionRemoved.AutoSize = true;
            this.lblReactionRemoved.Location = new System.Drawing.Point(79, 455);
            this.lblReactionRemoved.Name = "lblReactionRemoved";
            this.lblReactionRemoved.Size = new System.Drawing.Size(69, 15);
            this.lblReactionRemoved.TabIndex = 109;
            this.lblReactionRemoved.Text = "Removed: 0";
            // 
            // radioRemoveReaction
            // 
            this.radioRemoveReaction.Checked = false;
            this.radioRemoveReaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioRemoveReaction.EnabledCalc = true;
            this.radioRemoveReaction.Location = new System.Drawing.Point(82, 216);
            this.radioRemoveReaction.Name = "radioRemoveReaction";
            this.radioRemoveReaction.Size = new System.Drawing.Size(130, 18);
            this.radioRemoveReaction.TabIndex = 108;
            this.radioRemoveReaction.Text = "Remove Reaction";
            // 
            // radioAddReaction
            // 
            this.radioAddReaction.Checked = true;
            this.radioAddReaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioAddReaction.EnabledCalc = true;
            this.radioAddReaction.Location = new System.Drawing.Point(82, 192);
            this.radioAddReaction.Name = "radioAddReaction";
            this.radioAddReaction.Size = new System.Drawing.Size(130, 18);
            this.radioAddReaction.TabIndex = 107;
            this.radioAddReaction.Text = "Add Reaction";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(189, 351);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(23, 15);
            this.label58.TabIndex = 106;
            this.label58.Text = "ms";
            // 
            // txtReactionDelay
            // 
            this.txtReactionDelay.EnabledCalc = true;
            this.txtReactionDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReactionDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtReactionDelay.Location = new System.Drawing.Point(82, 345);
            this.txtReactionDelay.MaxLength = 32767;
            this.txtReactionDelay.MultiLine = false;
            this.txtReactionDelay.Name = "txtReactionDelay";
            this.txtReactionDelay.ReadOnly = false;
            this.txtReactionDelay.Size = new System.Drawing.Size(105, 29);
            this.txtReactionDelay.TabIndex = 105;
            this.txtReactionDelay.Text = "100";
            this.txtReactionDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReactionDelay.UseSystemPasswordChar = false;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(6, 351);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(39, 15);
            this.label59.TabIndex = 104;
            this.label59.Text = "Delay:";
            // 
            // lblReactionAdded
            // 
            this.lblReactionAdded.AutoSize = true;
            this.lblReactionAdded.Location = new System.Drawing.Point(79, 435);
            this.lblReactionAdded.Name = "lblReactionAdded";
            this.lblReactionAdded.Size = new System.Drawing.Size(54, 15);
            this.lblReactionAdded.TabIndex = 103;
            this.lblReactionAdded.Text = "Added: 0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(189, 134);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 15);
            this.label33.TabIndex = 102;
            this.label33.Text = "ms";
            // 
            // comboReactionType
            // 
            this.comboReactionType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboReactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboReactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReactionType.Enabled = false;
            this.comboReactionType.EnabledCalc = true;
            this.comboReactionType.FormattingEnabled = true;
            this.comboReactionType.ItemHeight = 20;
            this.comboReactionType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboReactionType.Location = new System.Drawing.Point(82, 96);
            this.comboReactionType.Name = "comboReactionType";
            this.comboReactionType.Size = new System.Drawing.Size(130, 26);
            this.comboReactionType.TabIndex = 101;
            // 
            // txtReactionTimeout
            // 
            this.txtReactionTimeout.EnabledCalc = false;
            this.txtReactionTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReactionTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtReactionTimeout.Location = new System.Drawing.Point(82, 128);
            this.txtReactionTimeout.MaxLength = 32767;
            this.txtReactionTimeout.MultiLine = false;
            this.txtReactionTimeout.Name = "txtReactionTimeout";
            this.txtReactionTimeout.ReadOnly = false;
            this.txtReactionTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtReactionTimeout.TabIndex = 100;
            this.txtReactionTimeout.Text = "5000";
            this.txtReactionTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReactionTimeout.UseSystemPasswordChar = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 134);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(54, 15);
            this.label34.TabIndex = 99;
            this.label34.Text = "Timeout:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 101);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 15);
            this.label35.TabIndex = 98;
            this.label35.Text = "Type:";
            // 
            // txtReactionEmoji
            // 
            this.txtReactionEmoji.EnabledCalc = true;
            this.txtReactionEmoji.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReactionEmoji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtReactionEmoji.Location = new System.Drawing.Point(82, 310);
            this.txtReactionEmoji.MaxLength = 32767;
            this.txtReactionEmoji.MultiLine = false;
            this.txtReactionEmoji.Name = "txtReactionEmoji";
            this.txtReactionEmoji.ReadOnly = false;
            this.txtReactionEmoji.Size = new System.Drawing.Size(130, 29);
            this.txtReactionEmoji.TabIndex = 97;
            this.txtReactionEmoji.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReactionEmoji.UseSystemPasswordChar = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 96;
            this.label15.Text = "Emoji ID:";
            // 
            // txtReactionMessage
            // 
            this.txtReactionMessage.EnabledCalc = true;
            this.txtReactionMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReactionMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtReactionMessage.Location = new System.Drawing.Point(82, 275);
            this.txtReactionMessage.MaxLength = 32767;
            this.txtReactionMessage.MultiLine = false;
            this.txtReactionMessage.Name = "txtReactionMessage";
            this.txtReactionMessage.ReadOnly = false;
            this.txtReactionMessage.Size = new System.Drawing.Size(130, 29);
            this.txtReactionMessage.TabIndex = 95;
            this.txtReactionMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReactionMessage.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 94;
            this.label4.Text = "Message ID:";
            // 
            // txtReactionChannel
            // 
            this.txtReactionChannel.EnabledCalc = true;
            this.txtReactionChannel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReactionChannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtReactionChannel.Location = new System.Drawing.Point(82, 240);
            this.txtReactionChannel.MaxLength = 32767;
            this.txtReactionChannel.MultiLine = false;
            this.txtReactionChannel.Name = "txtReactionChannel";
            this.txtReactionChannel.ReadOnly = false;
            this.txtReactionChannel.Size = new System.Drawing.Size(130, 29);
            this.txtReactionChannel.TabIndex = 93;
            this.txtReactionChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReactionChannel.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 92;
            this.label9.Text = "Channel ID:";
            // 
            // btnReactionStop
            // 
            this.btnReactionStop.EnabledCalc = false;
            this.btnReactionStop.Location = new System.Drawing.Point(82, 409);
            this.btnReactionStop.Name = "btnReactionStop";
            this.btnReactionStop.Size = new System.Drawing.Size(130, 23);
            this.btnReactionStop.TabIndex = 91;
            this.btnReactionStop.Text = "Stop";
            this.btnReactionStop.Click += new XylosButton.ClickEventHandler(this.btnReactionStop_Click);
            // 
            // btnReactionStart
            // 
            this.btnReactionStart.EnabledCalc = true;
            this.btnReactionStart.Location = new System.Drawing.Point(82, 380);
            this.btnReactionStart.Name = "btnReactionStart";
            this.btnReactionStart.Size = new System.Drawing.Size(130, 23);
            this.btnReactionStart.TabIndex = 90;
            this.btnReactionStart.Text = "Start";
            this.btnReactionStart.Click += new XylosButton.ClickEventHandler(this.btnReactionStart_Click);
            // 
            // chkReactionUseProxies
            // 
            this.chkReactionUseProxies.Checked = false;
            this.chkReactionUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkReactionUseProxies.EnabledCalc = true;
            this.chkReactionUseProxies.Location = new System.Drawing.Point(82, 72);
            this.chkReactionUseProxies.Name = "chkReactionUseProxies";
            this.chkReactionUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkReactionUseProxies.TabIndex = 89;
            this.chkReactionUseProxies.Text = "Use Proxies?";
            this.chkReactionUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkReactionUseProxies_CheckedChanged);
            // 
            // txtReactionThreads
            // 
            this.txtReactionThreads.EnabledCalc = true;
            this.txtReactionThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReactionThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtReactionThreads.Location = new System.Drawing.Point(82, 8);
            this.txtReactionThreads.MaxLength = 32767;
            this.txtReactionThreads.MultiLine = false;
            this.txtReactionThreads.Name = "txtReactionThreads";
            this.txtReactionThreads.ReadOnly = false;
            this.txtReactionThreads.Size = new System.Drawing.Size(130, 29);
            this.txtReactionThreads.TabIndex = 88;
            this.txtReactionThreads.Text = "1";
            this.txtReactionThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReactionThreads.UseSystemPasswordChar = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 87;
            this.label14.Text = "Threads:";
            // 
            // btnReactionLoadProxies
            // 
            this.btnReactionLoadProxies.EnabledCalc = false;
            this.btnReactionLoadProxies.Location = new System.Drawing.Point(82, 163);
            this.btnReactionLoadProxies.Name = "btnReactionLoadProxies";
            this.btnReactionLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnReactionLoadProxies.TabIndex = 86;
            this.btnReactionLoadProxies.Text = "Load Proxies";
            this.btnReactionLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnReactionLoadProxies_Click);
            // 
            // btnReactionLoadTokens
            // 
            this.btnReactionLoadTokens.EnabledCalc = true;
            this.btnReactionLoadTokens.Location = new System.Drawing.Point(82, 43);
            this.btnReactionLoadTokens.Name = "btnReactionLoadTokens";
            this.btnReactionLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnReactionLoadTokens.TabIndex = 85;
            this.btnReactionLoadTokens.Text = "Load Tokens";
            this.btnReactionLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnReactionLoadTokens_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Controls.Add(this.label60);
            this.tabPage8.Controls.Add(this.txtTypingDelay);
            this.tabPage8.Controls.Add(this.label61);
            this.tabPage8.Controls.Add(this.lblTyping);
            this.tabPage8.Controls.Add(this.label36);
            this.tabPage8.Controls.Add(this.comboTypingType);
            this.tabPage8.Controls.Add(this.txtTypingTimeout);
            this.tabPage8.Controls.Add(this.label37);
            this.tabPage8.Controls.Add(this.label38);
            this.tabPage8.Controls.Add(this.txtTypingChannel);
            this.tabPage8.Controls.Add(this.label7);
            this.tabPage8.Controls.Add(this.btnTypingStop);
            this.tabPage8.Controls.Add(this.btnTypingStart);
            this.tabPage8.Controls.Add(this.chkTypingUseProxies);
            this.tabPage8.Controls.Add(this.txtTypingThreads);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.btnTypingLoadProxies);
            this.tabPage8.Controls.Add(this.btnTypingLoadTokens);
            this.tabPage8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage8.Location = new System.Drawing.Point(184, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(225, 476);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Typing Spammer";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(187, 233);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(23, 15);
            this.label60.TabIndex = 111;
            this.label60.Text = "ms";
            // 
            // txtTypingDelay
            // 
            this.txtTypingDelay.EnabledCalc = true;
            this.txtTypingDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypingDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtTypingDelay.Location = new System.Drawing.Point(80, 227);
            this.txtTypingDelay.MaxLength = 32767;
            this.txtTypingDelay.MultiLine = false;
            this.txtTypingDelay.Name = "txtTypingDelay";
            this.txtTypingDelay.ReadOnly = false;
            this.txtTypingDelay.Size = new System.Drawing.Size(105, 29);
            this.txtTypingDelay.TabIndex = 110;
            this.txtTypingDelay.Text = "100";
            this.txtTypingDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTypingDelay.UseSystemPasswordChar = false;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 233);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(39, 15);
            this.label61.TabIndex = 109;
            this.label61.Text = "Delay:";
            // 
            // lblTyping
            // 
            this.lblTyping.AutoSize = true;
            this.lblTyping.Location = new System.Drawing.Point(77, 317);
            this.lblTyping.Name = "lblTyping";
            this.lblTyping.Size = new System.Drawing.Size(54, 15);
            this.lblTyping.TabIndex = 108;
            this.lblTyping.Text = "Typing: 0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(187, 134);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 15);
            this.label36.TabIndex = 107;
            this.label36.Text = "ms";
            // 
            // comboTypingType
            // 
            this.comboTypingType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTypingType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTypingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypingType.Enabled = false;
            this.comboTypingType.EnabledCalc = true;
            this.comboTypingType.FormattingEnabled = true;
            this.comboTypingType.ItemHeight = 20;
            this.comboTypingType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4a",
            "SOCKS5"});
            this.comboTypingType.Location = new System.Drawing.Point(80, 96);
            this.comboTypingType.Name = "comboTypingType";
            this.comboTypingType.Size = new System.Drawing.Size(130, 26);
            this.comboTypingType.TabIndex = 106;
            // 
            // txtTypingTimeout
            // 
            this.txtTypingTimeout.EnabledCalc = false;
            this.txtTypingTimeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypingTimeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtTypingTimeout.Location = new System.Drawing.Point(80, 128);
            this.txtTypingTimeout.MaxLength = 32767;
            this.txtTypingTimeout.MultiLine = false;
            this.txtTypingTimeout.Name = "txtTypingTimeout";
            this.txtTypingTimeout.ReadOnly = false;
            this.txtTypingTimeout.Size = new System.Drawing.Size(105, 29);
            this.txtTypingTimeout.TabIndex = 105;
            this.txtTypingTimeout.Text = "5000";
            this.txtTypingTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTypingTimeout.UseSystemPasswordChar = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 134);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(54, 15);
            this.label37.TabIndex = 104;
            this.label37.Text = "Timeout:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 101);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(34, 15);
            this.label38.TabIndex = 103;
            this.label38.Text = "Type:";
            // 
            // txtTypingChannel
            // 
            this.txtTypingChannel.EnabledCalc = true;
            this.txtTypingChannel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypingChannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtTypingChannel.Location = new System.Drawing.Point(80, 192);
            this.txtTypingChannel.MaxLength = 32767;
            this.txtTypingChannel.MultiLine = false;
            this.txtTypingChannel.Name = "txtTypingChannel";
            this.txtTypingChannel.ReadOnly = false;
            this.txtTypingChannel.Size = new System.Drawing.Size(130, 29);
            this.txtTypingChannel.TabIndex = 102;
            this.txtTypingChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTypingChannel.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 101;
            this.label7.Text = "Channel ID:";
            // 
            // btnTypingStop
            // 
            this.btnTypingStop.EnabledCalc = false;
            this.btnTypingStop.Location = new System.Drawing.Point(80, 291);
            this.btnTypingStop.Name = "btnTypingStop";
            this.btnTypingStop.Size = new System.Drawing.Size(130, 23);
            this.btnTypingStop.TabIndex = 100;
            this.btnTypingStop.Text = "Stop";
            this.btnTypingStop.Click += new XylosButton.ClickEventHandler(this.btnTypingStop_Click);
            // 
            // btnTypingStart
            // 
            this.btnTypingStart.EnabledCalc = true;
            this.btnTypingStart.Location = new System.Drawing.Point(80, 262);
            this.btnTypingStart.Name = "btnTypingStart";
            this.btnTypingStart.Size = new System.Drawing.Size(130, 23);
            this.btnTypingStart.TabIndex = 99;
            this.btnTypingStart.Text = "Start";
            this.btnTypingStart.Click += new XylosButton.ClickEventHandler(this.btnTypingStart_Click);
            // 
            // chkTypingUseProxies
            // 
            this.chkTypingUseProxies.Checked = false;
            this.chkTypingUseProxies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTypingUseProxies.EnabledCalc = true;
            this.chkTypingUseProxies.Location = new System.Drawing.Point(80, 72);
            this.chkTypingUseProxies.Name = "chkTypingUseProxies";
            this.chkTypingUseProxies.Size = new System.Drawing.Size(100, 18);
            this.chkTypingUseProxies.TabIndex = 98;
            this.chkTypingUseProxies.Text = "Use Proxies?";
            this.chkTypingUseProxies.CheckedChanged += new XylosCheckBox.CheckedChangedEventHandler(this.chkTypingUseProxies_CheckedChanged);
            // 
            // txtTypingThreads
            // 
            this.txtTypingThreads.EnabledCalc = true;
            this.txtTypingThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTypingThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtTypingThreads.Location = new System.Drawing.Point(80, 8);
            this.txtTypingThreads.MaxLength = 32767;
            this.txtTypingThreads.MultiLine = false;
            this.txtTypingThreads.Name = "txtTypingThreads";
            this.txtTypingThreads.ReadOnly = false;
            this.txtTypingThreads.Size = new System.Drawing.Size(130, 29);
            this.txtTypingThreads.TabIndex = 97;
            this.txtTypingThreads.Text = "1";
            this.txtTypingThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTypingThreads.UseSystemPasswordChar = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 15);
            this.label16.TabIndex = 96;
            this.label16.Text = "Threads:";
            // 
            // btnTypingLoadProxies
            // 
            this.btnTypingLoadProxies.EnabledCalc = false;
            this.btnTypingLoadProxies.Location = new System.Drawing.Point(80, 163);
            this.btnTypingLoadProxies.Name = "btnTypingLoadProxies";
            this.btnTypingLoadProxies.Size = new System.Drawing.Size(130, 23);
            this.btnTypingLoadProxies.TabIndex = 95;
            this.btnTypingLoadProxies.Text = "Load Proxies";
            this.btnTypingLoadProxies.Click += new XylosButton.ClickEventHandler(this.btnTypingLoadProxies_Click);
            // 
            // btnTypingLoadTokens
            // 
            this.btnTypingLoadTokens.EnabledCalc = true;
            this.btnTypingLoadTokens.Location = new System.Drawing.Point(80, 43);
            this.btnTypingLoadTokens.Name = "btnTypingLoadTokens";
            this.btnTypingLoadTokens.Size = new System.Drawing.Size(130, 23);
            this.btnTypingLoadTokens.TabIndex = 94;
            this.btnTypingLoadTokens.Text = "Load Tokens";
            this.btnTypingLoadTokens.Click += new XylosButton.ClickEventHandler(this.btnTypingLoadTokens_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 484);
            this.Controls.Add(this.xylosTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DiscordAIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.xylosTabControl1.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XylosTabControl xylosTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTokenCheckerInvalid;
        private System.Windows.Forms.Label lblTokenCheckerUnverified;
        private System.Windows.Forms.Label lblTokenCheckerProxies;
        private System.Windows.Forms.Label lblTokenCheckerTokens;
        private XylosButton btnTokenCheckerLoadProxies;
        private XylosButton btnCheckerLoadTokens;
        private XylosTextBox txtTokenCheckerThreads;
        private System.Windows.Forms.Label label6;
        private XylosButton btnTokenCheckerStop;
        private XylosButton btnTokenCheckerStart;
        private XylosCheckBox chkCheckerUseProxies;
        private System.Windows.Forms.Label lblCheckerRetries;
        private XylosCheckBox chkSpammerUseProxies;
        private XylosButton btnSpammerStop;
        private XylosButton btnSpammerStart;
        private XylosTextBox txtSpammerThreads;
        private System.Windows.Forms.Label label1;
        private XylosButton btnSpammerLoadProxies;
        private XylosButton btnSpammerLoadTokens;
        private XylosTextBox txtSpammerChannel;
        private System.Windows.Forms.Label label3;
        private XylosTextBox txtSpammerMessages;
        private System.Windows.Forms.Label label2;
        private XylosButton btnSpammerLoadMessages;
        private System.Windows.Forms.Label lblMessagesSent;
        private System.Windows.Forms.TabPage tabPage4;
        private XylosTextBox txtJoinerCode;
        private System.Windows.Forms.Label label10;
        private XylosButton btnJoinerStop;
        private XylosButton btnJoinerStart;
        private XylosCheckBox chkJoinerUseProxies;
        private XylosTextBox txtJoinerThreads;
        private System.Windows.Forms.Label label8;
        private XylosButton btnJoinerLoadProxies;
        private XylosButton btnJoinerLoadTokens;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label lblUsersJoined;
        private System.Windows.Forms.Label lblUsersLeft;
        private XylosTextBox txtLeaverServer;
        private System.Windows.Forms.Label label12;
        private XylosButton btnLeaverStop;
        private XylosButton btnLeaverStart;
        private XylosCheckBox chkLeaverUseProxies;
        private XylosTextBox txtLeaverThreads;
        private System.Windows.Forms.Label label13;
        private XylosButton btnLeaverLoadProxies;
        private XylosButton btnLeaverLoadTokens;
        private XylosRadioButton radioRemoveFriend;
        private XylosRadioButton radioAddFriend;
        private XylosTextBox txtFriendUser;
        private System.Windows.Forms.Label label5;
        private XylosButton btnFriendStop;
        private XylosButton btnFriendStart;
        private XylosCheckBox chkFriendUseProxies;
        private XylosTextBox txtFriendThreads;
        private System.Windows.Forms.Label label11;
        private XylosButton btnFriendLoadProxies;
        private XylosButton btnFriendLoadTokens;
        private XylosTextBox txtReactionEmoji;
        private System.Windows.Forms.Label label15;
        private XylosTextBox txtReactionMessage;
        private System.Windows.Forms.Label label4;
        private XylosTextBox txtReactionChannel;
        private System.Windows.Forms.Label label9;
        private XylosButton btnReactionStop;
        private XylosButton btnReactionStart;
        private XylosCheckBox chkReactionUseProxies;
        private XylosTextBox txtReactionThreads;
        private System.Windows.Forms.Label label14;
        private XylosButton btnReactionLoadProxies;
        private XylosButton btnReactionLoadTokens;
        private XylosTextBox txtTypingChannel;
        private System.Windows.Forms.Label label7;
        private XylosButton btnTypingStop;
        private XylosButton btnTypingStart;
        private XylosCheckBox chkTypingUseProxies;
        private XylosTextBox txtTypingThreads;
        private System.Windows.Forms.Label label16;
        private XylosButton btnTypingLoadProxies;
        private XylosButton btnTypingLoadTokens;
        private System.Windows.Forms.Label label20;
        private XylosCombobox comboCheckerType;
        private XylosTextBox txtCheckerTimeout;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private XylosCombobox comboJoinerType;
        private XylosTextBox txtJoinerTimeout;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private XylosCombobox comboLeaverType;
        private XylosTextBox txtLeaverTimeout;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private XylosCombobox comboSpammerType;
        private XylosTextBox txtSpammerTimeout;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label30;
        private XylosCombobox comboFriendType;
        private XylosTextBox txtFriendTimeout;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private XylosCombobox comboReactionType;
        private XylosTextBox txtReactionTimeout;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private XylosCombobox comboTypingType;
        private XylosTextBox txtTypingTimeout;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label42;
        private XylosCombobox comboScraperAnonymity;
        private System.Windows.Forms.Label label41;
        private XylosCombobox comboScraperCountry;
        private System.Windows.Forms.Label label40;
        private XylosCombobox comboScraperType;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label43;
        private XylosTextBox txtScraperTimeout;
        private System.Windows.Forms.Label lblScraperLastUpdated;
        private System.Windows.Forms.Label lblScraperProxiesFetched;
        private XylosButton btnScraperSaveProxies;
        private XylosButton btnScraperCopyToClipboard;
        private XylosButton btnScraperFetch;
        private System.Windows.Forms.Label lblTokenCheckerVerified;
        private System.Windows.Forms.TabPage tabPage3;
        private XylosButton btnDMLoadMessages;
        private XylosTextBox txtDMUserId;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label17;
        private XylosCombobox comboDMType;
        private XylosTextBox txtDMTimeout;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private XylosButton btnDMStop;
        private XylosButton btnDMStart;
        private XylosCheckBox chkDMUseProxies;
        private XylosTextBox txtDMThreads;
        private System.Windows.Forms.Label label46;
        private XylosButton btnDMLoadProxies;
        private XylosButton btnDMLoadTokens;
        private System.Windows.Forms.Label lblDMSent;
        private System.Windows.Forms.Label lblRemoved;
        private System.Windows.Forms.Label lblAdded;
        private System.Windows.Forms.Label lblReactionAdded;
        private System.Windows.Forms.Label lblTyping;
        private System.Windows.Forms.Label label49;
        private XylosTextBox txtJoinerDelay;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private XylosTextBox txtLeaverDelay;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label53;
        private XylosTextBox txtSpammerDelay;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
        private XylosTextBox txtDMDelay;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private XylosTextBox txtFriendDelay;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private XylosTextBox txtReactionDelay;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private XylosTextBox txtTypingDelay;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label62;
        private XylosTextBox txtNicknameDelay;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label lblChanged;
        private XylosTextBox txtNickname;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private XylosCombobox comboNicknameType;
        private XylosTextBox txtNicknameTimeout;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private XylosButton btnNicknameStop;
        private XylosButton btnNicknameStart;
        private XylosCheckBox chkNicknameUseProxies;
        private XylosTextBox txtNicknameThreads;
        private System.Windows.Forms.Label label69;
        private XylosButton btnNicknameLoadProxies;
        private XylosButton btnNicknameLoadTokens;
        private XylosTextBox txtNicknameServer;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lblReactionRemoved;
        private XylosRadioButton radioRemoveReaction;
        private XylosRadioButton radioAddReaction;
        private System.Windows.Forms.Label label70;
        private XylosCombobox comboScraperSSL;
        private System.Windows.Forms.Label label71;
    }
}


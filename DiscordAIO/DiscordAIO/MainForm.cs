using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using HttpStatusCode = Leaf.xNet.HttpStatusCode;
using System.Text.RegularExpressions;

namespace DiscordAIO
{
    public partial class MainForm : Form
    {
        private string scrapedProxies;
        private List<string> checkerTokens;
        private List<string> checkerProxies;
        private List<string> joinerTokens;
        private List<string> joinerProxies;
        private List<string> leaverTokens;
        private List<string> leaverProxies;
        private List<string> dmTokens;
        private List<string> dmMessages;
        private List<string> dmProxies;
        private List<string> spammerTokens;
        private List<string> spammerMessages;
        private List<string> spammerProxies;
        private List<string> nicknameTokens;
        private List<string> nicknameProxies;
        private List<string> friendTokens;
        private List<string> friendProxies;
        private List<string> reactionTokens;
        private List<string> reactionProxies;
        private List<string> typingTokens;
        private List<string> typingProxies;
        private int tokenCheckerVerified;
        private int tokenCheckerUnverified;
        private int tokenCheckerInvalid;
        private int tokenCheckerRetries;
        private StreamWriter verifiedTokens;
        private StreamWriter unverifiedTokens;
        private StreamWriter invalidTokens;
        private CancellationTokenSource tokenCheckerTokenSource;
        private CancellationTokenSource joinerTokenSource;
        private CancellationTokenSource leaverTokenSource;
        private CancellationTokenSource dmTokenSource;
        private CancellationTokenSource spammerTokenSource;
        private CancellationTokenSource nicknameTokenSource;
        private CancellationTokenSource friendTokenSource;
        private CancellationTokenSource reactionTokenSource;
        private CancellationTokenSource typingTokenSource;
        private int dmSent;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void chkCheckerUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnTokenCheckerLoadProxies.Enabled = chkCheckerUseProxies.Checked;
            comboCheckerType.Enabled = chkCheckerUseProxies.Checked;
            txtCheckerTimeout.Enabled = chkCheckerUseProxies.Checked;
        }

        private void btnCheckerLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                checkerTokens = Utilities.LoadFile(fileName);
                lblTokenCheckerTokens.Text = $"Loaded Tokens: {checkerTokens.Count}";
                MessageBox.Show($"Loaded {checkerTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTokenCheckerLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                checkerProxies = Utilities.LoadFile(fileName);
                lblTokenCheckerProxies.Text = $"Loaded Proxies: {checkerProxies.Count}";
                MessageBox.Show($"Loaded {checkerProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnTokenCheckerStart_Click(object sender, EventArgs e)
        {
            if (checkerTokens == null || !checkerTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkCheckerUseProxies.Checked)
            {
                if (checkerProxies == null || !checkerProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            txtTokenCheckerThreads.Enabled = false;
            btnCheckerLoadTokens.Enabled = false;
            btnTokenCheckerLoadProxies.Enabled = false;
            btnTokenCheckerStart.Enabled = false;
            btnTokenCheckerStop.Enabled = true;
            lblTokenCheckerVerified.Text = "Verified Tokens: 0";
            lblTokenCheckerUnverified.Text = "Unverified Tokens: 0";
            lblTokenCheckerInvalid.Text = "Invalid Tokens: 0";
            lblCheckerRetries.Text = "Retries: 0";
            tokenCheckerVerified = 0;
            tokenCheckerUnverified = 0;
            tokenCheckerInvalid = 0;
            tokenCheckerRetries = 0;

            CreateDirectory();

            ThreadPool.SetMinThreads(Convert.ToInt32(txtTokenCheckerThreads.Text), Convert.ToInt32(txtTokenCheckerThreads.Text));

            tokenCheckerTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = tokenCheckerTokenSource.Token;

            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = Convert.ToInt32(txtTokenCheckerThreads.Text),
                CancellationToken = cancellationToken
            };

            try
            {
                await Task.Run(() => Parallel.ForEach(checkerTokens, parallelOptions, CheckToken), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // ignored
            }

            invalidTokens.Dispose();
            unverifiedTokens.Dispose();
            verifiedTokens.Dispose();

            txtTokenCheckerThreads.Enabled = true;
            btnCheckerLoadTokens.Enabled = true;
            btnTokenCheckerLoadProxies.Enabled = true;
            btnTokenCheckerStart.Enabled = true;
            btnTokenCheckerStop.Enabled = false;
            MessageBox.Show($"Checked {checkerTokens.Count} tokens. The results are stored in the 'Results' directory.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateDirectory()
        {
            string text = $"Results/TC-{DateTime.Now:MM-dd-yy-hh-mm-ss}";
            Directory.CreateDirectory(text);
            invalidTokens = new StreamWriter($"{text}/invalid-tokens.txt", true)
            {
                AutoFlush = true
            };
            verifiedTokens = new StreamWriter($"{text}/verified-tokens.txt", true)
            {
                AutoFlush = true
            };
            unverifiedTokens = new StreamWriter($"{text}/unverified-tokens.txt", true)
            {
                AutoFlush = true
            };
        }

        private void CheckToken(string token)
        {
            try
            {
                using (var webClient = new HttpRequest())
                {
                    if (chkCheckerUseProxies.Checked)
                    {
                        ProxyType proxyType;

                        switch (comboCheckerType.Text)
                        {
                            case "HTTP":
                                proxyType = ProxyType.HTTP;
                                break;
                            case "SOCKS4":
                                proxyType = ProxyType.Socks4;
                                break;
                            case "SOCKS4a":
                                proxyType = ProxyType.Socks4A;
                                break;
                            case "SOCKS5":
                                proxyType = ProxyType.Socks5;
                                break;
                            default:
                                proxyType = ProxyType.HTTP;
                                break;
                        }

                        webClient.Proxy = ProxyClient.Parse(proxyType,
                            checkerProxies[new Random().Next(checkerProxies.Count)]);
                        webClient.Proxy.ReadWriteTimeout = Convert.ToInt32(txtCheckerTimeout.Text);
                        webClient.Proxy.ConnectTimeout = Convert.ToInt32(txtCheckerTimeout.Text);
                    }

                    webClient.AddHeader("authorization", token);
                    webClient.UserAgentRandomize();
                    webClient.SslProtocols = (SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12);
                    var response = webClient.Get("https://discordapp.com/api/v7/users/@me").ToString();
                    string verified = new Regex("\"verified\": (.*?),").Match(response).Groups[1].Value;
                    if (verified == "true")
                    {
                        Interlocked.Increment(ref tokenCheckerVerified);
                        lblTokenCheckerVerified.Text = $"Verified Tokens: {tokenCheckerVerified}";
                        WriteLine(verifiedTokens, token);
                    }
                    else
                    {
                        Interlocked.Increment(ref tokenCheckerUnverified);
                        lblTokenCheckerUnverified.Text = $"Unverified Tokens: {tokenCheckerUnverified}";
                        WriteLine(unverifiedTokens, token);
                    }
                }
            }
            catch (HttpException e)
            {
                var response = e.HttpStatusCode;

                if (response == HttpStatusCode.Unauthorized) // 401 Token Invalid
                {
                    Interlocked.Increment(ref tokenCheckerInvalid);
                    lblTokenCheckerInvalid.Text = $"Invalid Tokens: {tokenCheckerInvalid}";
                    WriteLine(invalidTokens, token);
                }
                else
                {
                    Interlocked.Increment(ref tokenCheckerRetries);
                    lblCheckerRetries.Text = $"Retries: {tokenCheckerRetries}";
                    CheckToken(token); // proxy rate limited, switching proxy (hopefully)...
                }
            }
            catch (Exception)
            {
                Interlocked.Increment(ref tokenCheckerInvalid);
                lblTokenCheckerInvalid.Text = $"Invalid Tokens: {tokenCheckerInvalid}";
                WriteLine(invalidTokens, token);
            }
        }

        private void btnTokenCheckerStop_Click(object sender, EventArgs e)
        {
            tokenCheckerTokenSource.Cancel();
        }

        private void WriteLine(StreamWriter streamWriter, string line)
        {
            lock (streamWriter)
            {
                streamWriter.WriteLine(line);
            }
        }

        private void chkSpammerUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnSpammerLoadProxies.Enabled = chkSpammerUseProxies.Checked;
        }

        private void btnSpammerLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                spammerTokens = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {spammerTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpammerLoadMessages_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Messages");
                if (string.IsNullOrEmpty(fileName)) return;
                spammerMessages = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {spammerMessages.Count} messages.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpammerLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                spammerProxies = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {spammerProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        int amountTyping = 0;

        private void StartTyping(string token, string channelId)
        {
            try
            {
                if (rDiscord.Typing(
                    Client.Create(chkTypingUseProxies.Checked,
                        chkTypingUseProxies.Checked ? typingProxies[new Random().Next(typingProxies.Count)] : null,
                        comboTypingType.Text, txtTypingTimeout.Text, token), channelId))
                {
                    Interlocked.Increment(ref amountTyping);
                    lblTyping.Text = $"Typing: {amountTyping}";
                }
            }
            catch
            {
                // ignored
            }

            Thread.Sleep(Convert.ToInt32(txtTypingDelay.Text));
        }

        int amountJoined = 0;

        private void InviteThread(string token)
        {
            try
            {
                if (rDiscord.JoinServer(
                    Client.Create(chkJoinerUseProxies.Checked,
                        chkJoinerUseProxies.Checked ? joinerProxies[new Random().Next(joinerProxies.Count)] : null,
                        comboJoinerType.Text, txtJoinerTimeout.Text, token), txtJoinerCode.Text))
                {
                    Interlocked.Increment(ref amountJoined);
                    lblUsersJoined.Text = $"Users Joined: {amountJoined}";
                }
            }
            catch
            {
                // ignored
            }

            Thread.Sleep(Convert.ToInt32(txtJoinerDelay.Text));
        }

        int amountLeft = 0;

        private void LeaveThread(string token)
        {
            try
            {
                if (rDiscord.LeaveServer(
                    Client.Create(chkLeaverUseProxies.Checked,
                        chkLeaverUseProxies.Checked ? leaverProxies[new Random().Next(leaverProxies.Count)] : null,
                        comboLeaverType.Text, txtLeaverTimeout.Text, token), txtLeaverServer.Text))
                {
                    Interlocked.Increment(ref amountLeft);
                    lblUsersLeft.Text = $"Users Left: {amountLeft}";
                }
            }
            catch
            {
                // ignored
            }

            Thread.Sleep(Convert.ToInt32(txtLeaverDelay.Text));
        }

        int reactionsAdded;
        private int reactionsRemoved;

        private void btnSpammerStop_Click(object sender, EventArgs e)
        {
            spammerTokenSource.Cancel();
        }

        int messagesSent = 0;
        int messagesToSend = 0;

        private async void btnSpammerStart_Click(object sender, EventArgs e)
        {
            if (spammerTokens == null || !spammerTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkSpammerUseProxies.Checked)
            {
                if (spammerProxies == null || !spammerProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            bool nomessage = spammerMessages == null || spammerMessages.Count == 0;
            if (nomessage)
            {
                MessageBox.Show("Please provide a message list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool flag = txtSpammerChannel.Text == "";
            if (flag)
            {
                MessageBox.Show("Please provide a channel ID.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Have you invited the accounts?", "DiscordAIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes) MessageBox.Show("Please invite the accounts before trying to spam.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    messagesToSend = 0;
                    messagesSent = 0;
                    lblMessagesSent.Text = "Messages Sent: 0";

                    try
                    {
                        bool flag1 = txtSpammerMessages.Text == "∞";
                        if (flag1) messagesToSend = 1000000;
                        else messagesToSend = int.Parse(txtSpammerMessages.Text);
                    }
                    catch { return; }

                    btnSpammerStart.Enabled = false;
                    btnSpammerStop.Enabled = true;

                    ThreadPool.SetMinThreads(Convert.ToInt32(txtSpammerThreads.Text), Convert.ToInt32(txtSpammerThreads.Text));

                    spammerTokenSource = new CancellationTokenSource();
                    CancellationToken cancellationToken = spammerTokenSource.Token;

                    ParallelOptions parallelOptions = new ParallelOptions
                    {
                        MaxDegreeOfParallelism = Convert.ToInt32(txtSpammerThreads.Text),
                        CancellationToken = cancellationToken
                    };

                    try
                    {
                        while (!spammerTokenSource.IsCancellationRequested)
                            await Task.Run(() => Parallel.ForEach(spammerTokens, parallelOptions, SpamThread), cancellationToken);
                    }
                    catch (OperationCanceledException)
                    {
                        // ignored
                    }

                    btnSpammerStart.Enabled = true;
                    btnSpammerStop.Enabled = false;
                    MessageBox.Show($"Sent {messagesSent} messages.", "DiscordAIO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void SpamThread(string token)
        {
            if (messagesSent >= messagesToSend)
            {
                spammerTokenSource.Cancel();
            }

            if (!spammerTokenSource.IsCancellationRequested)
            {
                try
                {
                    if (string.IsNullOrEmpty(token))
                        return;
                    int num = rDiscord.SendChannelMessage(Client.Create(chkSpammerUseProxies.Checked, chkSpammerUseProxies.Checked ? spammerProxies[new Random().Next(spammerProxies.Count)] : null, comboSpammerType.Text, txtSpammerTimeout.Text, token), txtSpammerChannel.Text, spammerMessages[new Random().Next(spammerMessages.Count)]);
                    if (num == 1)
                    {
                        Interlocked.Increment(ref messagesSent);
                        lblMessagesSent.Text = $"Messages Sent: {messagesSent}";
                    }
                    else { Thread.Sleep(1000); }
                }
                catch
                {
                    // ignored
                }
            }

            Thread.Sleep(1 + Convert.ToInt32(txtSpammerDelay.Text));
        }

        private void btnJoinerLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                joinerTokens = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {joinerTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkJoinerUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnJoinerLoadProxies.Enabled = chkJoinerUseProxies.Checked;
            comboJoinerType.Enabled = chkJoinerUseProxies.Checked;
            txtJoinerTimeout.Enabled = chkJoinerUseProxies.Checked;
        }

        private void btnJoinerLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                joinerProxies = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {joinerProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnJoinerStart_Click(object sender, EventArgs e)
        {
            if (joinerTokens == null || !joinerTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkJoinerUseProxies.Checked)
            {
                if (joinerProxies == null || !joinerProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            try
            {
                bool flag = txtJoinerCode.Text == "";
                if (flag)
                {
                    MessageBox.Show("Please provide an invite code.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtJoinerCode.Text = txtJoinerCode.Text.Replace("https://discord.gg/", "").Replace("discord.gg", "");
            }
            catch
            {
                MessageBox.Show("Please provide an invite code.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool flag2 = !rDiscord.IsValidInvite(
                    Client.Create(false, null, null, "0", joinerTokens[new Random().Next(joinerTokens.Count)]),
                    txtJoinerCode.Text);
                if (flag2)
                {
                    MessageBox.Show("Invalid invite code or an error occured.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid invite code.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            amountJoined = 0;
            lblUsersJoined.Text = "Users Joined: 0";

            btnJoinerStart.Enabled = false;
            btnJoinerStop.Enabled = true;

            ThreadPool.SetMinThreads(Convert.ToInt32(txtJoinerThreads.Text), Convert.ToInt32(txtJoinerThreads.Text));

            joinerTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = joinerTokenSource.Token;

            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = Convert.ToInt32(txtJoinerThreads.Text),
                CancellationToken = cancellationToken
            };

            try
            {
                await Task.Run(() => Parallel.ForEach(joinerTokens, parallelOptions, InviteThread), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // ignored
            }

            btnJoinerStart.Enabled = true;
            btnJoinerStop.Enabled = false;
            MessageBox.Show($"Joined on {amountJoined} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnJoinerStop_Click(object sender, EventArgs e)
        {
            joinerTokenSource.Cancel();
        }

        private void btnLeaverLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                leaverTokens = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {leaverTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkLeaverUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnLeaverLoadProxies.Enabled = chkLeaverUseProxies.Checked;
            comboLeaverType.Enabled = chkLeaverUseProxies.Checked;
            txtLeaverTimeout.Enabled = chkLeaverUseProxies.Checked;
        }

        private void btnLeaverLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                leaverProxies = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {leaverProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLeaverStart_Click(object sender, EventArgs e)
        {
            if (leaverTokens == null || !leaverTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkLeaverUseProxies.Checked)
            {
                if (leaverProxies == null || !leaverProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            bool flag = txtLeaverServer.Text == "";
            if (flag)
                MessageBox.Show("Please provide a server ID.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                btnLeaverStart.Enabled = false;
                btnLeaverStop.Enabled = true;
                amountLeft = 0;
                lblUsersLeft.Text = "Users Left: 0";

                ThreadPool.SetMinThreads(Convert.ToInt32(txtLeaverThreads.Text), Convert.ToInt32(txtLeaverThreads.Text));

                leaverTokenSource = new CancellationTokenSource();
                CancellationToken cancellationToken = leaverTokenSource.Token;

                ParallelOptions parallelOptions = new ParallelOptions
                {
                    MaxDegreeOfParallelism = Convert.ToInt32(txtLeaverThreads.Text),
                    CancellationToken = cancellationToken
                };

                try
                {
                    await Task.Run(() => Parallel.ForEach(leaverTokens, parallelOptions, LeaveThread), cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    // ignored
                }

                btnLeaverStart.Enabled = true;
                btnLeaverStop.Enabled = false;

                MessageBox.Show($"Left on {amountLeft} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLeaverStop_Click(object sender, EventArgs e)
        {
            leaverTokenSource.Cancel();
        }

        private void btnFriendLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                friendTokens = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {friendTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkFriendUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnFriendLoadProxies.Enabled = chkFriendUseProxies.Checked;
            comboFriendType.Enabled = chkFriendUseProxies.Checked;
            txtFriendTimeout.Enabled = chkFriendUseProxies.Checked;
        }

        private void btnFriendLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                friendProxies = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {friendProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private int friendAdded, friendRemoved = 0;

        private async void btnFriendStart_Click(object sender, EventArgs e)
        {
            if (friendTokens == null || !friendTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkFriendUseProxies.Checked)
            {
                if (friendProxies == null || !friendProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            bool flag = txtFriendUser.Text.Length < 5 || txtFriendUser.Text == "";
            if (flag) 
                MessageBox.Show("Please provide a user ID.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                btnFriendStart.Enabled = false;
                btnFriendStop.Enabled = true;
                radioAddFriend.Enabled = false;
                radioRemoveFriend.Enabled = false;
                friendAdded = 0;
                friendRemoved = 0;
                lblAdded.Text = "Added: 0";
                lblRemoved.Text = "Removed: 0";
                ThreadPool.SetMinThreads(Convert.ToInt32(txtFriendThreads.Text), Convert.ToInt32(txtFriendThreads.Text));

                friendTokenSource = new CancellationTokenSource();
                CancellationToken cancellationToken = friendTokenSource.Token;

                ParallelOptions parallelOptions = new ParallelOptions
                {
                    MaxDegreeOfParallelism = Convert.ToInt32(txtFriendThreads.Text),
                    CancellationToken = cancellationToken
                };

                try
                {
                    await Task.Run(() => Parallel.ForEach(friendTokens, parallelOptions, delegate (string token)
                    {
                        try
                        {
                            if (radioAddFriend.Checked)
                            {
                                if (rDiscord.AddFriend(
                                    Client.Create(chkFriendUseProxies.Checked,
                                        chkFriendUseProxies.Checked
                                            ? friendProxies[new Random().Next(friendProxies.Count)]
                                            : null, comboFriendType.Text, txtFriendTimeout.Text, token),
                                    txtFriendUser.Text))
                                {
                                    Interlocked.Increment(ref friendAdded);
                                    lblAdded.Text = $"Added: {friendAdded}";
                                }
                            }
                            else if (radioRemoveFriend.Checked)
                            {
                                if (rDiscord.RemoveFriend(
                                    Client.Create(chkFriendUseProxies.Checked,
                                        chkFriendUseProxies.Checked
                                            ? friendProxies[new Random().Next(friendProxies.Count)]
                                            : null, comboFriendType.Text, txtFriendTimeout.Text, token),
                                    txtFriendUser.Text))
                                {
                                    Interlocked.Increment(ref friendRemoved);
                                    lblRemoved.Text = $"Removed: {friendRemoved}";
                                }
                            }
                        }
                        catch
                        {
                            // ignored
                        }

                        Thread.Sleep(Convert.ToInt32(txtFriendDelay.Text));
                    }), cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    // ignored
                }

                btnFriendStart.Enabled = true;
                btnFriendStop.Enabled = false;
                radioAddFriend.Enabled = true;
                radioRemoveFriend.Enabled = true;

                MessageBox.Show(radioAddFriend.Checked ? $"Added this user on {friendAdded} accounts." : $"Removed this user on {friendRemoved} accounts.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFriendStop_Click(object sender, EventArgs e)
        {
            friendTokenSource.Cancel();
        }

        private void btnReactionLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                reactionTokens = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {reactionTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkReactionUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnReactionLoadProxies.Enabled = chkReactionUseProxies.Checked;
            comboReactionType.Enabled = chkReactionUseProxies.Checked;
            txtReactionTimeout.Enabled = chkReactionUseProxies.Checked;
        }

        private void btnReactionLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                reactionProxies = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {reactionProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnReactionStart_Click(object sender, EventArgs e)
        {
            if (reactionTokens == null || !reactionTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkReactionUseProxies.Checked)
            {
                if (reactionProxies == null || !reactionProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            string channel = txtReactionChannel.Text;
            string message = txtReactionMessage.Text;
            string emoji = txtReactionEmoji.Text;
            bool add = radioAddReaction.Checked;
            bool remove = radioRemoveReaction.Checked;
            reactionsAdded = 0;
            lblReactionAdded.Text = "Added: 0";
            reactionsRemoved = 0;
            lblReactionRemoved.Text = "Removed: 0";
            btnReactionStart.Enabled = false;
            btnReactionStop.Enabled = true;

            ThreadPool.SetMinThreads(Convert.ToInt32(txtReactionThreads.Text), Convert.ToInt32(txtReactionThreads.Text));

            reactionTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = reactionTokenSource.Token;

            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = Convert.ToInt32(txtReactionThreads.Text),
                CancellationToken = cancellationToken
            };

            try
            {
                await Task.Run(() => Parallel.ForEach(reactionTokens, parallelOptions, delegate(string token)
                {
                    try
                    {
                        if (add)
                        {
                            if (rDiscord.AddReaction(
                                Client.Create(chkReactionUseProxies.Checked,
                                    chkReactionUseProxies.Checked
                                        ? reactionProxies[new Random().Next(reactionProxies.Count)]
                                        : null, comboReactionType.Text, txtReactionTimeout.Text, token), channel,
                                message,
                                emoji))
                            {
                                Interlocked.Increment(ref reactionsAdded);
                                lblReactionAdded.Text = $"Added: {reactionsAdded}";
                            }
                        }
                        else if (remove)
                        {
                            if (rDiscord.RemoveReaction(
                                Client.Create(chkReactionUseProxies.Checked,
                                    chkReactionUseProxies.Checked
                                        ? reactionProxies[new Random().Next(reactionProxies.Count)]
                                        : null, comboReactionType.Text, txtReactionTimeout.Text, token), channel,
                                message,
                                emoji))
                            {
                                Interlocked.Increment(ref reactionsRemoved);
                                lblReactionRemoved.Text = $"Removed: {reactionsRemoved}";
                            }
                        }
                    }
                    catch
                    {
                        // ignored
                    }

                    Thread.Sleep(Convert.ToInt32(txtReactionDelay.Text));
                }), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // ignored
            }

            btnReactionStart.Enabled = true;
            btnReactionStop.Enabled = false;
            MessageBox.Show(radioAddReaction.Checked ? $"Added reaction on {reactionsAdded} tokens." : $"Removed reaction on {reactionsRemoved} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReactionStop_Click(object sender, EventArgs e)
        {
            reactionTokenSource.Cancel();
        }

        private void btnTypingLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                typingTokens = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {typingTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTypingUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnTypingLoadProxies.Enabled = chkTypingUseProxies.Checked;
            comboTypingType.Enabled = chkTypingUseProxies.Checked;
            txtTypingTimeout.Enabled = chkTypingUseProxies.Checked;
        }

        private void btnTypingLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                typingProxies = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {typingProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnTypingStart_Click(object sender, EventArgs e)
        {
            if (typingTokens == null || !typingTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkTypingUseProxies.Checked)
            {
                if (typingProxies == null || !typingProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            string channel = txtTypingChannel.Text;

            amountTyping = 0;
            lblTyping.Text = "Typing: 0";
            btnTypingStart.Enabled = false;
            btnTypingStop.Enabled = true;

            ThreadPool.SetMinThreads(Convert.ToInt32(txtTypingThreads.Text), Convert.ToInt32(txtTypingThreads.Text));

            typingTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = typingTokenSource.Token;

            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = Convert.ToInt32(txtTypingThreads.Text),
                CancellationToken = cancellationToken
            };

            try
            {
                await Task.Run(() => Parallel.ForEach(typingTokens, parallelOptions, delegate (string token)
                {
                    StartTyping(token, channel);
                }), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // ignored
            }

            btnTypingStart.Enabled = true;
            btnTypingStop.Enabled = false;
            MessageBox.Show($"Typing on {amountTyping} tokens.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTypingStop_Click(object sender, EventArgs e)
        {
            typingTokenSource.Cancel();
        }

        private void btnScraperFetch_Click(object sender, EventArgs e)
        {
            scrapedProxies = null;

            using (HttpRequest httpRequest = new HttpRequest())
            {
                try
                {
                    scrapedProxies = httpRequest.Get($"https://api.proxyscrape.com?request=displayproxies&proxytype={comboScraperType.Text.ToLower()}&timeout={txtScraperTimeout.Text}&country={comboScraperCountry.Text}&anonymity={comboScraperAnonymity.Text.ToLower()}&ssl={comboScraperSSL.Text.ToLower()}").ToString();

                    lblScraperProxiesFetched.Text = $"Proxies fetched: {scrapedProxies.Count(c => c == '\n')}";

                    string LastUpdated = httpRequest.Get($"https://api.proxyscrape.com/?request=lastupdated&proxytype={comboScraperType.Text.ToLower()}").ToString().Replace("Around ", "");
                    lblScraperLastUpdated.Text = $"Last Updated: {LastUpdated}";
                }
                catch (Exception)
                {
                    // ignored
                }

                MessageBox.Show($"Scraped {scrapedProxies.Count(c => c == '\n')} proxies", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnScraperSaveProxies_Click(object sender, EventArgs e)
        {
            if (!scrapedProxies.Any()) return;

            var saveFileDialog = new SaveFileDialog
            {
                Title = "Save Proxies",
                Filter = "Text files (*.txt)|*.txt"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            var streamWriter = new StreamWriter(saveFileDialog.FileName);

            streamWriter.Write(scrapedProxies);

            streamWriter.Close();
            MessageBox.Show($"{scrapedProxies.Count(c => c == '\n')} proxies exported!", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnScraperCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (scrapedProxies == null || !scrapedProxies.Any()) return;

            Clipboard.SetText(scrapedProxies);
            MessageBox.Show($"Copied {scrapedProxies.Count(c => c == '\n')} proxies to clipboard.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDMLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                dmTokens = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {dmTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDMLoadMessages_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Messages");
                if (string.IsNullOrEmpty(fileName)) return;
                dmMessages = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {dmMessages.Count} messages.", "DiscordAIO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDMUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnDMLoadProxies.Enabled = chkDMUseProxies.Checked;
            comboDMType.Enabled = chkDMUseProxies.Checked;
            txtDMTimeout.Enabled = chkDMUseProxies.Checked;
        }

        private void btnDMLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                dmProxies = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {dmProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDMStart_Click(object sender, EventArgs e)
        {
            if (dmTokens == null || !dmTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dmMessages == null || !dmMessages.Any())
            {
                MessageBox.Show("Upload messages list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkDMUseProxies.Checked)
            {
                if (dmProxies == null || !dmProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            bool flag = txtDMUserId.Text.Length < 5 || txtDMUserId.Text == "";
            if (flag)
            {
                MessageBox.Show("Please provide a user ID.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userId = txtDMUserId.Text;
            dmSent = 0;
            lblDMSent.Text = "Messages Sent: 0";
            btnDMStart.Enabled = false;
            btnDMStop.Enabled = true;

            ThreadPool.SetMinThreads(Convert.ToInt32(txtDMThreads.Text), Convert.ToInt32(txtDMThreads.Text));

            dmTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = dmTokenSource.Token;

            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = Convert.ToInt32(txtDMThreads.Text),
                CancellationToken = cancellationToken
            };

            try
            {
                await Task.Run(() => Parallel.ForEach(dmTokens, parallelOptions, delegate (string token)
                {
                    SendDM(token, userId);
                }), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // ignored
            }

            btnDMStart.Enabled = true;
            btnDMStop.Enabled = false;
            MessageBox.Show($"Sent a DM to this user {dmSent} accounts.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SendDM(string token, string userId)
        {
            try
            {
                string proxy = null;

                if (chkDMUseProxies.Checked)
                    proxy = dmProxies[new Random().Next(dmProxies.Count)];

                string channelId = rDiscord.CreateDM(Client.Create(chkDMUseProxies.Checked,
                    chkDMUseProxies.Checked ? proxy : null, comboDMType.Text,
                    txtDMTimeout.Text, token), userId);

                int success = rDiscord.SendChannelMessage(Client.Create(chkDMUseProxies.Checked,
                    chkDMUseProxies.Checked ? proxy : null, comboDMType.Text, txtDMTimeout.Text, token), channelId, dmMessages[new Random().Next(dmMessages.Count)]);

                if (success != 1) return;
                Interlocked.Increment(ref dmSent);
                lblDMSent.Text = $"Messages Sent: {dmSent}";
            }
            catch
            {
                // ignored
            }
        }

        private void btnDMStop_Click(object sender, EventArgs e)
        {
            dmTokenSource.Cancel();
        }

        private void btnNicknameLoadProxies_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Proxies");
                if (string.IsNullOrEmpty(fileName)) return;
                nicknameProxies = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {nicknameProxies.Count} proxies.", "DiscordAIO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkNicknameUseProxies_CheckedChanged(object sender, EventArgs e)
        {
            btnNicknameLoadProxies.Enabled = chkNicknameUseProxies.Checked;
            comboNicknameType.Enabled = chkNicknameUseProxies.Checked;
            txtNicknameTimeout.Enabled = chkNicknameUseProxies.Checked;
        }

        private int nicknamesChanged;

        private async void btnNicknameStart_Click(object sender, EventArgs e)
        {
            if (nicknameTokens == null || !nicknameTokens.Any())
            {
                MessageBox.Show("Upload tokens list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (chkNicknameUseProxies.Checked)
            {
                if (nicknameProxies == null || !nicknameProxies.Any())
                {
                    MessageBox.Show("Upload proxies list.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtNicknameServer.Text == "")
            {
                MessageBox.Show("Please provide a server ID.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string server = txtNicknameServer.Text;
            string nickname = txtNickname.Text;
            nicknamesChanged = 0;
            lblChanged.Text = "Changed: 0";
            btnNicknameStart.Enabled = false;
            btnNicknameStop.Enabled = true;

            ThreadPool.SetMinThreads(Convert.ToInt32(txtNicknameThreads.Text), Convert.ToInt32(txtNicknameThreads.Text));

            nicknameTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = nicknameTokenSource.Token;

            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = Convert.ToInt32(txtNicknameThreads.Text),
                CancellationToken = cancellationToken
            };

            try
            {
                await Task.Run(() => Parallel.ForEach(nicknameTokens, parallelOptions, delegate (string token)
                {
                    ChangeNickname(token, server, nickname);
                }), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // ignored
            }

            btnNicknameStart.Enabled = true;
            btnNicknameStop.Enabled = false;
            MessageBox.Show($"Changed nickname on {nicknamesChanged} accounts.", "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeNickname(string token, string server, string nickname)
        {
            try
            {
                if (rDiscord.SetName(Client.Create(chkNicknameUseProxies.Checked,
                    chkNicknameUseProxies.Checked ? nicknameProxies[new Random().Next(nicknameProxies.Count)] : null,
                    comboNicknameType.Text, txtNicknameTimeout.Text, token), server, nickname))
                {
                    Interlocked.Increment(ref nicknamesChanged);
                    lblChanged.Text = $"Changed: {nicknamesChanged}";
                }
            }
            catch
            {
                // ignored
            }

            Thread.Sleep(Convert.ToInt32(txtNicknameDelay.Text));
        }

        private void btnNicknameStop_Click(object sender, EventArgs e)
        {
            nicknameTokenSource.Cancel();
        }

        private void btnNicknameLoadTokens_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Utilities.OpenFileDialog("Load Tokens");
                if (string.IsNullOrEmpty(fileName)) return;
                nicknameTokens = Utilities.LoadFile(fileName);
                MessageBox.Show($"Loaded {nicknameTokens.Count} tokens.", "DiscordAIO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DiscordAIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

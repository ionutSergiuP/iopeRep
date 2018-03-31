using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using file_transfer;
using System.Web;


public partial class Main : Form
{
    string fileName_taskb;
    string userpath_deskshort;
    string fileName_browsbook;
    string fileName_lotusp;
    string fileName_lotarch;
    string fileName_lotusmailarc;
    string fileName_tcmd;
    string zipPath;
    string createPath;
    string sametime_transcripts;
    string destination_local;
    

   
    //This will hold our listener. We will only need to create one instance of this.
    private Listener listener;
    //This will hold our transfer client.
    private TransferClient transferClient;
    //This will hold our output folder.
    private string outputFolder;
    //This will hold our overall progress timer.
    private Timer tmrOverallProg;
    //This is our variable to determine of the server is running or not to accept another connection if our client
    //Disconnects
    private bool serverRunning;

    public Main()
    {
        InitializeComponent();
        //Create the listener and register the event.
        listener = new Listener();
        listener.Accepted += listener_Accepted;

        //Create the timer and register the event.
        tmrOverallProg = new Timer();
        tmrOverallProg.Interval = 1000;
        tmrOverallProg.Tick += tmrOverallProg_Tick;
       

        btnConnect.Click += new EventHandler(btnConnect_Click);

        btnSendFiles.Click += new EventHandler(btnSendFiles_Click);


        //string zipPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Environment.MachineName);
        createPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Environment.MachineName);

        if (!Directory.Exists(createPath))
        {
            Directory.CreateDirectory(createPath);
        }

      
  
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        //Deregister all the events from the client if it is connected.
        deregisterEvents();
        base.OnFormClosing(e);
    }

    void tmrOverallProg_Tick(object sender, EventArgs e)
    {
        if (transferClient == null)
            return;
        //Get and display the overall progress.
        progressOverall.Value = transferClient.GetOverallProgress();
    }

    void listener_Accepted(object sender, SocketAcceptedEventArgs e)
    {
        if (InvokeRequired)
        {
            Invoke(new SocketAcceptedHandler(listener_Accepted), sender, e);
            return;
        }

        //Stop the listener
        listener.Stop();

        //Create the transfer client based on our newly connected socket.
        transferClient = new TransferClient(e.Accepted);
        //Set our output folder.
        transferClient.OutputFolder = outputFolder;
        //Register the events.
        registerEvents();
        //Run the client
        transferClient.Run();
        //Start the progress timer
        tmrOverallProg.Start();
        //And set the new connection state.
        setConnectionStatus(transferClient.EndPoint.Address.ToString());
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (transferClient == null)
        {
            //Create our new transfer client.
            //And attempt to connect
            transferClient = new TransferClient();
            transferClient.Connect(txtCntHost.Text.Trim(), int.Parse(txtCntPort.Text.Trim()), connectCallback);
            Enabled = false;
        }
        else
        {
            //This means we're trying to disconnect.
            transferClient.Close();
            transferClient = null;
        }
    }

    private void connectCallback(object sender, string error)
    {
        if (InvokeRequired)
        {
            Invoke(new ConnectCallback(connectCallback), sender, error);
            return;
        }
        //Set the form to enabled.
        Enabled = true;
        //If the error is not equal to null, something went wrong.
        if (error != null)
        {
            transferClient.Close();
            transferClient = null;
            MessageBox.Show(error, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        //Register the events
        registerEvents();
        //Set the output folder
        transferClient.OutputFolder = outputFolder;
        //Run the client
        transferClient.Run();
        //Set the connection status
        setConnectionStatus(transferClient.EndPoint.Address.ToString());
        //Start the progress timer.
        tmrOverallProg.Start();
        //Set our connect button text to "Disconnect"
        btnConnect.Text = "Disconnect";
    }

    private void registerEvents()
    {
        transferClient.Complete += transferClient_Complete;
        transferClient.Disconnected += transferClient_Disconnected;
        transferClient.ProgressChanged += transferClient_ProgressChanged;
        transferClient.Queued += transferClient_Queued;
        transferClient.Stopped += transferClient_Stopped;
    }

    void transferClient_Stopped(object sender, TransferQueue queue)
    {
        if (InvokeRequired)
        {
            Invoke(new TransferEventHandler(transferClient_Stopped), sender, queue);
            return;
        }
        //Remove the stopped transfer from view.
        //lstTransfers.Items[queue.ID.ToString()].Remove();
    }

    void transferClient_Queued(object sender, TransferQueue queue)
    {
        if (InvokeRequired)
        {
            Invoke(new TransferEventHandler(transferClient_Queued), sender, queue);
            return;
        }

        //Create the LVI for the new transfer.
        ListViewItem i = new ListViewItem();
        i.Text = queue.ID.ToString();
        i.SubItems.Add(queue.Filename);
        //If the type equals download, it will use the string of "Download", if not, it'll use "Upload"
        i.SubItems.Add(queue.Type == QueueType.Download ? "Download" : "Upload");
        i.SubItems.Add("0%");
        i.Tag = queue; //Set the tag to queue so we can grab is easily.
        i.Name = queue.ID.ToString(); //Set the name of the item to the ID of our transfer for easy access.
        //lstTransfers.Items.Add(i); //Add the item
        i.EnsureVisible();

        //If the type is download, let the uploader know we're ready.
        if (queue.Type == QueueType.Download)
        {
            transferClient.StartTransfer(queue);
        }
    }

    void transferClient_ProgressChanged(object sender, TransferQueue queue)
    {

    }

    void transferClient_Disconnected(object sender, EventArgs e)
    {


    }

    void transferClient_Complete(object sender, TransferQueue queue)
    {
        //This just plays a little sound to let us know a transfer completed.
        System.Media.SystemSounds.Asterisk.Play();
    }

    private void deregisterEvents()
    {
        if (transferClient == null)
            return;
        transferClient.Complete -= transferClient_Complete;
        transferClient.Disconnected -= transferClient_Disconnected;
        transferClient.ProgressChanged -= transferClient_ProgressChanged;
        transferClient.Queued -= transferClient_Queued;
        transferClient.Stopped -= transferClient_Stopped;
    }

    private void setConnectionStatus(string connectedTo)
    {
        lblConnected.Text = "Connection: " + connectedTo;
        lblUserName.Text = "User: " + Environment.UserName;
    }

    private void btnStartServer_Click(object sender, EventArgs e)
    {
        //We disabled the button, but lets just do a quick check
        if (serverRunning)
            return;
        serverRunning = true;
        try
        {
            //Try to listen on the desired port
            // listener.Start(int.Parse(txtServerPort.Text.Trim()));
            //Set the connection status to waiting
            setConnectionStatus("Waiting...");
            //Enable/Disable the server buttons.
            //btnStartServer.Enabled = false;
            //btnStopServer.Enabled = true;
        }
        catch
        {
            MessageBox.Show("Unable to listen on port " + txtCntPort.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

    private void btnStopServer_Click(object sender, EventArgs e)
    {
        if (!serverRunning)
            return;
        //Close the client if its active.
        if (transferClient != null)
        {
            transferClient.Close();
            //INSERT
            transferClient = null;
            //
        }
        //Stop the listener
        listener.Stop();
        //Stop the timer
        tmrOverallProg.Stop();
        //Reset the connection statis
        setConnectionStatus("-");
        //Set our variables and enable/disable the buttons.
        serverRunning = false;
        //btnStartServer.Enabled = true;
        //btnStopServer.Enabled = false;
    }

    private void btnClearComplete_Click(object sender, EventArgs e)
    {

    }

    private void btnOpenDir_Click(object sender, EventArgs e)
    {
        //Get a user defined save directory
        using (FolderBrowserDialog fb = new FolderBrowserDialog())
        {
            if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputFolder = fb.SelectedPath;

                if (transferClient != null)
                {
                    transferClient.OutputFolder = outputFolder;
                }

                //txtSaveDir.Text = outputFolder;
            }
        }
    }
   
    private void btnSendFiles_Click(object sender, EventArgs e)
    {
        //TODO Ionut: if press one time send files is called 2 times this method
        var textboxes = new TextBox[] 
        {
            textBox1, textBox2, textBox3, textBox5, textBox7
        };
       
        // Check if any of the texboxes is empty
        if(textboxes.Any(tb => tb.Text == String.Empty))
        {
            btnSendFiles.Visible= false;
            MessageBox.Show("Please fill all the fields!");

        }

       

      
        if (transferClient == null)
            return;

        zipPath = @"d:\" + Environment.UserName + " - " + Environment.MachineName + ".zip";
        transferClient.QueueTransfer(zipPath);
        
    }




    private void brwDesktop_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        userpath_deskshort = @"C:\Users\Public\Desktop";
        destination_local = @"d:\Copy\Desktop";

        if(!Directory.Exists(destination_local))
        {
            Directory.CreateDirectory(destination_local);
        }

        folderBrowserDialog.SelectedPath = userpath_deskshort;

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            userpath_deskshort = folderBrowserDialog.SelectedPath;

            textBox1.Text = userpath_deskshort;
        }


        foreach (string dirPath in Directory.GetDirectories(userpath_deskshort, "*", SearchOption.AllDirectories))
            Directory.CreateDirectory(dirPath.Replace(userpath_deskshort, destination_local));

        //Copy all the files & Replaces any files with the same name
        foreach (string newPath in Directory.GetFiles(userpath_deskshort, "*.*",SearchOption.AllDirectories))
            File.Copy(newPath, newPath.Replace(userpath_deskshort, destination_local), true);
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }

    private void brwTaskbar_Click(object sender, EventArgs e)
    {

        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        fileName_taskb = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar");
        destination_local = @"d:\Copy\Taskbar";
        Directory.CreateDirectory(destination_local);
        folderBrowserDialog.SelectedPath = fileName_taskb;

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            fileName_taskb = folderBrowserDialog.SelectedPath;

            textBox2.Text = fileName_taskb;
        }
        foreach (string dirPath in Directory.GetDirectories(fileName_taskb, "*", SearchOption.AllDirectories))
            Directory.CreateDirectory(dirPath.Replace(fileName_taskb, destination_local));

        //Copy all the files & Replaces any files with the same name
        foreach (string newPath in Directory.GetFiles(fileName_taskb, "*.*",SearchOption.AllDirectories))
            File.Copy(newPath, newPath.Replace(fileName_taskb, destination_local), true);
    }

        


    

    private void brwBook_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        fileName_browsbook = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Favorites\Links\");
        destination_local = @"d:\Copy\Bookmarks";
        Directory.CreateDirectory(destination_local);

        folderBrowserDialog.SelectedPath = fileName_browsbook;


        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {

            fileName_browsbook = folderBrowserDialog.SelectedPath;

            textBox3.Text = fileName_browsbook;
        }

        foreach (string dirPath in Directory.GetDirectories(fileName_browsbook, "*", SearchOption.AllDirectories))
            Directory.CreateDirectory(dirPath.Replace(fileName_browsbook, destination_local));

        //Copy all the files & Replaces any files with the same name
        foreach (string newPath in Directory.GetFiles(fileName_browsbook, "*.*", SearchOption.AllDirectories))
            File.Copy(newPath, newPath.Replace(fileName_browsbook, destination_local), true);


    }

    private void brwTotalC_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();


        fileName_tcmd = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        destination_local = @"d:\Copy\Total Commander\wincmd.ini";
        Directory.CreateDirectory(@"d:\Copy\Total Commander");
        File.Create("wincmd.ini");

        openFileDialog1.InitialDirectory = fileName_tcmd;
        openFileDialog1.Title = "Browse Text Files";

        openFileDialog1.CheckFileExists = true;
        openFileDialog1.CheckPathExists = true;

        openFileDialog1.DefaultExt = "ini";
        openFileDialog1.Filter = "Total commander (win*.ini)|win*.ini";
        openFileDialog1.FilterIndex = 2;
        openFileDialog1.RestoreDirectory = true;

        openFileDialog1.ReadOnlyChecked = true;
        openFileDialog1.ShowReadOnly = true;

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            textBox7.Text = openFileDialog1.FileName;
        }

        System.IO.File.Copy(textBox7.Text , destination_local, true);


    }

    private void brwLotusp_Click(object sender, EventArgs e)
    {
        
        OpenFileDialog openFileDialog1 = new OpenFileDialog();


        fileName_tcmd = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Lotus\Notes\Data");
        destination_local = @"d:\Copy\Lotus bookmark\bookmark.nsf";
        Directory.CreateDirectory(@"d:\Copy\Lotus bookmark");
        File.Create("bookmark.nsf");

        openFileDialog1.InitialDirectory = fileName_tcmd;
        openFileDialog1.Title = "Browse Text Files";

        openFileDialog1.CheckFileExists = true;
        openFileDialog1.CheckPathExists = true;

        openFileDialog1.DefaultExt = "nsf";
        openFileDialog1.Filter = "Bookmark (book*.nsf)|book*.nsf";
        openFileDialog1.FilterIndex = 2;
        openFileDialog1.RestoreDirectory = true;

        openFileDialog1.ReadOnlyChecked = true;
        openFileDialog1.ShowReadOnly = true;

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            textBox4.Text = openFileDialog1.FileName;
        }

        System.IO.File.Copy(textBox4.Text, destination_local, true);



    }

    private void brwLotusArc_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        fileName_lotusmailarc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Lotus\Notes\Data\archive");
        destination_local = @"d:\Copy\Lotus Archive\archive";
        Directory.CreateDirectory(destination_local);

        folderBrowserDialog.SelectedPath = fileName_lotusmailarc;


        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {

            fileName_browsbook = folderBrowserDialog.SelectedPath;

            textBox5.Text = fileName_browsbook;
        }

        foreach (string dirPath in Directory.GetDirectories(textBox5.Text, "*", SearchOption.AllDirectories))
            Directory.CreateDirectory(dirPath.Replace(fileName_browsbook, destination_local));

        //Copy all the files & Replaces any files with the same name
        foreach (string newPath in Directory.GetFiles(textBox5.Text, "*.*", SearchOption.AllDirectories))
            File.Copy(newPath, newPath.Replace(textBox5.Text, destination_local), true);
       
    }

    private void Main_Load(object sender, EventArgs e)
    {
        //This label will identify the client
       lblUserName.Text = "User: "+ Environment.UserName;
        //creates a folder on d:\ drive with the user's profile and station name
       //Directory.CreateDirectory(@"d:\" + Environment.UserName + " - "+ Environment.MachineName);
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialog == DialogResult.Yes)
        {
            return;
        }

        else if (dialog == DialogResult.No)
        {
            e.Cancel = true;
        }   
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void toolStripStatusLabel1_Click(object sender, EventArgs e)
    {
        lblUserName.Text = "User: " + Environment.UserName;
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void btnsametime_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        sametime_transcripts = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),@"Documents\SametimeTranscripts");
        destination_local = @"d:\Copy\SametimeTranscripts";
        Directory.CreateDirectory(destination_local);
        folderBrowserDialog.SelectedPath = sametime_transcripts;

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            sametime_transcripts = folderBrowserDialog.SelectedPath;

            textBox6.Text = sametime_transcripts;
        }

        foreach (string dirPath in Directory.GetDirectories(sametime_transcripts, "*", SearchOption.AllDirectories))
            Directory.CreateDirectory(dirPath.Replace(sametime_transcripts, destination_local));

        //Copy all the files & Replaces any files with the same name
        foreach (string newPath in Directory.GetFiles(sametime_transcripts, "*.*", SearchOption.AllDirectories))
            File.Copy(newPath, newPath.Replace(sametime_transcripts, destination_local), true);


        //Creates the zip file that will be sent to the server. If the zip file exists, it will be deleted first
        string startpath = @"d:\Copy";
        zipPath = @"d:\" + Environment.UserName + " - " + Environment.MachineName + ".zip";

         if (File.Exists(zipPath))
         {
             File.Delete(zipPath);
         }
         

        ZipFile.CreateFromDirectory(startpath, zipPath, CompressionLevel.Fastest, true);

     
       
    }

    private void txtCntHost_Click(object sender, EventArgs e)
    {

    }
}

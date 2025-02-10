namespace AutoClicker.WinForm;

public partial class MainForm : Form
{

    private AutoClicker _autoClicker { get; set; }
    private HotkeyManager _hotkeys { get; set; }
    public int NumberCountTest { get; set; }

    public MainForm()
    {
        _hotkeys = new HotkeyManager(this.Handle);
        InitializeComponent();
        _autoClicker = new AutoClicker();

        _hotkeys.OnStartClicking += () =>
        { int reversedInterval = ReverseTrackBarValue(trackBarClickSpeed.Value); _autoClicker.StartClicking(reversedInterval); };
        _hotkeys.OnStopClicking += _autoClicker.StopClicking;
        trackBarClickSpeed.ValueChanged += TrackBarInterval_ValueChanged;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _hotkeys.RegisterHotkeys();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _hotkeys.UnregisterHotkeys();
        base.OnFormClosing(e);
    }

    protected override void WndProc(ref Message m)
    {
        if (_hotkeys != null) // Ensure _hotkeys is initialized before using it
        {
            _hotkeys.ProcessHotkeyMessage(m);
        }
        base.WndProc(ref m);
    }



    private void buttonClickTester_Click(object sender, EventArgs e)
    {
        textBoxClickTester.Text = $"{NumberCountTest++}";
    }

    private void buttonAutoClickerOff_Click(object sender, EventArgs e)
    {
        _autoClicker.StopClicking();
    }
    private void buttonAutoClickerOn_Click(object sender, EventArgs e)
    {
        int reversedInterval = ReverseTrackBarValue(trackBarClickSpeed.Value);
        _autoClicker.StartClicking(reversedInterval);
    }

    private void TrackBarInterval_ValueChanged(object sender, EventArgs e)
    {
        int reversedInterval = ReverseTrackBarValue(trackBarClickSpeed.Value);
        _autoClicker.ClickInterval = reversedInterval;
    }
    private int ReverseTrackBarValue(int value)
    {
        return trackBarClickSpeed.Maximum - value + trackBarClickSpeed.Minimum;
    }


}

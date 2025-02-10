using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class HotkeyManager
{
    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    private const int HOTKEY_ID_START = 1;
    private const int HOTKEY_ID_STOP = 2;
    private IntPtr _handle;

    public event Action? OnStartClicking;
    public event Action? OnStopClicking;

    public HotkeyManager(IntPtr handle)
    {
        _handle = handle;
    }

    public void RegisterHotkeys()
    {
        RegisterHotKey(_handle, HOTKEY_ID_START, 0, Keys.F1);  // Start clicking with F1
        RegisterHotKey(_handle, HOTKEY_ID_STOP, 0, Keys.F2);   // Stop clicking with F2
    }

    public void UnregisterHotkeys()
    {
        UnregisterHotKey(_handle, HOTKEY_ID_START);
        UnregisterHotKey(_handle, HOTKEY_ID_STOP);
    }

    public void ProcessHotkeyMessage(Message m)
    {
        if (m.Msg == 0x0312) // WM_HOTKEY message
        {
            int id = m.WParam.ToInt32();
            if (id == HOTKEY_ID_START)
                OnStartClicking?.Invoke();
            else if (id == HOTKEY_ID_STOP)
                OnStopClicking?.Invoke();
        }
    }
}

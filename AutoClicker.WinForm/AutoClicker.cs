using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker.WinForm;

public class AutoClicker
{
    public bool _isClicking { get; private set; }
    private int _clickInterval;
    private CancellationTokenSource _cts;

    public int ClickInterval
    {
        get => _clickInterval;
        set => _clickInterval = value;  // Allow updating interval dynamically
    }

    public void StartClicking(int interval)
    {
        if (_isClicking) return;
        _isClicking = true;
        _clickInterval = interval;
        _cts = new CancellationTokenSource();

        Task.Run(() => ClickLoop(_cts.Token));
    }

    public void StopClicking()
    {
        _isClicking = false;
        _cts?.Cancel();
    }

    private async Task ClickLoop(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            MouseHelper.PerformClick();
            await Task.Delay(_clickInterval, token);
        }
    }
}



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinibuildWin
{
    public class Daemon : ApplicationContext
    {
        private readonly NotifyIcon trayIcon;

        public Daemon()
        {
            trayIcon = new NotifyIcon()
            {
                Icon = Resource1.icon,
                ContextMenuStrip = new ContextMenuStrip()
                {
                    Items =
                    {
                        new ToolStripMenuItem("OPEN", null, new EventHandler(Open), "OPEN"),
                        new ToolStripMenuItem("SETTINGS", null, new EventHandler(Settings), "SETTINGS"),
                        new ToolStripMenuItem("EXIT", null, new EventHandler(Exit), "EXIT")
                    }
                },
                Visible = true
            };
        }

        private void Open(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Settings(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Exit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

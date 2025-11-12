using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace Frontend
{
    public partial class HouseWatcher : Form
    {
        private int _dragx;
        private int _dragy;
        private bool _dragging = false;
        public HouseWatcher()
        {
            InitializeComponent();
        }

        public void Update(House model)
        {
            lblCash.Text = model.Cash.ToString("C2");
            this.lblDisplayName.Text = model.DisplayName;
            lblUPS.Text = model.UPS.Load.ToString("F2")+"[kWh]";
            this.lblCTime.Text = model.Environment == null ? "???" : model.Environment.DateTime.ToString("F");
            this.Refresh();
        }

        private void HouseWatcher_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragx = e.X;
            _dragy = e.Y;
        }

        private void HouseWatcher_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                this.Location = new Point(Cursor.Position.X - _dragx, Cursor.Position.Y - _dragy);
            }
        }

        private void HouseWatcher_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}

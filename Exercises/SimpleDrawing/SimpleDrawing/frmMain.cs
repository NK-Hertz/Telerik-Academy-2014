using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleDrawing
{
    public partial class frmMain : Form
    {
        #region Constructors 

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Members

        List<IDrawable> _items = new List<IDrawable>();
        int _selectedIndex = -1;
        int _X, _Y;
        IConnectable start = null;

        #endregion

        #region Event Handlers

        //toolStripMenu Toggle Buttons Behaviour implementation
        private void tsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem is ToolStripButton)
            {
                foreach (ToolStripItem button in this.tsMenu.Items)
                    if (button is ToolStripButton)
                        ((ToolStripButton)button).CheckState = CheckState.Unchecked;

                ((ToolStripButton)e.ClickedItem).CheckState = CheckState.Checked;
            }
        }

        //_items drawing risuvaneto na syotvetnia obekt, vsochki obekti koito ima
        private void pbDashboard_Paint(object sender, PaintEventArgs e)
        {
            foreach (IDrawable item in this._items)
                item.Draw(e.Graphics);
        }

        //_items manupulation
        private void pbDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return; //nishto ne stava

            if (btnStock.CheckState == CheckState.Checked)//selecknat li e stock
            {
                this._items.Add(new Stock(new Rectangle(e.X, e.Y, 100, 50)));//dobavniame v items nov obekt stock, s dyljina 100 s visochina 50, kydeto sme natisnali
                this.pbDashboard.Refresh();
            }
            else if (btnCoefficient.CheckState == CheckState.Checked)
            {
                this._items.Add(new Coefficient(new Rectangle(e.X, e.Y, 100, 50))); //analogichno za elipsata
                this.pbDashboard.Refresh();
            }
  

        }
        private void pbDashboard_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void pbDashboard_MouseUp(object sender, MouseEventArgs e)
        {

        }

        //Fast keys
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {

        }

        #endregion
    }
}

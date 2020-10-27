using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPerformance_02
{
        public partial class CustomerView : Form
        {
            public CustomerView()
            {
                InitializeComponent();
            }

            private void CustomerView_Load(object sender, EventArgs e)
            {
                try
                {
                    lblDisplay.Text = CashierClass.CashierQueue.Peek();
                }
                catch (System.InvalidOperationException ex)
                {
                    MessageBox.Show("Theres nothing in the Queue right now.", "Message");
                    this.Close();
                }
            }


            private void lblDisplay_Click(object sender, EventArgs e)
            {

            }
        }
    }

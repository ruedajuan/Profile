using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_Ana_Sistema
{
    public partial class CustomMessageBox : Form
    {
       
        private Label messageLabel;
        private Button okButton;

        public CustomMessageBox(string message)
        {
            this.Text = "Aviso";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.PapayaWhip;

            messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.ForeColor = Color.DarkSlateGray;
            messageLabel.Font = new Font("Arial", 10, FontStyle.Regular);
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(20, 20);
            messageLabel.Padding = new Padding(10);
            messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new Point(150, 150);
            okButton.Click += (sender, e) => this.Close();

            this.Controls.Add(messageLabel);
            this.Controls.Add(okButton);
        }

        public static void Show(string message)
        {
            CustomMessageBox box = new CustomMessageBox(message);
            box.ShowDialog();
        }
    }
}


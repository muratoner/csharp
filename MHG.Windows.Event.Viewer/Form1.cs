using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MHG.Windows.Event.Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbOlayTuru.SelectedIndex = 0;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOlayAdi.Text) && !string.IsNullOrEmpty(txtOlayKaynakAdi.Text))
            {
                //Eğer muratoner.net adında bir kaynak yok ise oluşturulacak.
                if (!EventLog.SourceExists(txtOlayKaynakAdi.Text))
                    EventLog.CreateEventSource(txtOlayKaynakAdi.Text, txtOlayKaynakAdi.Text);

                EventLogEntryType logType = EventLogEntryType.Information;
                switch (cbOlayTuru.SelectedIndex)
                {
                    case 1:
                        logType = EventLogEntryType.Warning;
                        break;
                    case 2:
                        logType = EventLogEntryType.Error;
                        break;
                    default:
                        break;
                }

                //Logu yazıyoruz.
                EventLog.WriteEntry(txtOlayKaynakAdi.Text, txtOlayAdi.Text, logType);
                MessageBox.Show("Log yazıldı...");
            }
            else
                MessageBox.Show("Log adı ve kaynağı boş geçemezsiniz.");
        }
    }
}
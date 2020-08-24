using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace AltaronLyzer
{
    public partial class ALTARON_LYZER : Form
    {
        AL_CLIENT_INJECT m_client;
        AL_MEMORY_READER m_memoryReader;

        public int hp;
        public int mp;
        public int hp_max;
        public int mp_max;
        int lastManaTick;
        int lastHpTick;
        bool hpCheckerBool;
        bool manaRegBool;
        bool hpWarningBool;
        private bool startReading = false;
        bool pop = false;
        float hpPercent;

        public ALTARON_LYZER()
        {
            InitializeComponent();
            AL_DEBUG.SetLogSpace(this.richTextBox1);
            m_memoryReader = new AL_MEMORY_READER();
            checkBoxOtrzymanieObrazen.Enabled = false;
            checkBoxPelnaMana.Enabled = false;
            checkBoxHpWarning.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Process p in Process.GetProcessesByName("Altaron"))
            {
                listBox1.Items.Add(p.MainWindowTitle);
            }
            if (this.listBox1.Items.Count > 0)
                this.listBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 && listBox1.SelectedIndex >= Process.GetProcessesByName("Altaron").Length)
                return;

            m_client = new AL_CLIENT_INJECT(Process.GetProcessesByName("Altaron")[listBox1.SelectedIndex]);
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += new EventHandler(onBotRefresh);
            timer1.Tick += new EventHandler(checkBoxPelnaMana_CheckedChanged);
            startReading = true;

            timer2.Enabled = true;
            timer2.Start();
            lastManaTick = mp;
            timer2.Tick += new EventHandler(ManaChecker);
            checkBoxOtrzymanieObrazen.Enabled = true;
            checkBoxPelnaMana.Enabled = true;
            checkBoxHpWarning.Enabled = true;
        }

        private void onBotRefresh(object sender, EventArgs e)
        {
            m_client = new AL_CLIENT_INJECT(Process.GetProcessesByName("Altaron")[listBox1.SelectedIndex]);
            hp = m_memoryReader.GetHealth(m_client.cHandle, (Int32)m_client.baseAddress);
            mp = m_memoryReader.GetMana(m_client.cHandle, (Int32)m_client.baseAddress);
            hp_max = m_memoryReader.GetMaxHealth(m_client.cHandle, (Int32)m_client.baseAddress);
            mp_max = m_memoryReader.GetMaxMana(m_client.cHandle, (Int32)m_client.baseAddress);

            label_HP.Text = "HP: " + hp.ToString() + "/" + hp_max.ToString();
            label_MP.Text = "mP: " + mp.ToString() + "/" + mp_max.ToString();

            if (hpCheckerBool && lastHpTick > hp)
            {
                int dmg = lastHpTick - hp;
                checkBoxOtrzymanieObrazen.Checked = false;
                hpCheckerBool = false;
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "ATAK";
                popup.ContentText = "Zostałeś zaatakowany!!!!";
                AL_DEBUG.Log("Otrzymano obrażenia: " +  dmg );
                popup.Popup();
                lastHpTick = hp;


            }
            hpPercent = (float)Convert.ToDouble(textBoxHpWarning.Text);
            float percentHp = ((float)hp / (float)hp_max) * 100f;
            if (hpWarningBool && percentHp <= hpPercent)
            {
                checkBoxHpWarning.Checked = false;
                hpWarningBool = false;
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Low Hp";
                popup.ContentText = "Masz mało HP!!!!";
                AL_DEBUG.Log("Twoje HP spadło poniżej: " + hp + " : " + percentHp);
                popup.Popup();
            }
            /*AL_DEBUG.Log(hp.ToString());
            AL_DEBUG.Log(mp.ToString());
            AL_DEBUG.Log(hp_max.ToString());
            AL_DEBUG.Log(mp_max.ToString());*/
            
        }

        private void checkBoxPelnaMana_CheckedChanged(object sender, EventArgs e)
        {
            if (startReading && checkBoxPelnaMana.Checked)
            {
                
               if (mp == mp_max && pop == false)
                {
                    AL_DEBUG.Log("Pelna Mana");
                    //label1.Text = "Pełna mana";
                    PopupNotifier popup = new PopupNotifier();
                    popup.TitleText = "MANA!!";
                    popup.ContentText = "Masz full many";
                    popup.Popup();
                    pop = true;
                }
                else if(mp != mp_max && pop)
                {
                    pop = false;
                }


            }
        }

        public void ManaChecker(object sender, EventArgs e)
        {

            if (mp > lastManaTick && checkBoxPelnaMana.Checked && mp < mp_max)
            {
                label1.Text = "Regeneracja";
                lastManaTick = mp;
                manaRegBool = true;
            }
            else if (mp <= lastManaTick && checkBoxPelnaMana.Checked && mp < mp_max && manaRegBool)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Regeneracja";
                popup.ContentText = "Brak Regeneracji many";
                popup.Popup();
                label1.Text = "Brak Regeneracji";
                manaRegBool = false;
            }
        }

        private void checkBoxOtrzymanieObrazen_CheckedChanged(object sender, EventArgs e)
        {
            lastHpTick = hp;
            label1.Text = lastHpTick.ToString();
            hpCheckerBool = true;
        }

        private void checkBoxHpWarning_CheckedChanged(object sender, EventArgs e)
        {
            hpWarningBool = true;
        }

        private void textBoxHpWarning_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


    }
}

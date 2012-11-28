using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DesktopLiveStreamer
{
    public partial class FrmAdd : Form
    {
        private ListStreams listStreams;
        private int modifyIndex;

        public FrmAdd(ListStreams list)
        {
            InitializeComponent();

            btnAdd.Enabled = false;

            listStreams = list;
        }

        public FrmAdd(ListStreams list, int index, Boolean clone) : this(list)
        {
            txtCaption.Text = listStreams[index].Caption;
            txtURL.Text = listStreams[index].StreamUrl;
            txtQuality.Text = listStreams[index].Quality;

            if (!clone)
            {
                modifyIndex = index;

                btnAdd.Visible = false;
                btnModify.Visible = true;
            }
        }

        public FrmAdd(ListStreams list, String caption, String url, String quality)
            : this(list)
        {
            txtCaption.Text = caption;
            txtURL.Text = url;
            txtQuality.Text = quality;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                listStreams.add(new Stream(txtCaption.Text, txtURL.Text, txtQuality.Text));
                listStreams.sort();

                XMLPersist.saveStreamListConfig(listStreams);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + " " + ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                listStreams[modifyIndex].Caption = txtCaption.Text;
                listStreams[modifyIndex].StreamUrl = txtURL.Text;
                listStreams[modifyIndex].Quality = txtQuality.Text;
                listStreams.sort();

                XMLPersist.saveStreamListConfig(listStreams);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType() + " " + ex.Message, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void txtQuality_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void FrmAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EWSEditor.Common;
using EWSEditor.Common.Extensions;
using EWSEditor.Exchange;
using EWSEditor.Forms.Controls;
using EWSEditor.Resources;
using EWSEditor.Settings;
using Microsoft.Exchange.WebServices.Data;

namespace EWSEditor.Forms
{
    public partial class ManageServicesDialog : Form
    {
        static readonly int MaxStoredServices = 5;

        public StoredServices StoredServices { get; set; }

        public ManageServicesDialog()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateList();

            base.OnLoad(e);
        }

        private void UpdateList()
        {
            lsbStoredServices.Items.Clear();

            if (StoredServices.Any())
            {
                lsbStoredServices.Items.AddRange(
                    StoredServices.Select(s => s.Name).ToArray());
            }

            UpdateBtnAddService();
            UpdateBtnEditService();
            UpdateBtnRemoveService();
            UpdateLblServiceCount();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            var service = new ExchangeService();
            var app_settinsg = new EwsEditorAppSettings();

            using (var dlg = new ServiceDialog())
            {
                dlg.CurrentService = new ExchangeService();
                dlg.CurrentAppSettings = new EwsEditorAppSettings();
                dlg.CheckOnOkay = false;

                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                StoredServices.Add(new StoredService
                {
                    Name = txtServiceName.Text,
                    Service = dlg.CurrentService,
                    AppSettings = dlg.CurrentAppSettings
                });

                UpdateList();
            }
        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {
            UpdateBtnAddService();
        }

        private void lsbStoredServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBtnEditService();
            UpdateBtnRemoveService();
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            StoredServices.RemoveAt(lsbStoredServices.SelectedIndex);
            UpdateList();
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            var stored_service = StoredServices[lsbStoredServices.SelectedIndex];

            using (var dlg = new ServiceDialog())
            {
                dlg.CurrentService = stored_service.Service;
                dlg.CurrentAppSettings = stored_service.AppSettings;
                dlg.CheckOnOkay = false;

                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                stored_service.Service = dlg.CurrentService;
                stored_service.AppSettings = dlg.CurrentAppSettings;
            }
        }

        private void UpdateBtnAddService()
        {
            btnAddService.Enabled =
                (!string.IsNullOrWhiteSpace(txtServiceName.Text)) &&
                (StoredServices.Count < MaxStoredServices);
        }

        private void UpdateBtnEditService()
        {
            btnEditService.Enabled = lsbStoredServices.SelectedIndex != -1;
        }

        private void UpdateBtnRemoveService()
        {
            btnRemoveService.Enabled = lsbStoredServices.SelectedIndex != -1;
        }

        private void UpdateLblServiceCount()
        {
            lblServiceCount.Text = $"{lsbStoredServices.Items.Count}/{MaxStoredServices}";
        }
    }
}

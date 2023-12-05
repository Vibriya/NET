﻿using System;
using System.Windows.Forms;
using LB_1;
using LB_2.Model;

namespace LB_2
{
    public partial class MainView : Form
    {
        private readonly BindingSource _bs;
        public MainView()
        {
            InitializeComponent();
            _bs = new BindingSource();
            
            _bs.DataSource = Storage.OperatorAccounts;
            
            InitGridView();
            dgOperatorGrid.DataSource = _bs;

            btDelOperator.Enabled = _bs.Count > 0;
        }

        private void btAddOperator_Click(object sender, EventArgs e)
        {
            var newOperatorView = new NewOperatorView();
            newOperatorView.ShowDialog();
            
            if (newOperatorView.DialogResult != DialogResult.OK) return;
            Storage.OperatorAccounts.Add(newOperatorView.Operator);
            _bs.ResetBindings(true);
            btDelOperator.Enabled = _bs.Count > 0;
        }

        private void btDelOperator_Click(object sender, EventArgs e)
        {
            if(_bs.Current == null) return;
            Storage.OperatorAccounts.Remove((MobileOperatorAccount)_bs.Current);
            _bs.ResetBindings(true);
            btDelOperator.Enabled = _bs.Count > 0;
        }

        private void btStartCall_Click(object sender, EventArgs e)
        {
            if(_bs.Current == null) return;
            var startCallDialog = new StartCallView((MobileOperatorAccount)_bs.Current);
            startCallDialog.ShowDialog();
            _bs.ResetBindings(true);
        }

        private void btChangeTariff_Click(object sender, EventArgs e)
        {
            if(_bs.Current == null) return;
            var changeTariffView = new ChangeTariffView((MobileOperatorAccount)_bs.Current);
            if (changeTariffView.ShowDialog() == DialogResult.OK)
                _bs.ResetBindings(true);
        }

        private void btAddMoney_Click(object sender, EventArgs e)
        {
            if(_bs.Current == null) return;
            var addMoneyView = new AddMoneyView((MobileOperatorAccount)_bs.Current);
            if (addMoneyView.ShowDialog() == DialogResult.OK)
                _bs.ResetBindings(true);
        }

        private void btUseVpn_Click(object sender, EventArgs e)
        {
            if(_bs.Current == null) return;
            var useVpnView = new UseVpnView((MobileOperatorAccount)_bs.Current);
            if (useVpnView.ShowDialog() == DialogResult.OK)
                _bs.ResetBindings(true);
        }

        private void btShowCallHistory_Click(object sender, EventArgs e)
        {
            if(_bs.Current == null) return;
            new CallHistoryView((MobileOperatorAccount)_bs.Current).ShowDialog();
        }

        private void dgOperatorGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var column = dgOperatorGrid.Columns[e.ColumnIndex];
            if (!column.DataPropertyName.Contains(".")) return;
            var data = dgOperatorGrid.Rows[e.RowIndex].DataBoundItem;
            var properties = column.DataPropertyName.Split('.');
            for (var i = 0; i < properties.Length && data != null; i++)
                data = data.GetType().GetProperty(properties[i])?.GetValue(data);
            dgOperatorGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
        }

        private void InitGridView()
        {
            dgOperatorGrid.AutoGenerateColumns = false;
            
            dgOperatorGrid.Columns.Add("OperatorName", "Operator Name");
            dgOperatorGrid.Columns.Add("PhoneNumber", "Phone Number");
            dgOperatorGrid.Columns.Add("CurrentAccount", "Current Account");
            dgOperatorGrid.Columns.Add("Paid", "Paid");
            dgOperatorGrid.Columns.Add("InRoaming", "In Roaming");

            dgOperatorGrid.Columns.Add("TariffName", "Tariff Name");
            dgOperatorGrid.Columns.Add("TariffPrice", "Tariff Price");
            dgOperatorGrid.Columns.Add("TariffPriceMinute", "Tariff Price/Minute");
            dgOperatorGrid.Columns.Add("TariffPriceMinuteRoaming", "Tariff Price/Minute (Roaming)");
            dgOperatorGrid.Columns.Add("TariffInternet", "Tariff Internet");
            dgOperatorGrid.Columns.Add("TariffHideNumber", "Tariff HideNumber");
            dgOperatorGrid.Columns.Add("TariffFreeVpn", "Tariff FreeVpn");

            dgOperatorGrid.Columns["OperatorName"].DataPropertyName = "OperatorName";
            dgOperatorGrid.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
            dgOperatorGrid.Columns["CurrentAccount"].DataPropertyName = "CurrentAccount";
            dgOperatorGrid.Columns["Paid"].DataPropertyName = "Paid";
            dgOperatorGrid.Columns["InRoaming"].DataPropertyName = "InRoaming";

            dgOperatorGrid.Columns["TariffName"].DataPropertyName = "Tariff.Name";
            dgOperatorGrid.Columns["TariffPrice"].DataPropertyName = "Tariff.Price";
            dgOperatorGrid.Columns["TariffPriceMinute"].DataPropertyName = "Tariff.PriceMinute";
            dgOperatorGrid.Columns["TariffPriceMinuteRoaming"].DataPropertyName = "Tariff.PriceMinuteRoaming";
            dgOperatorGrid.Columns["TariffInternet"].DataPropertyName = "Tariff.Internet";
            dgOperatorGrid.Columns["TariffHideNumber"].DataPropertyName = "Tariff.CanHideNumber";
            dgOperatorGrid.Columns["TariffFreeVpn"].DataPropertyName = "Tariff.HaveFreeVpn";
        }
    }
}
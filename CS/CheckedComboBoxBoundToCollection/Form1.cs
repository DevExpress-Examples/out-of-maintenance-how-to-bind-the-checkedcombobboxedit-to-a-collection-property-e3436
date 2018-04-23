using System;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace CheckedComboBoxBoundToCollection {
    public partial class Form1 :XtraForm {
        int cnt;

        public Form1() {
            InitializeComponent();
        }

        private void OnAddOrderButtonClick(object sender, EventArgs e) {
            ordersSource.Add(new Order(string.Concat("Order ", ++cnt)));
        }
    }
}
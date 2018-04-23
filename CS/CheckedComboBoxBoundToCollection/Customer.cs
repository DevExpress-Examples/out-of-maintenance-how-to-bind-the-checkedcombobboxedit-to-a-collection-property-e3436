using System.Text;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraEditors.Repository;

namespace CheckedComboBoxBoundToCollection {
    public class Customer {
        string fName;
        public string Name {
            get { return fName; }
            set { fName = value; }
        }

        List<Order> fOrders = new List<Order>();
        public List<Order> Orders {
            get { return fOrders; }
        }

        public string OrdersForBinding {
            get {
                StringBuilder result = new StringBuilder();
                foreach (Order order in Orders)
                    result.AppendFormat(" {0}{1}", order.ID, ',');
                return result.ToString().TrimStart().TrimEnd(',');
            }
            set {
                Orders.Clear();
                foreach (string id in value.Split(','))
                    Orders.Add(EntityCache.Orders[int.Parse(id)]);
            }
        }
    }
}

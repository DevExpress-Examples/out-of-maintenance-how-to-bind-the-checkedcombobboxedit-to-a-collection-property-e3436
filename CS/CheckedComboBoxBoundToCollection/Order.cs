namespace CheckedComboBoxBoundToCollection {
    public class Order {
        static int cnt;

        public Order(string orderName) {
            fId = ++cnt;
            fOrderName = orderName;
            EntityCache.Orders.Add(fId, this);
        }

        int fId;
        public int ID {
            get { return fId; }
        }

        string fOrderName;
        public string OrderName {
            get { return fOrderName; }
            set { fOrderName = value; }
        }
    }
}

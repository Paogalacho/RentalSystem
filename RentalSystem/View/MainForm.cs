using RentalSystem.Controller;

namespace RentalSystem.View
{
    public partial class MainForm : Form
    {
        private readonly RentalController controller;

        public MainForm(RentalController controller)
        {
            this.controller = controller;
            InitializeComponent();
            InitializeTabs();
        }

        private void InitializeTabs()
        {
            InitializeInventoryTab();
            InitializeRentTab();
            InitializeReturnTab();
        }

        private void InitializeInventoryTab()
        {
            inventoryListView.Items.Clear();
            foreach (var item in controller.GetAllItems())
            {
                var listViewItem = new ListViewItem(item.Id);
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.GetType().Name);
                listViewItem.SubItems.Add(item.BasePrice.ToString("C"));
                listViewItem.SubItems.Add(item.IsAvailable ? "Yes" : "No");
                inventoryListView.Items.Add(listViewItem);
            }
        }

        private void InitializeRentTab()
        {
            rentItemIdComboBox.Items.Clear();
            pricingStrategyCheckedListBox.Items.Clear();

            foreach (var item in controller.GetAvailableItems())
            {
                rentItemIdComboBox.Items.Add(item.Id);
            }

            pricingStrategyCheckedListBox.Items.AddRange(new object[] { "Standard", "Discount", "Weekly" });
            pricingStrategyCheckedListBox.SetItemChecked(0, true); // Standard always selected by default

            // Clear all text boxes
            basePriceTextBox.Clear();
            totalPriceTextBox.Clear();
            rentDaysTextBox.Clear();
            rentHoursTextBox.Clear();

            // Ensure event handler is connected
            rentItemIdComboBox.SelectedIndexChanged += RentItemIdComboBox_SelectedIndexChanged;
        }

        private void RentItemIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rentItemIdComboBox.SelectedItem is string itemId)
            {
                var item = controller.GetItem(itemId);
                if (item != null)
                {
                    basePriceTextBox.Text = item.BasePrice.ToString("C");
                    totalPriceTextBox.Clear();
                }
            }
        }

        private void calculatePriceButton_Click(object sender, EventArgs e)
        {
            string itemId = rentItemIdComboBox.Text;
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Please select an item to rent.");
                return;
            }

            if (!int.TryParse(rentDaysTextBox.Text, out int days) || days < 0)
            {
                MessageBox.Show("Please enter a valid number of days.");
                return;
            }

            if (!int.TryParse(rentHoursTextBox.Text, out int hours) || hours < 0 || hours >= 24)
            {
                MessageBox.Show("Please enter a valid number of hours (0-23).");
                return;
            }

            List<string> selectedStrategies = pricingStrategyCheckedListBox.CheckedItems
                .Cast<string>()
                .ToList();

            try
            {
                decimal totalPrice = controller.CalculateRentalPrice(itemId, days, hours, selectedStrategies);
                totalPriceTextBox.Text = totalPrice.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void InitializeReturnTab()
        {
            returnItemIdComboBox.Items.Clear();
            foreach (var item in controller.GetRentedItems())
            {
                returnItemIdComboBox.Items.Add(item.Id);
            }
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            string itemId = rentItemIdComboBox.Text;
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Please select an item to rent.");
                return;
            }

            if (!int.TryParse(rentDaysTextBox.Text, out int days) || days < 0)
            {
                MessageBox.Show("Please enter a valid number of days.");
                return;
            }

            if (!int.TryParse(rentHoursTextBox.Text, out int hours) || hours < 0 || hours >= 24)
            {
                MessageBox.Show("Please enter a valid number of hours (0-23).");
                return;
            }

            try
            {
                controller.RentItem(itemId, days, hours);
                MessageBox.Show($"Item {itemId} rented successfully for {days} days and {hours} hours.");
                RefreshTabs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string itemId = returnItemIdComboBox.Text;
            if (string.IsNullOrEmpty(itemId))
            {
                MessageBox.Show("Please select an item to return.");
                return;
            }

            try
            {
                controller.ReturnItem(itemId);
                MessageBox.Show($"Item {itemId} returned successfully.");
                RefreshTabs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RefreshTabs()
        {
            InitializeTabs();
        }
    }
}
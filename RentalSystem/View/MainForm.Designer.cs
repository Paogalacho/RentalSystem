namespace RentalSystem.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.inventoryListView = new System.Windows.Forms.ListView();
            this.idColumn = new System.Windows.Forms.ColumnHeader();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.typeColumn = new System.Windows.Forms.ColumnHeader();
            this.basePriceColumn = new System.Windows.Forms.ColumnHeader();
            this.availableColumn = new System.Windows.Forms.ColumnHeader();
            this.rentTab = new System.Windows.Forms.TabPage();
            this.calculatePriceButton = new System.Windows.Forms.Button();
            this.rentButton = new System.Windows.Forms.Button();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.basePriceTextBox = new System.Windows.Forms.TextBox();
            this.basePriceLabel = new System.Windows.Forms.Label();
            this.rentHoursTextBox = new System.Windows.Forms.TextBox();
            this.rentHoursLabel = new System.Windows.Forms.Label();
            this.rentDaysTextBox = new System.Windows.Forms.TextBox();
            this.rentDaysLabel = new System.Windows.Forms.Label();
            this.pricingStrategyCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.pricingStrategyLabel = new System.Windows.Forms.Label();
            this.rentItemIdComboBox = new System.Windows.Forms.ComboBox();
            this.rentItemIdLabel = new System.Windows.Forms.Label();
            this.returnTab = new System.Windows.Forms.TabPage();
            this.returnButton = new System.Windows.Forms.Button();
            this.returnItemIdComboBox = new System.Windows.Forms.ComboBox();
            this.returnItemIdLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.rentTab.SuspendLayout();
            this.returnTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.inventoryTab);
            this.tabControl.Controls.Add(this.rentTab);
            this.tabControl.Controls.Add(this.returnTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.inventoryListView);
            this.inventoryTab.Location = new System.Drawing.Point(4, 24);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryTab.Size = new System.Drawing.Size(792, 422);
            this.inventoryTab.TabIndex = 0;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.UseVisualStyleBackColor = true;
            // 
            // inventoryListView
            // 
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn,
            this.typeColumn,
            this.basePriceColumn,
            this.availableColumn});
            this.inventoryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryListView.FullRowSelect = true;
            this.inventoryListView.GridLines = true;
            this.inventoryListView.Location = new System.Drawing.Point(3, 3);
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.Size = new System.Drawing.Size(786, 416);
            this.inventoryListView.TabIndex = 0;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 200;
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            this.typeColumn.Width = 100;
            // 
            // basePriceColumn
            // 
            this.basePriceColumn.Text = "Base Price";
            this.basePriceColumn.Width = 100;
            // 
            // availableColumn
            // 
            this.availableColumn.Text = "Available";
            this.availableColumn.Width = 100;
            // 
            // rentTab
            // 
            this.rentTab.Controls.Add(this.calculatePriceButton);
            this.rentTab.Controls.Add(this.rentButton);
            this.rentTab.Controls.Add(this.totalPriceTextBox);
            this.rentTab.Controls.Add(this.totalPriceLabel);
            this.rentTab.Controls.Add(this.basePriceTextBox);
            this.rentTab.Controls.Add(this.basePriceLabel);
            this.rentTab.Controls.Add(this.rentHoursTextBox);
            this.rentTab.Controls.Add(this.rentHoursLabel);
            this.rentTab.Controls.Add(this.rentDaysTextBox);
            this.rentTab.Controls.Add(this.rentDaysLabel);
            this.rentTab.Controls.Add(this.pricingStrategyCheckedListBox);
            this.rentTab.Controls.Add(this.pricingStrategyLabel);
            this.rentTab.Controls.Add(this.rentItemIdComboBox);
            this.rentTab.Controls.Add(this.rentItemIdLabel);
            this.rentTab.Location = new System.Drawing.Point(4, 24);
            this.rentTab.Name = "rentTab";
            this.rentTab.Padding = new System.Windows.Forms.Padding(3);
            this.rentTab.Size = new System.Drawing.Size(792, 422);
            this.rentTab.TabIndex = 1;
            this.rentTab.Text = "Rent";
            this.rentTab.UseVisualStyleBackColor = true;
            // 
            // calculatePriceButton
            // 
            this.calculatePriceButton.Location = new System.Drawing.Point(8, 280);
            this.calculatePriceButton.Name = "calculatePriceButton";
            this.calculatePriceButton.Size = new System.Drawing.Size(100, 23);
            this.calculatePriceButton.TabIndex = 13;
            this.calculatePriceButton.Text = "Calculate Price";
            this.calculatePriceButton.UseVisualStyleBackColor = true;
            this.calculatePriceButton.Click += new System.EventHandler(this.calculatePriceButton_Click);
            // 
            // rentButton
            // 
            this.rentButton.Location = new System.Drawing.Point(8, 309);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(75, 23);
            this.rentButton.TabIndex = 12;
            this.rentButton.Text = "Rent";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(8, 251);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.totalPriceTextBox.TabIndex = 11;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(8, 233);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(65, 15);
            this.totalPriceLabel.TabIndex = 10;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // basePriceTextBox
            // 
            this.basePriceTextBox.Location = new System.Drawing.Point(8, 207);
            this.basePriceTextBox.Name = "basePriceTextBox";
            this.basePriceTextBox.ReadOnly = true;
            this.basePriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.basePriceTextBox.TabIndex = 9;
            // 
            // basePriceLabel
            // 
            this.basePriceLabel.AutoSize = true;
            this.basePriceLabel.Location = new System.Drawing.Point(8, 189);
            this.basePriceLabel.Name = "basePriceLabel";
            this.basePriceLabel.Size = new System.Drawing.Size(64, 15);
            this.basePriceLabel.TabIndex = 8;
            this.basePriceLabel.Text = "Base Price:";
            // 
            // rentHoursTextBox
            // 
            this.rentHoursTextBox.Location = new System.Drawing.Point(8, 163);
            this.rentHoursTextBox.Name = "rentHoursTextBox";
            this.rentHoursTextBox.Size = new System.Drawing.Size(100, 23);
            this.rentHoursTextBox.TabIndex = 7;
            // 
            // rentHoursLabel
            // 
            this.rentHoursLabel.AutoSize = true;
            this.rentHoursLabel.Location = new System.Drawing.Point(8, 145);
            this.rentHoursLabel.Name = "rentHoursLabel";
            this.rentHoursLabel.Size = new System.Drawing.Size(43, 15);
            this.rentHoursLabel.TabIndex = 6;
            this.rentHoursLabel.Text = "Hours:";
            // 
            // rentDaysTextBox
            // 
            this.rentDaysTextBox.Location = new System.Drawing.Point(8, 119);
            this.rentDaysTextBox.Name = "rentDaysTextBox";
            this.rentDaysTextBox.Size = new System.Drawing.Size(100, 23);
            this.rentDaysTextBox.TabIndex = 5;
            // 
            // rentDaysLabel
            // 
            this.rentDaysLabel.AutoSize = true;
            this.rentDaysLabel.Location = new System.Drawing.Point(8, 101);
            this.rentDaysLabel.Name = "rentDaysLabel";
            this.rentDaysLabel.Size = new System.Drawing.Size(35, 15);
            this.rentDaysLabel.TabIndex = 4;
            this.rentDaysLabel.Text = "Days:";
            // 
            // pricingStrategyCheckedListBox
            // 
            this.pricingStrategyCheckedListBox.FormattingEnabled = true;
            this.pricingStrategyCheckedListBox.Location = new System.Drawing.Point(114, 28);
            this.pricingStrategyCheckedListBox.Name = "pricingStrategyCheckedListBox";
            this.pricingStrategyCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.pricingStrategyCheckedListBox.TabIndex = 3;
            // 
            // pricingStrategyLabel
            // 
            this.pricingStrategyLabel.AutoSize = true;
            this.pricingStrategyLabel.Location = new System.Drawing.Point(114, 10);
            this.pricingStrategyLabel.Name = "pricingStrategyLabel";
            this.pricingStrategyLabel.Size = new System.Drawing.Size(95, 15);
            this.pricingStrategyLabel.TabIndex = 2;
            this.pricingStrategyLabel.Text = "Pricing Strategy:";
            // 
            // rentItemIdComboBox
            // 
            this.rentItemIdComboBox.FormattingEnabled = true;
            this.rentItemIdComboBox.Location = new System.Drawing.Point(8, 28);
            this.rentItemIdComboBox.Name = "rentItemIdComboBox";
            this.rentItemIdComboBox.Size = new System.Drawing.Size(100, 23);
            this.rentItemIdComboBox.TabIndex = 1;
            // 
            // rentItemIdLabel
            // 
            this.rentItemIdLabel.AutoSize = true;
            this.rentItemIdLabel.Location = new System.Drawing.Point(8, 10);
            this.rentItemIdLabel.Name = "rentItemIdLabel";
            this.rentItemIdLabel.Size = new System.Drawing.Size(48, 15);
            this.rentItemIdLabel.TabIndex = 0;
            this.rentItemIdLabel.Text = "Item ID:";
            // 
            // returnTab
            // 
            this.returnTab.Controls.Add(this.returnButton);
            this.returnTab.Controls.Add(this.returnItemIdComboBox);
            this.returnTab.Controls.Add(this.returnItemIdLabel);
            this.returnTab.Location = new System.Drawing.Point(4, 24);
            this.returnTab.Name = "returnTab";
            this.returnTab.Size = new System.Drawing.Size(792, 422);
            this.returnTab.TabIndex = 2;
            this.returnTab.Text = "Return";
            this.returnTab.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(8, 57);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // returnItemIdComboBox
            // 
            this.returnItemIdComboBox.FormattingEnabled = true;
            this.returnItemIdComboBox.Location = new System.Drawing.Point(8, 28);
            this.returnItemIdComboBox.Name = "returnItemIdComboBox";
            this.returnItemIdComboBox.Size = new System.Drawing.Size(121, 23);
            this.returnItemIdComboBox.TabIndex = 1;
            // 
            // returnItemIdLabel
            // 
            this.returnItemIdLabel.AutoSize = true;
            this.returnItemIdLabel.Location = new System.Drawing.Point(8, 10);
            this.returnItemIdLabel.Name = "returnItemIdLabel";
            this.returnItemIdLabel.Size = new System.Drawing.Size(48, 15);
            this.returnItemIdLabel.TabIndex = 0;
            this.returnItemIdLabel.Text = "Item ID:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Rental System";
            this.tabControl.ResumeLayout(false);
            this.inventoryTab.ResumeLayout(false);
            this.rentTab.ResumeLayout(false);
            this.rentTab.PerformLayout();
            this.returnTab.ResumeLayout(false);
            this.returnTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage inventoryTab;
        private ListView inventoryListView;
        private ColumnHeader idColumn;
        private ColumnHeader nameColumn;
        private ColumnHeader typeColumn;
        private ColumnHeader basePriceColumn;
        private ColumnHeader availableColumn;
        private TabPage rentTab;
        private Button calculatePriceButton;
        private Button rentButton;
        private TextBox totalPriceTextBox;
        private Label totalPriceLabel;
        private TextBox basePriceTextBox;
        private Label basePriceLabel;
        private TextBox rentHoursTextBox;
        private Label rentHoursLabel;
        private TextBox rentDaysTextBox;
        private Label rentDaysLabel;
        private CheckedListBox pricingStrategyCheckedListBox;
        private Label pricingStrategyLabel;
        private ComboBox rentItemIdComboBox;
        private Label rentItemIdLabel;
        private TabPage returnTab;
        private Button returnButton;
        private ComboBox returnItemIdComboBox;
        private Label returnItemIdLabel;
    }
}
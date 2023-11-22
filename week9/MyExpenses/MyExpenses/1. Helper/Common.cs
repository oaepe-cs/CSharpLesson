using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyExpenses
{
    public class Common
    {
        public static void PopulateComboBox(ComboBox cb)
        {
            // Add items using the Items property
            cb.Items.Add("Item 1");
            cb.Items.Add("Item 2");
            cb.Items.Add("Item 3");

            // You can also add items using a loop or by providing a collection
            // For example, using a loop to add numbers from 1 to 5
            for (int i = 1; i <= 5; i++)
            {
                cb.Items.Add(i);
                KeyValuePair<int, string> a = new KeyValuePair<int, string>(6, "");

            }

            // Add items with key-value pairs
            cb.Items.Add(new KeyValuePair<int, string>(6, "Item 6"));
            cb.Items.Add(new KeyValuePair<int, string>(7, "Item 7"));

            // Display a property of an object in the ComboBox
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";

            // Set the ComboBox to initially display the first item
            cb.SelectedIndex = 0;
        }
    }
}

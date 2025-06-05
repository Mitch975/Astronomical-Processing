// Mitchell Barker, Team Mitch, Sprint Number 1
// Date: 5/6/25
// Version: 1
// Astronomical Processing
// Brief explanation of the program and list,
// Inputs, Processes, Outputs


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomical_Processing
{
    public partial class SprintForm1 : Form
    {
        public SprintForm1()
        {
            InitializeComponent();
            //Call a method to fill Array
            FillArray();
        }
        // Defining my Array with a value of 24
        static int max = 24;
        int[] myArray = new int[max];

        // Button click event to perform binary search
        private void ButtonSearch_Click(object sender, EventArgs e)
        {

            int mid;
            int lowBound = 0;
            int highBound = max - 1;
            int target;

            // TryParse the text from the textbox to a integer variable, if box is empty show error.
            if (!(Int32.TryParse(TextBoxSearch.Text, out target)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }

            // Binary search loop
            while (lowBound <= highBound)
            {
                // Display the current array portion in the ListBox
                ShowArray(lowBound, highBound);

                // Find the mid-point
                mid = (lowBound + highBound) / 2;

                if (myArray[mid] == target)
                {
                    // Target found
                    ListBoxResults.Items.Add("Found at index " + mid);

                    // Find duplicates on the left side (search for leftmost occurrence)
                    int leftIndex = mid - 1;
                    while (leftIndex >= 0 && myArray[leftIndex] == target)
                    {
                        ListBoxResults.Items.Add("Found at index " + leftIndex);
                        leftIndex--;
                    }

                    // Find duplicates on the right side (search for rightmost occurrence)
                    int rightIndex = mid + 1;
                    while (rightIndex < myArray.Length && myArray[rightIndex] == target)
                    {
                        ListBoxResults.Items.Add("Found at index " + rightIndex);
                        rightIndex++;
                    }
                    MessageBox.Show("Value found!");
                    return;
                }
                else if (myArray[mid] > target)
                {
                    // Target is smaller, search left
                    highBound = mid - 1;
                }
                else
                {
                    // Target is larger, search right
                    lowBound = mid + 1;
                }
            }

            // If we get here, the target is not in the array
            MessageBox.Show("Not Found, try again.");
        }

        // Method to display Array between low and high bounds
        private void ShowArray(int lowbound, int highbound)
        {
            int mid = (lowbound + highbound) / 2;
            ListBoxResults.Items.Clear();  // Clear previous results
            ListBoxResults.Items.Add($"Searching Value: {TextBoxSearch.Text}");
        }

        // Method to fill Array with random numbers
        private void FillArray()
        {
            Random rand = new Random();
            for (int i = 0; i < max; i++)
            {
                myArray[i] = rand.Next(10, 90);  // Random numbers between 10 and 90
            }

        }

        // Button click event to sort and display the entire array
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            ListBoxResults.Items.Clear();  // Clear previous results

            int n = myArray.Length;

            // Bubble sort algorithm
            for (int i = 0; i < n - 1; i++)
            {
                // Track if a swap was made
                bool swapped = false;

                // Traverse the array from 0 to n - i - 1
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Compare adjacent elements
                    if (myArray[j] > myArray[j + 1])
                    {
                        // Swap if elements are in the wrong order
                        int temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;

                        swapped = true; // Indicate a swap was made
                    }
                }

                // If no swaps were made, the array is already sorted
                if (!swapped)
                    break;
            }



            ListBoxResults.Items.Add("Sorted Values: ");  // header text

            // Add each element of the sorted array on a new line
            foreach (int value in myArray)
            {
                ListBoxResults.Items.Add(value);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Get the input from the user in the form of index:newValue using the split function
            string input = TextBoxSearch.Text;
            string[] parts = input.Split(':');

            if (parts.Length != 2)
            {
                MessageBox.Show("Please enter input in the format 'index:newValue'.");
                return;
            }

            // Try parsing the index and the new value
            int index, newValue;

            if (!Int32.TryParse(parts[0], out index))
            {
                MessageBox.Show("Please enter a valid index.");
                return;
            }

            if (!Int32.TryParse(parts[1], out newValue))
            {
                MessageBox.Show("Please enter a valid new value.");
                return;
            }

            // Check if the index is within the valid range of the array
            if (index < 0 || index >= myArray.Length)
            {
                MessageBox.Show("Index is out of bounds. Please enter a valid index.");
                return;
            }

            // Update the array at the specified index, clear the listbox and repost the array with the updated value at the index point.
            myArray[index] = newValue;
            ListBoxResults.Items.Clear();
            ListBoxResults.Items.Add("Updated Array: ");
            foreach (int value in myArray)
            {
                ListBoxResults.Items.Add(value);
            }

            // Shows a messagebox for index value update
            MessageBox.Show($"Value at index {index} has been updated to {newValue}.");

        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            //Shows the unsorted array in the listbox
            ListBoxResults.Items.Clear();
            foreach (int value in myArray)
            {
                ListBoxResults.Items.Add(value);
            }
        }

        private void ListBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MidExButton_Click(object sender, EventArgs e)
        {
            //initialize the min and max variables
            int min = myArray[0];
            int maxVal = myArray[0];

            //loop through the array
            for (int i = 1; i < myArray.Length; i++)
            {
                //update the min and max if the current element is smaller or larger.
                if (myArray[i] < min) min = myArray[i];
                if (myArray[i] > maxVal) maxVal = myArray[i];
            }
            //Calculate the midExtreme and display the value formatted to 2 decimal places (double) in the output textbox.
            double midExtreme = (min + maxVal) / 2.0;
            TextBoxOutput.Text = $"Mid-Extreme: {midExtreme:F2}";
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            //Create dictionary to hold each number as a key and its frequency as a value
            Dictionary<int, int> Counts= new Dictionary<int, int>();

            //Count occurences of each number in the array
            foreach (int a in myArray) {
                if (Counts.ContainsKey(a))
                    Counts[a] = Counts[a] + 1; //if key exists increase count by 1
                else
                    Counts[a] = 1; // Create new key count
             }
            
            //initialise variable to store mode and max(key frequency)
            int modes = int.MinValue;
            int max = int.MinValue;

            //Find the number with the highest frequency
            foreach (int key in Counts.Keys)
            {
                if (Counts[key] > max)
                {
                    max = Counts[key];
                    modes = key;
                }
            }
            //Output result to the textbox.
            TextBoxOutput.Text = $"Mode: " + string.Join(", ", modes);
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            double total = 0;

            //Add all values in the array
            for (int i = 0; i < myArray.Length; i++)
            {
                total += myArray[i];
            }
            //Calculate the average and output
            double average = total / myArray.Length;
            TextBoxOutput.Text = $"Average: {average:F2}";
        }

        private void RangeButton_Click(object sender, EventArgs e)
        {
            //Initialise the min and max value by using the 1st element of the array
            int min = myArray[0];
            int maxVal = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < min) min = myArray[i];
                if (myArray[i] > maxVal) maxVal = myArray[i];
            }

            //Calculate the range and output result to textbox
            int range = maxVal - min;
            TextBoxOutput.Text = $"Range: {range}";
        }

        private void SequentialSearchButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox and checks if the search box is empty or has whitespace
            ListBoxResults.Items.Clear();
            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            int searchValue;
            
            //TryParse the search input as an integer so users cant input letters etc
            if (!int.TryParse(TextBoxSearch.Text, out searchValue))
            {
                MessageBox.Show("Please enter a valid integer.");
                return;
            }

            bool found = false;

            //Loop through the array to find the search value
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == searchValue)
                {
                    ListBoxResults.Items.Add($"Searching Value: {TextBoxSearch.Text}");
                    ListBoxResults.Items.Add($"Found at index {i}");
                    found = true;
                }
            }
            //Generate a Error or Success message
            if (!found)
            {
                MessageBox.Show("Value not found."); 
            }
            else
            {

                MessageBox.Show("Search successful!");
            }
        }
    }
}
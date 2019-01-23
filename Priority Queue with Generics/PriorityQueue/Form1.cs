using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityQueue___Patrick_Hill
{
    public partial class Form1 : Form
    {

        //fields
        private PriorityQueue<string> pq = new PriorityQueue<string>();

        private PriorityQueue<string>.PQNode workNode;

        bool success;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Call method to reload count label:
            LoadCountLabel();

            buttonDequeue.Enabled = false;

        }


        private void buttonEnqueue_Click(object sender, EventArgs e)
        {

            workNode.Item = textBoxItem.Text;

            success = int.TryParse(textBoxPriority.Text, out int priorityInt);

            workNode.Priority = priorityInt;

            success = pq.Enqueue(workNode);

            //Bail if not success:
            if (!success)
            {
                return;
            }

            //Call method to reload the enqueued items label:
            LoadEnqueuedItemsLabel();

            //Call method to reload count label:
            LoadCountLabel();

            //Clear previous entry in the textboxes
            textBoxItem.Text = "";
            textBoxPriority.Text = "";

            //Enable Dequeue Button after Enqueueing
            buttonDequeue.Enabled = true;
        }

        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            workNode = pq.Dequeue();

            //If queue is empty, bail:
            if (workNode.Priority == 0)
            {

                return;
            }

            // Add dequeued node to dequeued label:
            labelDequeuedItems.Text += ($"{workNode.Priority} {workNode.Item}\n");

            //Call method to reload the enqueued items label:
            LoadEnqueuedItemsLabel();


            //Call method to reload count label:
            LoadCountLabel();

            //Disable Dequeue Button if Count is 0
            if (pq.Count == 0)
            {
                buttonDequeue.Enabled = false;
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            pq.Clear();
            textBoxPriority.Text = "";
            textBoxItem.Text = "";

            labelEnqueueItems.Text = string.Empty;
            labelDequeuedItems.Text = string.Empty;

            //Call method to reload count label:
            LoadCountLabel();

            //Disable Dequeue button upon Reset
            buttonDequeue.Enabled = false;
        }

        //Method to load EnqueuedItems label from the priority queue:
        private void LoadEnqueuedItemsLabel()
        {
            labelEnqueueItems.Text = string.Empty;

            for (int i = 0; i < pq.Count; i++)
            {
                workNode = pq[i];
                labelEnqueueItems.Text = labelEnqueueItems.Text + ($"{workNode.Priority} {workNode.Item}\n");
            }
        }

        // Method to update the count label from the priority queue count:
        private void LoadCountLabel()
        {
            labelPriorityQueueCount.Text = ($"The Priority Queue contains {pq.Count} items.");
        }

    }
}

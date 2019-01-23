namespace PriorityQueue___Patrick_Hill
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.buttonEnqueue = new System.Windows.Forms.Button();
            this.buttonDequeue = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPriorityQueueCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEnqueueItems = new System.Windows.Forms.Label();
            this.labelDequeuedItems = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Item:";
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(99, 29);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriority.TabIndex = 2;
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(99, 68);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(100, 20);
            this.textBoxItem.TabIndex = 3;
            // 
            // buttonEnqueue
            // 
            this.buttonEnqueue.Location = new System.Drawing.Point(265, 29);
            this.buttonEnqueue.Name = "buttonEnqueue";
            this.buttonEnqueue.Size = new System.Drawing.Size(88, 27);
            this.buttonEnqueue.TabIndex = 4;
            this.buttonEnqueue.Text = "Enqueue";
            this.buttonEnqueue.UseVisualStyleBackColor = true;
            this.buttonEnqueue.Click += new System.EventHandler(this.buttonEnqueue_Click);
            // 
            // buttonDequeue
            // 
            this.buttonDequeue.Location = new System.Drawing.Point(265, 68);
            this.buttonDequeue.Name = "buttonDequeue";
            this.buttonDequeue.Size = new System.Drawing.Size(88, 24);
            this.buttonDequeue.TabIndex = 5;
            this.buttonDequeue.Text = "Dequeue";
            this.buttonDequeue.UseVisualStyleBackColor = true;
            this.buttonDequeue.Click += new System.EventHandler(this.buttonDequeue_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(265, 115);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 23);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelPriorityQueueCount
            // 
            this.labelPriorityQueueCount.AutoSize = true;
            this.labelPriorityQueueCount.Location = new System.Drawing.Point(28, 122);
            this.labelPriorityQueueCount.Name = "labelPriorityQueueCount";
            this.labelPriorityQueueCount.Size = new System.Drawing.Size(0, 15);
            this.labelPriorityQueueCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enqueued Items:";
            // 
            // labelEnqueueItems
            // 
            this.labelEnqueueItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelEnqueueItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnqueueItems.Location = new System.Drawing.Point(22, 196);
            this.labelEnqueueItems.Name = "labelEnqueueItems";
            this.labelEnqueueItems.Size = new System.Drawing.Size(152, 143);
            this.labelEnqueueItems.TabIndex = 9;
            // 
            // labelDequeuedItems
            // 
            this.labelDequeuedItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelDequeuedItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDequeuedItems.Location = new System.Drawing.Point(203, 196);
            this.labelDequeuedItems.Name = "labelDequeuedItems";
            this.labelDequeuedItems.Size = new System.Drawing.Size(150, 143);
            this.labelDequeuedItems.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dequeued Items:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Note: Items with higher priority will be dequeued first.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDequeuedItems);
            this.Controls.Add(this.labelEnqueueItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPriorityQueueCount);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDequeue);
            this.Controls.Add(this.buttonEnqueue);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.textBoxPriority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Button buttonEnqueue;
        private System.Windows.Forms.Button buttonDequeue;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelPriorityQueueCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEnqueueItems;
        private System.Windows.Forms.Label labelDequeuedItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}


namespace HotelBookingManager
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
            ListViewItem listViewItem1 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BookRoomButton = new Button();
            GuestName = new TextBox();
            RoomNumber = new TextBox();
            RoomLabel = new Label();
            GuestLabel = new Label();
            CheckInDate = new DateTimePicker();
            CheckOutDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            CancelBookingButton = new Button();
            ViewBookingsButton = new Button();
            ExitButton = new Button();
            StatusLabel = new Label();
            ActiveBookings = new ListView();
            Guest = new ColumnHeader();
            Room = new ColumnHeader();
            CheckIn = new ColumnHeader();
            CheckOut = new ColumnHeader();
            SuspendLayout();
            // 
            // BookRoomButton
            // 
            BookRoomButton.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookRoomButton.Location = new Point(40, 395);
            BookRoomButton.Margin = new Padding(3, 4, 3, 4);
            BookRoomButton.Name = "BookRoomButton";
            BookRoomButton.Size = new Size(134, 45);
            BookRoomButton.TabIndex = 0;
            BookRoomButton.Text = "Book Room";
            BookRoomButton.UseVisualStyleBackColor = true;
            BookRoomButton.MouseClick += BookRoom;
            // 
            // GuestName
            // 
            GuestName.Location = new Point(181, 80);
            GuestName.Margin = new Padding(3, 4, 3, 4);
            GuestName.Name = "GuestName";
            GuestName.Size = new Size(277, 31);
            GuestName.TabIndex = 1;
            // 
            // RoomNumber
            // 
            RoomNumber.Location = new Point(702, 81);
            RoomNumber.Margin = new Padding(3, 4, 3, 4);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(113, 31);
            RoomNumber.TabIndex = 2;
            // 
            // RoomLabel
            // 
            RoomLabel.AutoSize = true;
            RoomLabel.BackColor = Color.Transparent;
            RoomLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomLabel.ForeColor = Color.White;
            RoomLabel.Location = new Point(508, 82);
            RoomLabel.Name = "RoomLabel";
            RoomLabel.Size = new Size(136, 22);
            RoomLabel.TabIndex = 3;
            RoomLabel.Text = "Room Number";
            // 
            // GuestLabel
            // 
            GuestLabel.AutoSize = true;
            GuestLabel.BackColor = Color.Transparent;
            GuestLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuestLabel.ForeColor = Color.White;
            GuestLabel.Location = new Point(36, 81);
            GuestLabel.Name = "GuestLabel";
            GuestLabel.Size = new Size(120, 22);
            GuestLabel.TabIndex = 4;
            GuestLabel.Text = "Guest Name";
            // 
            // CheckInDate
            // 
            CheckInDate.CustomFormat = "MM/dd/yyyy hh:mm";
            CheckInDate.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInDate.Format = DateTimePickerFormat.Custom;
            CheckInDate.Location = new Point(191, 151);
            CheckInDate.Margin = new Padding(3, 4, 3, 4);
            CheckInDate.Name = "CheckInDate";
            CheckInDate.Size = new Size(211, 26);
            CheckInDate.TabIndex = 5;
            CheckInDate.ValueChanged += Check_ValueChanged;
            // 
            // CheckOutDate
            // 
            CheckOutDate.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutDate.CustomFormat = "MM/dd/yyyy hh:mm";
            CheckOutDate.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutDate.Format = DateTimePickerFormat.Custom;
            CheckOutDate.Location = new Point(191, 254);
            CheckOutDate.Margin = new Padding(3, 4, 3, 4);
            CheckOutDate.MinDate = new DateTime(2026, 3, 8, 0, 0, 0, 0);
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.Size = new Size(211, 26);
            CheckOutDate.TabIndex = 6;
            CheckOutDate.Value = new DateTime(2026, 3, 8, 17, 54, 7, 0);
            CheckOutDate.ValueChanged += Check_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 156);
            label1.Name = "label1";
            label1.Size = new Size(89, 22);
            label1.TabIndex = 9;
            label1.Text = "Check-In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 259);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 10;
            label2.Text = "Check-Out";
            // 
            // CancelBookingButton
            // 
            CancelBookingButton.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBookingButton.Location = new Point(191, 395);
            CancelBookingButton.Margin = new Padding(3, 4, 3, 4);
            CancelBookingButton.Name = "CancelBookingButton";
            CancelBookingButton.Size = new Size(171, 45);
            CancelBookingButton.TabIndex = 11;
            CancelBookingButton.Text = "Cancel Booking";
            CancelBookingButton.UseVisualStyleBackColor = true;
            CancelBookingButton.Click += CancelBooking;
            // 
            // ViewBookingsButton
            // 
            ViewBookingsButton.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewBookingsButton.Location = new Point(378, 395);
            ViewBookingsButton.Margin = new Padding(3, 4, 3, 4);
            ViewBookingsButton.Name = "ViewBookingsButton";
            ViewBookingsButton.Size = new Size(179, 45);
            ViewBookingsButton.TabIndex = 12;
            ViewBookingsButton.Text = "View All Bookings";
            ViewBookingsButton.UseVisualStyleBackColor = true;
            ViewBookingsButton.MouseClick += ViewAllBookings;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(681, 395);
            ExitButton.Margin = new Padding(3, 4, 3, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(134, 45);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.MouseClick += Exit;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.BackColor = Color.Transparent;
            StatusLabel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = Color.White;
            StatusLabel.Location = new Point(613, 494);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(249, 20);
            StatusLabel.TabIndex = 15;
            StatusLabel.Text = "Status: Waiting for user input.";
            // 
            // ActiveBookings
            // 
            ActiveBookings.Columns.AddRange(new ColumnHeader[] { Guest, Room, CheckIn, CheckOut });
            ActiveBookings.Items.AddRange(new ListViewItem[] { listViewItem1 });
            ActiveBookings.Location = new Point(40, 494);
            ActiveBookings.Margin = new Padding(3, 4, 3, 4);
            ActiveBookings.Name = "ActiveBookings";
            ActiveBookings.Size = new Size(537, 156);
            ActiveBookings.TabIndex = 16;
            ActiveBookings.UseCompatibleStateImageBehavior = false;
            // 
            // CheckOut
            // 
            CheckOut.Tag = "CheckOut";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(920, 680);
            Controls.Add(ActiveBookings);
            Controls.Add(StatusLabel);
            Controls.Add(ExitButton);
            Controls.Add(ViewBookingsButton);
            Controls.Add(CancelBookingButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CheckOutDate);
            Controls.Add(CheckInDate);
            Controls.Add(GuestLabel);
            Controls.Add(RoomLabel);
            Controls.Add(RoomNumber);
            Controls.Add(GuestName);
            Controls.Add(BookRoomButton);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(942, 736);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BookRoomButton;
        private System.Windows.Forms.TextBox GuestName;
        private System.Windows.Forms.TextBox RoomNumber;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.Label GuestLabel;
        private System.Windows.Forms.DateTimePicker CheckInDate;
        private System.Windows.Forms.DateTimePicker CheckOutDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelBookingButton;
        private System.Windows.Forms.Button ViewBookingsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListView ActiveBookings;
        private System.Windows.Forms.ColumnHeader Guest;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.ColumnHeader CheckIn;
        private System.Windows.Forms.ColumnHeader CheckOut;
    }
}


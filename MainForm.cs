using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        BookingManager bookManager = new BookingManager();

        private void Check_ValueChanged(object sender, EventArgs e)
        {
            if (CheckInDate.Value > CheckOutDate.Value)
            {
                CheckOutDate.Value = CheckInDate.Value;
            }
        }

        private void BookRoom(object sender, MouseEventArgs e)
        {
            string guest = GuestName.Text;
            string room = RoomNumber.Text;
            DateTime check_in = CheckInDate.Value;
            DateTime check_out = CheckOutDate.Value;

            bool is_available = bookManager.IsAvailable(room, check_in, check_out);
            if (is_available)
            {
                try
                {
                    Booking booking = new Booking(room, guest, check_in, check_out);
                    bookManager.Add(booking);
                    RefreshList($"Status: {guest} is booked\nin Room {room}\nFrom {check_in}\nto {check_out}");
                }
                catch (ArgumentException aex)
                {
                    SetStatus(aex.Message);
                }
            }
            else
            {
                StatusLabel.Text = "Status: Reservation Not Available!";
            }
        }

        private void CancelBooking(object sender, EventArgs e)
        {
            string room = RoomNumber.Text;
            string guest = GuestName.Text;

            bookManager.Cancel(room, guest);
            RefreshList($"Status: Booking for Guest: {guest}\nRoom: {room}\nCancelled.");
        }

        private void ClearInputs()
        {
            GuestName.Text = string.Empty;
            RoomNumber.Text = string.Empty;
        }
        private void SetStatus(string status)
        {
            StatusLabel.Text = status;
        }

        private void RefreshList(string status)
        {
            ActiveBookings.Clear();
            ClearInputs();
            SetStatus(status);
        }

        private void ViewAllBookings(object sender, MouseEventArgs e)
        {
            ActiveBookings.Clear();
            ActiveBookings.View = View.Details;
            ActiveBookings.Columns.Add("Guest", 100, HorizontalAlignment.Left);
            ActiveBookings.Columns.Add("Room", 75, HorizontalAlignment.Left);
            ActiveBookings.Columns.Add("Check-In", 175, HorizontalAlignment.Left);
            ActiveBookings.Columns.Add("Check-Out", 175, HorizontalAlignment.Left);
            List<Booking> list = bookManager.ListAll();
            foreach (Booking b in list)
            {
                string guest = b.GuestName;
                string room = b.RoomNumber;
                string checkIn = b.CheckIn.ToString("g");
                string checkOut = b.CheckOut.ToString("g");

                ListViewItem item = new ListViewItem(guest);
                item.SubItems.Add(room);
                item.SubItems.Add(checkIn);
                item.SubItems.Add(checkOut);

                ActiveBookings.Items.Add(item);
            }
        }

        private void Exit(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}

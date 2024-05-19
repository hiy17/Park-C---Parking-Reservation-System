using Park_C_Updated;
using System.Windows.Forms;
using System;

public partial class EditUserForm : Form
{
    public User UpdatedUser { get; private set; }

    public EditUserForm(User user)
    {
        InitializeComponent();
        // Initialize form controls with user data
        textBoxSlot.Text = user.slot;
        textBoxDateReserved.Text = user.dateReserved;
        textBoxTimeArrival.Text = user.timeArrival;
        numericUpDownHours.Value = user.hours;
        numericUpDownPrice.Value = user.price;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        UpdatedUser = new User
        {
            slot = textBoxSlot.Text,
            dateReserved = textBoxDateReserved.Text,
            timeArrival = textBoxTimeArrival.Text,
            hours = (int)numericUpDownHours.Value,
            price = (int)numericUpDownPrice.Value
        };
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}

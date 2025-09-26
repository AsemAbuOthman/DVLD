using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DVDL.Properties;
using DVDL_Busineses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL
{
    public partial class frmAddPersonDetails : DevExpress.XtraEditors.XtraForm
    {

        int _PersonID = -1;

        public delegate void PersonAddHandler(int PersonID);

        public event PersonAddHandler PersonAdded;

        public frmAddPersonDetails()
        {
            InitializeComponent();

            ctrlPersonDetails.TitleLabel = "Add Details";
            ctrlPersonDetails.TitleImage = DVDL.Properties.Resources.PersonAddFace;
            ctrlPersonDetails.ID += " ???";
            ctrlPersonDetails.Nationality = 90;

            WindowsFormsSettings.AllowRoundedWindowCorners = DefaultBoolean.True;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                PersonAdded?.Invoke(GetPersonID()); // Raise Event
            }

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsBusiness.clsPerson Person = new clsBusiness.clsPerson();

            if (this.ctrlPersonDetails.IsValid)
            {

                Person.NationalNo = this.ctrlPersonDetails.NationalNo;
                Person.FirstName = this.ctrlPersonDetails.FirstName;
                Person.SecondName = this.ctrlPersonDetails.SecondName;
                Person.ThirdName = this.ctrlPersonDetails.ThirdName;
                Person.LastName = this.ctrlPersonDetails.LastName;
                Person.Gender = this.ctrlPersonDetails.Gender;
                Person.DateOfBirth = this.ctrlPersonDetails.DateOfBirth;
                Person.Address = this.ctrlPersonDetails.Address;
                Person.Phone = this.ctrlPersonDetails.Phone;
                Person.Email = this.ctrlPersonDetails.Email;
                Person.NationalityCountryID = this.ctrlPersonDetails.Nationality;
                Person.ImagePath = this.ctrlPersonDetails.PersonImagePath;

                if (MessageBox.Show($"Are you sure you want to add this Person ? ", "Confirm ? ",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Person.Save())
                    {
                        MessageBox.Show($"Person With ID : [{Person.PersonID}] Added Successfully.", "Added Successfully",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.ctrlPersonDetails.IsReadOnly = true;
                        _PersonID = Person.PersonID;

                    }
                    else
                    {
                        MessageBox.Show("Person was not Added !", "Addition Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show($"Operation was Canceled", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show($"Please fill missing field !", "Missing ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private int GetPersonID()
        {
            return _PersonID;
        }

        private void ctrlPersonDetails_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ctrlPersonDetails_Load(object sender, EventArgs e)
        {

        }
    }
}

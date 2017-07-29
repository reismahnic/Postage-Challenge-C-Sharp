using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostageCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void WidthTxt_TextChanged(object sender, EventArgs e)
        {
            updateChanges();
        }

        protected void HeightTxt_TextChanged(object sender, EventArgs e)
        {
            updateChanges();
        }

        protected void LengthTxt_TextChanged(object sender, EventArgs e)
        {
            updateChanges();
        }

        protected void GroundBtn_CheckedChanged(object sender, EventArgs e)
        {
            updateChanges();
        }

        protected void AirBtn_CheckedChanged(object sender, EventArgs e)
        {
            updateChanges();
        }

        protected void NextDayBtn_CheckedChanged(object sender, EventArgs e)
        {
            updateChanges();
        }


        private void updateChanges()
        {
            //check that textboxes and buttons have values
            if (!valuesExist())
            {
                return;
            }

            //determine volume
            //check to make sure value is of correct type
            int volume = 0;
            if (!tryVolume(out volume))
            {
                return;
            }


            //determine multiplier
            double costMultiplier = postageMultiplier();

            //determine cost
            double finalCost = volume * postageMultiplier();

            //print results
            OutputLbl.Text = string.Format("Your parcel will cost {0:C} to ship.", finalCost);
        }

        private bool valuesExist()
        {
            //make one of the buttons is checked
            if (!AirBtn.Checked && !GroundBtn.Checked && NextDayBtn.Checked)
            {
                return false;
            }
            //make sure BOTH width and height boxes have values
            if (WidthTxt.Text.Trim().Length == 0 || HeightTxt.Text.Trim().Length == 0)
            {
                return false;
            }
            //If both of these are true, then the parcel is good to go!
            return true;
        }

        private bool tryVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;
            //ensure there is a width
            if(!int.TryParse(WidthTxt.Text.Trim(), out width))
            {
                return false;
            }
            //ensure there is a height
            if(!int.TryParse(HeightTxt.Text.Trim(), out height))
            {
                return false;
            }
            //default length to 1 if a length was not entered
            if(!int.TryParse(LengthTxt.Text.Trim(), out length))
            {
                length = 1;
            }
            //caluculate total volume
            volume = width * height * length;
            return true;
        }

        private double postageMultiplier()
        {
            //Values for the multiplier of each postage type
            if(GroundBtn.Checked)
            {
                return .15;
            }
            else if(AirBtn.Checked)
            {
                return .25;
            }
            else if(NextDayBtn.Checked)
            {
                return .45;
            }
            else
            {
                return 0;
            }
        }


    }
}
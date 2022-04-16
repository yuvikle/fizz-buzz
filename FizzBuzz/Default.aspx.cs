using FizzBuzz.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FizzBuzz
{
    public partial class _Default : Page
    {
        private readonly IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
        protected void Page_Load(object sender, EventArgs e)
        {
            divError.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputArray = txtInput.Text.Trim().Split(',');
                var result = fizzBuzzCalculator.Calculate(inputArray);

                gvResult.DataSource = result;
                gvResult.DataBind();
            }
            catch (Exception ex)
            {
                divError.Visible = true;
                lblErrorMessage.Text = ex.Message;
            }
        }
    }
}
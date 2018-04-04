using MathsLibraryClientGui.MathsOperations;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace MathsLibraryClientGui
{
    public partial class CalculatorWeb : Form
    {
        MathsOperationsClient clientWS = new MathsOperationsClient("WSHTTP");
        MathsOperationsClient clientWS1 = new MathsOperationsClient("WSHTTP1");
        MathsOperationsClient clientWS2 = new MathsOperationsClient("WSHTTP2");
        MathsOperationsClient clientBASIC = new MathsOperationsClient("BasicHTTP");

        private Boolean aNumberReady = false;
        private Boolean bNumberReady = false;

        public CalculatorWeb()
        {
            InitializeComponent();

            PlusButton.Enabled = false;
            MinusButton.Enabled = false;
            MultButton.Enabled = false;
            DivButton.Enabled = false;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Result.Text = Convert.ToString(clientWS.Add(Int32.Parse(ANumber.Text), Int32.Parse(BNumber.Text)));
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            Result.Text = Convert.ToString(clientWS1.Mult(Int32.Parse(ANumber.Text), Int32.Parse(BNumber.Text)));
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            Result.Text = Convert.ToString(clientWS2.Sub(Int32.Parse(ANumber.Text), Int32.Parse(BNumber.Text)));
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            try
            {
                Result.Text = Convert.ToString(clientBASIC.Div(Int32.Parse(ANumber.Text), Int32.Parse(BNumber.Text)));
            }
            catch (FaultException<CustomFaultDetails> exc)
            {
                Result.Text = "FaultException<MathFault>: ErrorID " + exc.Detail.ErrorID + ". Problem: " + exc.Detail.ErrorDetails;
                clientBASIC.Abort();
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void ANumber_TextChanged(object sender, EventArgs e)
        {
            if (ANumber.Text.Length > 0)
            {
                aNumberReady = true;
            }
            else
            {
                aNumberReady = false;
            }
            CheckNumbersState();
        }

        private void BNumber_TextChanged(object sender, EventArgs e)
        {
            if (BNumber.Text.Length > 0)
            {
                bNumberReady = true;
            }
            else
            {
                bNumberReady = false;
            }
            CheckNumbersState();
        }

        private void CheckNumbersState()
        {
            if (aNumberReady && bNumberReady)
            {
                PlusButton.Enabled = true;
                MinusButton.Enabled = true;
                MultButton.Enabled = true;
                DivButton.Enabled = true;
            }
        }

        private void ANumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }

        private void BNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }
    }
}

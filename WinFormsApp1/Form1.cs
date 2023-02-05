using HtmlAgilityPack;
using System.Net;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _dataService = new DataService();
            _dataService.LoadAccount(ref LstAccount);
            labelTax.Text= _dataService.LoadTax();
            BindingCombobox(LstAccount, comboBox2);
        }
        DataService _dataService = null;
        public List<Account> LstAccount = new List<Account>();
        public List<Account> LstTransfer = new List<Account>();
        private Account currrentAccount = null;
        private Account currrentAccountToGetTransfer = null;
        public List<string> lst = new List<string>();

       
       
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxAccountName.Text) 
                && !string.IsNullOrEmpty(txtIBAN.Text))
            {

                LstAccount.Add(new Account(txtIBAN.Text, txtBoxAccountName.Text));
                _dataService.InsertAccount(txtIBAN.Text, txtBoxAccountName.Text);
                BindingCombobox(LstAccount,comboBox2);
                txtIBAN.Text = "";
                txtBoxAccountName.Text = "";
                comboBox2.SelectedIndex = LstAccount.Count-1;
            }
        }

        private void BindingCombobox(List<Account> lstAccount, ComboBox comboBox)
        {
            comboBox.DataSource = null;
            comboBox.DataSource = lstAccount;
            comboBox.DisplayMember = "AccountName";
            comboBox.ValueMember = "IBAN";

        }

        private void buttonDeposite_Click(object sender, EventArgs e)
        { 
            var tax = (numericUpDownDeposite.Value * (decimal)0.001);
            currrentAccount.Balance += numericUpDownDeposite.Value -(numericUpDownDeposite.Value * (decimal)0.001);
            labelBalance.Text = currrentAccount.Balance.ToString("0.00");

            _dataService.UpdateBalance(currrentAccount.IBAN, currrentAccount.Balance);
           
            _dataService.InsertTransactionTax(currrentAccount.IBAN, "Deposite", currrentAccount.Balance, tax);
            labelTax.Text= _dataService.LoadTax();

            //BindingCombobox(LstAccount, comboBox2);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currrentAccount = ((System.Windows.Forms.ComboBox)sender).SelectedItem as Account;

                if (currrentAccount != null)
                {
                    labelBalance.Text = currrentAccount.Balance.ToString();
                    labelIBAN.Text = currrentAccount.IBAN;
                    LstTransfer = new List<Account>();
                    foreach (var item in LstAccount)
                    {
                        if (item.IBAN != currrentAccount?.IBAN)
                        {
                            Account ac = new Account();
                            ac.Balance = item.Balance;
                            ac.AccountName = item.AccountName;
                            ac.IBAN = item.IBAN;
                            LstTransfer.Add(ac);
                        }
                    }

                    BindingCombobox(LstTransfer, comboBoxTransfer);
                }
            }
            catch { }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            currrentAccount.Balance -= numericUpDownTransfer.Value;
            numericUpDownTransfer.Maximum = currrentAccount.Balance;
            _dataService.UpdateBalance(currrentAccount.IBAN, currrentAccount.Balance);
            //BindingCombobox(LstAccount, comboBox2);
            currrentAccountToGetTransfer.Balance += numericUpDownTransfer.Value;
            foreach (var item in LstAccount)
            {
                if (item.IBAN != currrentAccount?.IBAN)
                {
                    item.Balance = currrentAccountToGetTransfer.Balance;
                }

            }
            _dataService.UpdateBalance(currrentAccountToGetTransfer.IBAN, currrentAccountToGetTransfer.Balance);
            //BindingCombobox(LstAccount, comboBox2);
            labelTax.Text= _dataService.LoadTax();
            labelBalance.Text = currrentAccount.Balance.ToString("0.00");
            labelAmountTransfer.Text = currrentAccountToGetTransfer.Balance.ToString("0.00");
            _dataService.InsertTransactionTax(currrentAccount.IBAN, "Deposite", currrentAccount.Balance, 0);

        }

        private void comboBoxTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currrentAccountToGetTransfer = ((System.Windows.Forms.ComboBox)sender).SelectedItem as Account;
                if(currrentAccountToGetTransfer != null)
                labelAmountTransfer.Text = currrentAccountToGetTransfer.Balance.ToString("0.00");
            }
            catch { }
            
        }


        //private static string ExtractIban(string responseBody)
        //    {
        //        // Parse the response body to extract the IBAN. The exact method will depend on the
        //        // format of the response, which you can inspect using the responseBody variable.
        //        // In this example, we'll just return the entire response body as the IBAN.
        //        return responseBody;
        //    }

        //static async Task Main()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        try
        //        {
        //            client.BaseAddress = new Uri("http://randomiban.com");
        //            HttpResponseMessage response = await client.GetAsync("/?country=Netherlands");
        //            response.EnsureSuccessStatusCode();
        //            string responseBody = await response.Content.ReadAsStringAsync();
        //            Console.WriteLine(responseBody);

        //            // Extract the IBAN from the response
        //            string iban = ExtractIban(responseBody);
        //            Console.WriteLine("IBAN: " + iban);
        //        }
        //        catch (HttpRequestException e)
        //        {
        //            Console.WriteLine("\nException Caught!");
        //            Console.WriteLine("Message :{0} ", e.Message);
        //        }
        //    }
        //}



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //currrentAccount = 
        }

    }

 
}




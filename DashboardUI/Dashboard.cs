using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DashboardUI.Validators;
using ModelLibrary;
using FluentValidation.Results;

namespace DashboardUI
{
  public partial class Dashboard : Form
  {
    BindingList<string> errors = new BindingList<string>();

    public Dashboard()
    {
      InitializeComponent();

      errorListBox.DataSource = errors;
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      errors.Clear();

      if (!int.TryParse(accountNumberText.Text, out int accountNumber))
      {
        errors.Add("Account Number: Invalid Amount");
        return;
      }

      PersonModel person = new PersonModel();
      person.FirstName = firstNameText.Text;
      person.LastName = lastNameText.Text;
      person.AccountNumber = Convert.ToInt32(accountNumberText.Text);
      person.DateOfBirth = dateOfBirthPicker.Value;

      // Validate data
      PersonValidator validator = new PersonValidator();

      ValidationResult results = validator.Validate(person);

      if (results.IsValid == false)
      {
          foreach (ValidationFailure failure in results.Errors)
          {
             errors.Add($"{failure.ErrorMessage }");
          }
      }
      // Insert into the database

      MessageBox.Show("Operation Complete");
    }

        private void accountBalanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

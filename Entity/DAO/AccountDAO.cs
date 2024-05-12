using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public class AccountDAO
    {
        FindingJob db = new FindingJob();
        public bool GetAccount(Account account)
        {
            var result = db.Accounts
                    .Where(a => a.Email == account.Email && a.Password == account.Password)
                    .Select(a => new
                    {
                        a.Email,
                        a.Password,
                        a.Type
                    })
                    .FirstOrDefault();

            // Check if an account was found
            if (result != null)
            {
                // Update the properties of the account object
                account.Email = result.Email;
                account.Password = result.Password;
                account.Type = result.Type;

                // Set the name based on the account type
                switch (result.Type)
                {
                    case "jobseeker":
                        account.Email = db.JobSeekers.FirstOrDefault(j => j.Email == result.Email)?.Email;
                        break;
                    case "company":
                        account.Email = db.Companies.FirstOrDefault(c => c.Email == result.Email)?.Email;
                        break;
                    default:
                        account.Email = null;
                        MessageBox.Show("Account not found");
                        return false;
                }

                return true; // Account found
            }
            else
            {
                return false; // Account not found
            }
        }
    }
}

using NumericValueToWord.Helper;
using System;
using System.Web.Helpers;
using System.Web.Script.Services;
using System.Web.Services;

namespace NumericValueToWord.WebService
{
    /// <summary>
    /// Summary description for NumericValueToWord
    /// This is a webservice class which is accessed through JavaScript
    /// to get the word based on the given numeric value
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class NumericValueToWord : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
        public string ConvertNumericValueToWord(string dollarNumber, string name, string centNumber)
        {
            // Null Check. Return with message if dollar or name is null.
            if (string.IsNullOrWhiteSpace(dollarNumber) || string.IsNullOrWhiteSpace(name))
            {
                return "Error: Please enter the name and number properly";
            }

            try
            {
                string output = "";

                //Dollar
                int myInt;
                // possible int 
                if (int.TryParse(dollarNumber, out myInt))
                {
                    // It;s an Int
                    output = Helper.WebServiceHelper.NumberToWordsDollar(myInt);
                }
                else
                {
                    return "Error: Please enter the number properly and do not enter more than 2 billion dollars";
                }

                //Cent
                if (!string.IsNullOrWhiteSpace(centNumber) && int.TryParse(centNumber, out myInt))
                {
                    // It;s an Int
                    if (centNumber.Length == 1)
                    {
                        myInt = myInt * 10;
                    }
                    output += " and " + Helper.WebServiceHelper.NumberToWordsCent(myInt);
                }

                var responseObj = new { Name = name, Word = output };
                return Json.Encode(responseObj);

            }
            catch (Exception ex)
            {
                return "Error: "+ex.Message;
            }
        }
    }
}

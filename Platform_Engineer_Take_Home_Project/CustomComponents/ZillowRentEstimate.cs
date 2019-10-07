using System;
using System.Net.Http;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;

namespace CustomComponents
{
    public class ZillowRentEstimate
    {
        private string zwsId;
        private double annualRent;

        public ZillowRentEstimate(string zwsId, double annualRent = 0.05)
        {
            this.zwsId = zwsId;
            this.annualRent = annualRent;
        }

        public ZillowRentEstimate()
        {
        }

        public string ZwsId { get => zwsId; set => zwsId = value; }
        public double AnnualRent { get => annualRent; set => annualRent = value; }

        public async Task<RentEstimate> GetRentEstimateAsync(string address, string city, string state, string zip)
        {
            RentEstimate rentEstimate = new RentEstimate { RentPrice="0", PropertyCost="0" };
            string cityStateZip = city + "+" + state + "+" + zip;
            string zpid;
            string code1;
            string code2;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.zillow.com/webservice/GetDeepSearchResults.htm?zws-id=" + zwsId + "&address=" + address + " &citystatezip=" + cityStateZip))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    XDocument doc = XDocument.Parse(apiResponse);
                    var message_node = (from a in doc.Descendants("message") select a).SingleOrDefault();

                    code1 = (from c in doc.Descendants("code") select c).SingleOrDefault().Value;
                    if (code1 == null || code1 != "0")
                        return rentEstimate;

                    zpid = (from c in doc.Descendants("zpid")
                            select c).SingleOrDefault().Value;
                }
            }

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://www.zillow.com/webservice/GetZestimate.htm?zws-id=" + zwsId + "&zpid=" + zpid + "&rentzestimate=true"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    XDocument doc = XDocument.Parse(apiResponse);
                    var message_node = (from a in doc.Descendants("message") select a).SingleOrDefault();

                    code2 = (from c in doc.Descendants("code")
                             select c).SingleOrDefault().Value;

                    if (code1 == null || code1 != "0")
                        return rentEstimate;

                    var zestimate = (from c in doc.Descendants("zestimate") select c).SingleOrDefault();
                    rentEstimate.PropertyCost = (from c in zestimate.Descendants("amount") select c).SingleOrDefault().Value;


                    var rentzestimate = (from c in doc.Descendants("rentzestimate") select c).SingleOrDefault();

                    if (rentzestimate != null)
                        rentEstimate.RentPrice = (from c in rentzestimate.Descendants("amount") select c).SingleOrDefault().Value;
                    else
                        rentEstimate.RentPrice = (Double.Parse(rentEstimate.PropertyCost) * annualRent).ToString();
                }
            }

            return rentEstimate;
        }
    }
}

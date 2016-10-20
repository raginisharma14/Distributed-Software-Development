using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace WcfCrimeAttackService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {

            return string.Format("You entered: {0}", value);
        }
        /*
         * Below method takes in zipcode and give no of crime attacks in that location.
         */ 
        public int GetNoOfCrimeAttacks(int zipcode)
        {

            string crime_attack_url = "https://azure.geodataservice.net/GeoDataService.svc/GetUSDemographics?includecrimedata=true&zipcode=" + zipcode;

            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(crime_attack_url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

           
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(response.GetResponseStream());

          
            XmlNodeList value = xmlDocument.GetElementsByTagName("ViolentCrime");
       
            XmlNodeList value1 = xmlDocument.GetElementsByTagName("MurderAndManslaughter");
            XmlNodeList value2 = xmlDocument.GetElementsByTagName("ForcibleRape");
            XmlNodeList value3 = xmlDocument.GetElementsByTagName("Robbery");
            XmlNodeList value4 = xmlDocument.GetElementsByTagName("AggravatedAssault");
            XmlNodeList value5 = xmlDocument.GetElementsByTagName("PropertyCrime");
            XmlNodeList value6 = xmlDocument.GetElementsByTagName("Burglary");
            XmlNodeList value7 = xmlDocument.GetElementsByTagName("LarcenyTheft");
            XmlNodeList value8 = xmlDocument.GetElementsByTagName("MotorVehicleTheft");
            XmlNodeList value9 = xmlDocument.GetElementsByTagName("Arson");
           
            return (Convert.ToInt32(value.Item(0).InnerText) + Convert.ToInt32(value1.Item(0).InnerText) + Convert.ToInt32(value2.Item(0).InnerText) +
            Convert.ToInt32(value3.Item(0).InnerText) + Convert.ToInt32(value4.Item(0).InnerText) + Convert.ToInt32(value5.Item(0).InnerText) + Convert.ToInt32(value6.Item(0).InnerText) + Convert.ToInt32(value7.Item(0).InnerText)
            + Convert.ToInt32(value8.Item(0).InnerText) + Convert.ToInt32(value9.Item(0).InnerText));

        }
       
    }
}

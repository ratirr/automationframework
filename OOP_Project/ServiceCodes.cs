using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class ServiceCodes
    {

        public ServiceCodes()
        {

        }

        public ServiceCodes(string _serviceCode)
        {
            ServiceCode = _serviceCode;
        }

        private string _ServiceCode { get; set; }

        public string ServiceCode
        {
            get => _ServiceCode; 
            set {

                // _ServiceCode = value;
                if (value != null)
                {
                    _ServiceCode = value;
                }
                else
                { throw new Exception("c"); }
            }
            

        }
        public DateTimeOffset? TestDate { get; set; }
        public double Cost { get; set; }
        public string ServiceDescription {get; set;}
        private string _cliniciansComments;
        public string CliniciansComments
        {
            get { return _cliniciansComments = "Total charges on service code:" + ServiceCode + " is " + "$" + Cost; }

            set { _cliniciansComments = value; }
        }

        public double NeverHaveBlankCost()
        {
            var cost = Cost;

            if (Cost == 0) cost = 0 ;

            return cost;
        }


    }
}

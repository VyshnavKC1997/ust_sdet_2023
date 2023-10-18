using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Electricity
    {
        int consumerNumber, previousReading, currentReading;
        string? consumerName;
/*        public Electricity()
        {
            consumerNumber = 12345;
            previousReading = 9000;
            currentReading = 9300;
            consumerName= "vyshnav";
        }
*/
        public Electricity(int consumerNumber, int previousReading, int currentReading, string? consumerName)
        {
            this.consumerNumber = consumerNumber;
            this.previousReading = previousReading;
            this.currentReading = currentReading;
            this.consumerName = consumerName;
        }

        public double CalculateBill()
        {
            double billAmount = 0;
            int reading = currentReading - previousReading;
            if (reading <= 100)
            {
                billAmount = reading * 2.00;
            }
            else if(reading <= 201)
            {
                billAmount = (100*2)+((reading-100)*2.5);
            }
            else if(reading <= 401)
            {
                billAmount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
            }
            else
            {
                billAmount = (100 * 2) + (100 * 2.5) + ((reading - 400) * 3.5);
            }
            return billAmount;
        }
    }
}

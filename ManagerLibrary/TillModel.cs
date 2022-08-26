using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLibrary
{
    public enum TillStatusType { Pending, Active, Closed, Verified }
    public class TillModel
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public UserModel Attendant { get; set; }
        public TillStatusType Status { get; set; }
    }
}

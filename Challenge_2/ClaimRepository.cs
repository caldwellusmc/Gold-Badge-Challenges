using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepository
    {
        Queue<Claim> _queueOfClaims = new Queue<Claim>();
        bool _isValid;

        public void AddClaimToQueue(Claim claims)
        {
            _queueOfClaims.Enqueue(claims);
        }

        public Queue<Claim> ViewClaims()
        {
            return _queueOfClaims;
        }

        public bool GetBoolan(Claim claims)
        {
            TimeSpan TimeBetweenDates = Convert.ToDateTime(claims.DateOfClaim) - Convert.ToDateTime(claims.DateOfIncident);

            bool IsValid;
            if(TimeBetweenDates.Days <= 30)
            {
                _isValid = true;
            }
            else
            {
                _isValid = false;
            }

            IsValid = _isValid;
            return IsValid;
        }
    }
}

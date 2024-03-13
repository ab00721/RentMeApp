using RentMeApp.Model;
using System;
using System.Collections.Generic;

namespace RentMeApp.DAL
{
    public class MemberDALX
    {
        private DateOnly thedate = new DateOnly(2015, 10, 21);
        private static readonly List<MemberX> _members = new List<MemberX>
        {
            
            new MemberX(1, "John", "Doe", 'M', DateOnly.Parse("1/1/1999"), "123 Main St.", "321 Main St.", "Atlanta", "GA", 30000, "111-111-1111"),
            new MemberX(2, "Jane", "Doe", 'M', DateOnly.Parse("1/1/1999"), "123 Main St.", "321 Main St.", "Atlanta", "GA", 30000, "222-222-2222"),
            new MemberX(3, "Harry", "Potter", 'M', DateOnly.Parse("1/1/1999"), "123 Main St.", "321 Main St.", "Atlanta", "GA", 30000, "333-333-3333")
        };

        /// <summary>
        /// Gets the member information.
        /// </summary>
        /// <returns></returns>
        public List<MemberX> GetMemberInfo()
        {
            return _members;
        }

        /// <summary>
        /// Registers the specified member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <exception cref="System.ArgumentNullException">Member cannot be null</exception>
        public void Register(MemberX member)
        {

            if (member == null)
            {
                throw new ArgumentNullException("Member cannot be null");
            }

            _members.Add(member);

        }

        /// <summary>
        /// Searches the by member identifier.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns></returns>
        public List<MemberX> SearchByMemberID(int memberID)
        {
            return _members;
        }

    }
}

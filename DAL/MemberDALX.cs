using RentMeApp.Model;
using System;
using System.Collections.Generic;

namespace RentMeApp.DAL
{
    public class MemberDALX
    {
        private static readonly List<MemberX> _members = new List<MemberX>
        {
            new MemberX(1, "John", "Doe", "M", DateTime.Now, "123 Main"),
            new MemberX(2, "Jane", "Doe", "F", DateTime.Now, "123 Main"),
            new MemberX(3, "Harry", "Potter", "M", DateTime.Now, "123 Hogwarts"),
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
